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
                MessageBox.Show("Empty Account");
                return;
            }

            if (tbxPassword.Text == "")
            {
                MessageBox.Show("Empty Password");
                return;
            }

            if (tbxConfirmPassword.Text == "")
            {
                MessageBox.Show("Empty Confirm Password");
                return;
            }

            ENUM_ACCOUNT result = Program.accountManager.Join(tbxAccount.Text, tbxPassword.Text, tbxConfirmPassword.Text);
            switch (result)
            {
                case ENUM_ACCOUNT.ACCOUNT_ALREADY_EXIST:
                    MessageBox.Show("ACCOUNT ALREADY EXIST");
                    return;

                case ENUM_ACCOUNT.PASSWORD_CONFIRM_FAILED:
                    MessageBox.Show("PASSWORD CONFIRM FAILED");
                    return;
            }

            Close();
        }
    }
}
