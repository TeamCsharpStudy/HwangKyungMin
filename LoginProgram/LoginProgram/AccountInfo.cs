namespace LoginProgram
{
	class AccountInfo
	{
		public string account  { get; set; }
		public string password { get; set; }
		public bool activate   { get; set; }
		public bool admin      { get; set; }

		public AccountInfo(string account, string password, bool activate, bool admin)
		{
			this.account  = account;
			this.password = password;
			this.activate = activate;
			this.admin    = admin;
		}
	}
}
