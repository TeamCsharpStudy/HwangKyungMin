using System.Collections.Generic;

namespace LoginProgram
{
    public enum ENUM_ACCOUNT
    {
        OK = 0x0,
        ACCOUNT_ALREADY_EXIST = 0x1,
        PASSWORD_CONFIRM_FAILED = 0x2,
        ACCOUNT_DOES_NOT_EXIST = 0x10,
        PASSWORD_DOES_NOT_MATCH = 0x20,
    }

    class Account
    {
        public string account { get; set; }
        public string password { get; set; }

        public Account(string account = "", string password = "")
        {
            this.account  = account;
            this.password = password;
        }
    }

    class AccountManager
    {
        private List<Account> AccountList = new List<Account>();

        public AccountManager()
        {
        }

        private ENUM_ACCOUNT CheckAccount(string account)
        {
            foreach(Account t in AccountList)
            {
                if (t.account.Equals(account))
                    return ENUM_ACCOUNT.ACCOUNT_ALREADY_EXIST;
            }

            return ENUM_ACCOUNT.OK;
        }

        private ENUM_ACCOUNT ConfirmPasssword(string password, string confirmPassword)
        {
            if (password.Equals(confirmPassword) == false)
                return ENUM_ACCOUNT.PASSWORD_CONFIRM_FAILED;

            return ENUM_ACCOUNT.OK;
        }

        public ENUM_ACCOUNT Join(string account, string password, string confirmPassword)
        {
            ENUM_ACCOUNT result = ENUM_ACCOUNT.OK;

            result = CheckAccount(account);
            // 계정 중복성 검사
            if (result != ENUM_ACCOUNT.OK)
                return result;

            // 비밀번호 오류 검사
            result = ConfirmPasssword(password, confirmPassword);
            if (result != ENUM_ACCOUNT.OK)
                return result;

            AccountList.Add(new Account(account, password));

            return ENUM_ACCOUNT.OK;
        }

        public ENUM_ACCOUNT Login(string account, string password)
        {
            foreach (Account t in AccountList)
            {
                 if (t.account.Equals(account) == false)
                    continue;

                if (t.password.Equals(password) == false)
                    return ENUM_ACCOUNT.PASSWORD_DOES_NOT_MATCH;

                return ENUM_ACCOUNT.OK;
            }

            return ENUM_ACCOUNT.ACCOUNT_DOES_NOT_EXIST;
        }
    }
}
