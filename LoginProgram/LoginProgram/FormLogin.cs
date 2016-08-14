using System;
using System.Windows.Forms;

namespace LoginProgram
{
	public partial class FormLogin : Form
	{
		public FormLogin()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e)
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

			E_ACCOUNT result = Program.accountManager.Login(tbxAccount.Text, tbxPassword.Text);
			switch (result)
			{
				case E_ACCOUNT.ACCOUNT_DOES_NOT_EXIST:
					MessageBox.Show("Account does not exist");
					return;

				case E_ACCOUNT.PASSWORD_DOES_NOT_MATCH:
					MessageBox.Show("Password does not match");
					return;

				case E_ACCOUNT.ACCOUNT_DOES_NOT_ACTIVATED:
					MessageBox.Show("Account does not activated");
					return;
			}

			DialogResult = DialogResult.OK;
			Close();
		}

		private void btnJoin_Click(object sender, EventArgs e)
		{
			FormJoin join = new FormJoin();

			join.ShowDialog();
		}
	}
}
