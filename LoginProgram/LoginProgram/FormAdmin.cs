using System.Collections.Generic;
using System.Windows.Forms;

namespace LoginProgram
{
	public partial class FormAdmin : Form
	{
		public FormAdmin()
		{
			InitializeComponent();
		}

		private void FormAdmin_Load(object sender, System.EventArgs e)
		{
			DisplayAccountInfoList();
		}

		private void DisplayAccountInfoList()
		{
			lsvAccountInfoList.Items.Clear();

			var accountInfoList = Program.accountManager.GetAccountInfoList();
			string searchFilter = tbxSearchAccount.Text;
			if (searchFilter.Length > 0)
			{
				if (accountInfoList.ContainsKey(searchFilter))
				{
					AccountInfo accountInfo = accountInfoList[searchFilter];

					ListViewItem lviAccountInfo = new ListViewItem(accountInfo.account);

					lviAccountInfo.SubItems.Add(accountInfo.password);
					lviAccountInfo.SubItems.Add(accountInfo.activate ? "v" : "");
					lviAccountInfo.SubItems.Add(accountInfo.admin ? "v" : "");

					lviAccountInfo.Tag = accountInfo;

					lsvAccountInfoList.Items.Add(lviAccountInfo);
				}
			}
			else
			{
				foreach (var t in accountInfoList)
				{
					AccountInfo accountInfo = t.Value;

					ListViewItem lviAccountInfo = new ListViewItem(accountInfo.account);

					lviAccountInfo.SubItems.Add(accountInfo.password);
					lviAccountInfo.SubItems.Add(accountInfo.activate ? "v" : "");
					lviAccountInfo.SubItems.Add(accountInfo.admin ? "v" : "");

					lviAccountInfo.Tag = accountInfo;

					lsvAccountInfoList.Items.Add(lviAccountInfo);
				}
			}
		}

		private void lsvAccountInfoList_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (lsvAccountInfoList.SelectedItems.Count == 1)
			{
				ListViewItem lviAccountInfo = lsvAccountInfoList.SelectedItems[0];
				AccountInfo  accountInfo    = (AccountInfo)lviAccountInfo.Tag;

				tbxAccount .Text    = accountInfo.account;
				chkActivate.Checked = accountInfo.activate;
				chkAdmin   .Checked = accountInfo.admin;
			}
			else
			{
				tbxAccount .Text    = "";
				chkActivate.Checked = false;
				chkAdmin   .Checked = false;
			}
		}

		private void btnApply_Click(object sender, System.EventArgs e)
		{
			if (lsvAccountInfoList.SelectedItems.Count == 1)
			{
				ListViewItem lviAccountInfo = lsvAccountInfoList.SelectedItems[0];
				AccountInfo  accountInfo    = (AccountInfo)lviAccountInfo.Tag;

				// activate 변경 사항이 있는 경우에만 적용
				if (accountInfo.activate != chkActivate.Checked)
				{
					accountInfo.activate = chkActivate.Checked;
					lviAccountInfo.SubItems[2].Text = accountInfo.activate ? "v" : "";
				}

				// admin 변경 사항이 있는 경우에만 적용
				if (accountInfo.admin != chkAdmin.Checked)
				{
					accountInfo.admin = chkAdmin.Checked;
					lviAccountInfo.SubItems[3].Text = accountInfo.admin ? "v" : "";
				}
			}
		}

		private void btnDelete_Click(object sender, System.EventArgs e)
		{
			ListView.SelectedListViewItemCollection selectedItems = lsvAccountInfoList.SelectedItems;
			foreach(ListViewItem lviAccountInfo in selectedItems)
			{
				AccountInfo accountInfo = (AccountInfo)lviAccountInfo.Tag;

				if (Program.accountManager.DeleteAccount(accountInfo.account) == false)
				{
					DisplayAccountInfoList();
					break;
				}

				lsvAccountInfoList.Items.Remove(lviAccountInfo);
			}

			tbxAccount .Text    = "";
			chkActivate.Checked = false;
			chkAdmin   .Checked = false;
		}

		private void tbxSearchFilter_KeyUp(object sender, KeyEventArgs e)
		{
			DisplayAccountInfoList();
		}
	}
}
