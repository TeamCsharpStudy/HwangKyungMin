using System;
using System.Windows.Forms;

namespace LoginProgram
{
	public partial class FormJoin : Form
	{
		public FormJoin()
		{
			InitializeComponent();
		}

		private void btnJoin_Click(object sender, EventArgs e)
		{
			if (tbxAccount.Text == "")
			{
				MessageBox.Show("Empty account");
				return;
			}

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

			E_ACCOUNT result = Program.accountManager.Join(tbxAccount.Text, tbxPassword.Text, tbxConfirmPassword.Text);
			switch (result)
			{
				case E_ACCOUNT.ACCOUNT_ALREADY_EXIST:
					MessageBox.Show("Account already exist");
					return;

				case E_ACCOUNT.PASSWORD_CONFIRM_FAILED:
					MessageBox.Show("Password confirm failed");
					return;
			}

			Close();
		}
	}
}
