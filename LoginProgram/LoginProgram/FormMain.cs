using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginProgram
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbxAccount.Text == "")
            {
                MessageBox.Show("Empty Account");
                return;
            }

            if (tbxPassword.Text == "")
            {
                MessageBox.Show("Empty Password");
                return;
            }

            ENUM_ACCOUNT result = Program.accountManager.Login(tbxAccount.Text, tbxPassword.Text);
            switch (result)
            {
                case ENUM_ACCOUNT.ACCOUNT_DOES_NOT_EXIST:
                    MessageBox.Show("ACCOUNT DOES NOT EXIST");
                    return;

                case ENUM_ACCOUNT.PASSWORD_DOES_NOT_MATCH:
                    MessageBox.Show("PASSWORD DOES NOT MATCH");
                    return;
            }

            MessageBox.Show("OK");
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            FormJoin join = new FormJoin();
            join.ShowDialog();
        }
    }
}
