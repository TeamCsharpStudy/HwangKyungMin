using System;
using System.Windows.Forms;

namespace LoginProgram
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
		}

		private void FormMain_Load(object sender, EventArgs e)
		{
			Program.accountManager.LoadAccountInfo();

			DisplayLogin();
		}

		private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			Program.accountManager.SaveAccountInfo();
		}

		private void btnAdmin_Click(object sender, EventArgs e)
		{
			DisplayForm(false);

			FormAdmin admin = new FormAdmin();
			admin.ShowDialog();

			DisplayForm(true);
		}

		private void btnApply_Click(object sender, EventArgs e)
		{
			if (tbxPassword.Text == "")
			{
				MessageBox.Show("Empty password");
				return;
			}

			if (tbxConfirmPassword.Text == "")
			{
				MessageBox.Show("Empty confirm password");
				return;
			}

			E_ACCOUNT result = Program.accountManager.ChangePassword(tbxPassword.Text, tbxConfirmPassword.Text);
			switch (result)
			{
				case E_ACCOUNT.NOBODY_HAVE_LOGINED:
					MessageBox.Show("Nobody have logined");
					break;

				case E_ACCOUNT.ACCOUNT_DOES_NOT_EXIST:
					MessageBox.Show("Account does not exist");
					break;

				case E_ACCOUNT.PASSWORD_CONFIRM_FAILED:
					MessageBox.Show("Password confirm failed");
					break;

				case E_ACCOUNT.OK:
					MessageBox.Show("Password have changed");
					break;
			}
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			E_ACCOUNT result = Program.accountManager.Logout();
			switch (result)
			{
				case E_ACCOUNT.NOBODY_HAVE_LOGINED:
					MessageBox.Show("Nobody have logined");
					break;
			}

			DisplayLogin();
		}

		private void DisplayForm(bool endabled = true)
		{
			if (endabled)
			{
				Opacity = 100;
				ShowInTaskbar = true;
			}
			else
			{
				Opacity = 0;
				ShowInTaskbar = false;
			}
		}

		private void DisplayAccountInfo()
		{
			string currentLoginAccount = Program.accountManager.GetCurrentLoginAccount();
			AccountInfo accountInfo = Program.accountManager.GetAccountInfo(currentLoginAccount);

			tbxAccount .Text    = accountInfo.account;
			chkActivate.Checked = accountInfo.activate;
			chkAdmin   .Checked = accountInfo.admin;
			chkAdmin   .Visible = accountInfo.admin;
			btnAdmin   .Enabled = accountInfo.admin;
			btnAdmin   .Visible = accountInfo.admin;
		}
		private void DisplayLogin()
		{
			DisplayForm(false);

			FormLogin login = new FormLogin();
			if (login.ShowDialog() != DialogResult.OK)
			{
				Close();
				return;
			}

			DisplayAccountInfo();

			DisplayForm(true);
		}
	}
}
