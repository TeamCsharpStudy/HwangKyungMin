using System.Collections.Generic;
using System.Xml;
using System.IO;

namespace LoginProgram
{
	public enum E_ACCOUNT
	{
		OK                         = 0x00,	// 정상값
		ACCOUNT_ALREADY_EXIST      = 0x01,	// 이미 존재하는 계정을 입력했을 경우
		ACCOUNT_DOES_NOT_EXIST     = 0x02,	// 존재하지 않는 계정을 입력했을 경우
		PASSWORD_CONFIRM_FAILED    = 0x04,	// 입력한 패스워드와 검증 패스워드가 일치하지 않을 경우
		PASSWORD_DOES_NOT_MATCH    = 0x08,	// 입력한 계정의 비밀번호가 정확하지 않을 경우
		NOBODY_HAVE_LOGINED        = 0x10,	// 로그인 상태가 아닐 경우
		ACCOUNT_DOES_NOT_ACTIVATED = 0x20,	// 계정이 활성화되지 않은 경우
	}

	class AccountManager
	{
		// 관리자 계정
		private const string admin = "admin";

		// 현재 로그인 계정
		private string currentLoginAccount = "";

		// 사용자 리스트 데이터 파일
		private string dataFile = "AccountInfoList.xml";

		// 사용자 리스트 데이터 컨테이너 (바이너리 트리 구조)
		private Dictionary<string, AccountInfo> accountInfoList = new Dictionary<string, AccountInfo>();

		public AccountManager()
		{
		}

		// 계정 생성시 중복 확인
		private bool CheckAccountDuplication(string account)
		{
			return accountInfoList.ContainsKey(account);
		}

		// 계정 생성시 비밀번호 오류 검증
		private bool ConfirmPasssword(string password, string confirmPassword)
		{
			return password.Equals(confirmPassword);
		}

		// 계정 생성
		public E_ACCOUNT Join(string account, string password, string confirmPassword)
		{
			// 계정 중복성 검사
			if (CheckAccountDuplication(account) == true)
				return E_ACCOUNT.ACCOUNT_ALREADY_EXIST;

			// 비밀번호 오류 검사
			if (ConfirmPasssword(password, confirmPassword) == false)
				return E_ACCOUNT.PASSWORD_DOES_NOT_MATCH;

			accountInfoList.Add(account, new AccountInfo(account, password, false, false));

			return E_ACCOUNT.OK;
		}

		// 계정 로그인
		public E_ACCOUNT Login(string account, string password)
		{
			// 계정 유무 검사
			if (CheckAccountDuplication(account) == false)
				return E_ACCOUNT.ACCOUNT_DOES_NOT_EXIST;

			// 비밀번호 일치 검사
			if (ConfirmPasssword(password, accountInfoList[account].password) == false)
				return E_ACCOUNT.PASSWORD_DOES_NOT_MATCH;

			// Activate 권한 검사
			if (accountInfoList[account].activate == false)
				return E_ACCOUNT.ACCOUNT_DOES_NOT_ACTIVATED;

			// 로그인 처리
			currentLoginAccount = account;

			return E_ACCOUNT.OK;
		}

		// 계정 로그아웃
		public E_ACCOUNT Logout()
		{
			E_ACCOUNT result = E_ACCOUNT.OK;

			if (currentLoginAccount == "")
			{
				result = E_ACCOUNT.NOBODY_HAVE_LOGINED;
			}
			else
			{
				currentLoginAccount = "";
				result = E_ACCOUNT.OK;
			}

			return result;
		}

		// 비밀번호 변경 처리
		public E_ACCOUNT ChangePassword(string password, string confirmPassword)
		{
			if (currentLoginAccount == "")
				return E_ACCOUNT.NOBODY_HAVE_LOGINED;

			// 계정 유무 검사
			if (CheckAccountDuplication(currentLoginAccount) == false)
				return E_ACCOUNT.ACCOUNT_DOES_NOT_EXIST;

			// 비밀번호 오류 검사
			if (ConfirmPasssword(password, confirmPassword) == false)
				return E_ACCOUNT.PASSWORD_CONFIRM_FAILED;

			// 비밀번호 변경 처리
			accountInfoList[currentLoginAccount].password = password;

			return E_ACCOUNT.OK;
		}

		public AccountInfo GetAccountInfo(string account)
		{
			return accountInfoList[account];
		}

		public string GetCurrentLoginAccount()
		{
			return currentLoginAccount;
		}

		public bool DeleteAccount(string account)
		{
			return accountInfoList.Remove(account);
		}

		public Dictionary<string, AccountInfo> GetAccountInfoList()
		{
			return accountInfoList;
		}

		// 사용자 리스트 데이터 로딩
		public void LoadAccountInfo()
		{
			if (File.Exists(dataFile) == false)
			{
				accountInfoList.Add(admin, new AccountInfo(admin, admin, true, true));
				return;
			}

			XmlDocument doc = new XmlDocument();
			doc.Load(dataFile);

			XmlNodeList xmlAccountInfoList = doc.SelectNodes("/AccountInfoList/AccountInfo");

			accountInfoList.Clear();

			foreach (XmlNode t in xmlAccountInfoList)
			{
				XmlNode nodeaccount  = t.SelectSingleNode("Account" );
				XmlNode nodepassword = t.SelectSingleNode("Password");
				XmlNode nodeactivate = t.SelectSingleNode("Activate");
				XmlNode nodeadmin    = t.SelectSingleNode("Admin"   );

				string account  =            nodeaccount .InnerText;
				string password =            nodepassword.InnerText;
				bool   activate = bool.Parse(nodeactivate.InnerText);
				bool   admin    = bool.Parse(nodeadmin   .InnerText);

				accountInfoList.Add(account, new AccountInfo(account, password, activate, admin));
			}

			if (CheckAccountDuplication(admin) == false)
				accountInfoList.Add(admin, new AccountInfo(admin, admin, true, true));
		}

		// 사용자 리스트 데이터 저장
		public void SaveAccountInfo()
		{
			XmlDocument doc = new XmlDocument();

			XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "utf-8", "yes");

			XmlNode nodeAccountInfoList = doc.CreateElement("AccountInfoList");

			foreach (var t in accountInfoList)
			{
				AccountInfo accountInfo = t.Value;

				XmlNode nodeAccountInfo = doc.CreateElement("AccountInfo");
				XmlNode nodeAccount     = doc.CreateElement("Account"    );
				XmlNode nodePassword    = doc.CreateElement("Password"   );
				XmlNode nodeActivate    = doc.CreateElement("Activate"   );
				XmlNode nodeAdmin       = doc.CreateElement("Admin"      );

				nodeAccount .InnerText = accountInfo.account;
				nodePassword.InnerText = accountInfo.password;
				nodeActivate.InnerText = accountInfo.activate.ToString();
				nodeAdmin   .InnerText = accountInfo.admin   .ToString();

				nodeAccountInfo    .AppendChild(nodeAccount    );
				nodeAccountInfo    .AppendChild(nodePassword   );
				nodeAccountInfo    .AppendChild(nodeActivate   );
				nodeAccountInfo    .AppendChild(nodeAdmin      );
				nodeAccountInfoList.AppendChild(nodeAccountInfo);
			}

			doc.AppendChild(xmlDeclaration);
			doc.AppendChild(nodeAccountInfoList);
			doc.Save(dataFile);
		}
	}
}
