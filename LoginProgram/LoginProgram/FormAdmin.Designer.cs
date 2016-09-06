namespace LoginProgram
{
	partial class FormAdmin
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.spcAccountInfoList_Control = new System.Windows.Forms.SplitContainer();
			this.splitSearchAccount_AccountList = new System.Windows.Forms.SplitContainer();
			this.spcSearchAccount_Label_TextBox = new System.Windows.Forms.SplitContainer();
			this.lblSearchAccount = new System.Windows.Forms.Label();
			this.tbxSearchAccount = new System.Windows.Forms.TextBox();
			this.lsvAccountInfoList = new System.Windows.Forms.ListView();
			this.colAccount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colPassword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colActivate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colAdmin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnDelete = new System.Windows.Forms.Button();
			this.lblAccount = new System.Windows.Forms.Label();
			this.tbxAccount = new System.Windows.Forms.TextBox();
			this.chkActivate = new System.Windows.Forms.CheckBox();
			this.chkAdmin = new System.Windows.Forms.CheckBox();
			this.btnApply = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.spcAccountInfoList_Control)).BeginInit();
			this.spcAccountInfoList_Control.Panel1.SuspendLayout();
			this.spcAccountInfoList_Control.Panel2.SuspendLayout();
			this.spcAccountInfoList_Control.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitSearchAccount_AccountList)).BeginInit();
			this.splitSearchAccount_AccountList.Panel1.SuspendLayout();
			this.splitSearchAccount_AccountList.Panel2.SuspendLayout();
			this.splitSearchAccount_AccountList.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.spcSearchAccount_Label_TextBox)).BeginInit();
			this.spcSearchAccount_Label_TextBox.Panel1.SuspendLayout();
			this.spcSearchAccount_Label_TextBox.Panel2.SuspendLayout();
			this.spcSearchAccount_Label_TextBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// spcAccountInfoList_Control
			// 
			this.spcAccountInfoList_Control.Dock = System.Windows.Forms.DockStyle.Fill;
			this.spcAccountInfoList_Control.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.spcAccountInfoList_Control.IsSplitterFixed = true;
			this.spcAccountInfoList_Control.Location = new System.Drawing.Point(0, 0);
			this.spcAccountInfoList_Control.Name = "spcAccountInfoList_Control";
			// 
			// spcAccountInfoList_Control.Panel1
			// 
			this.spcAccountInfoList_Control.Panel1.Controls.Add(this.splitSearchAccount_AccountList);
			// 
			// spcAccountInfoList_Control.Panel2
			// 
			this.spcAccountInfoList_Control.Panel2.AutoScroll = true;
			this.spcAccountInfoList_Control.Panel2.Controls.Add(this.btnDelete);
			this.spcAccountInfoList_Control.Panel2.Controls.Add(this.lblAccount);
			this.spcAccountInfoList_Control.Panel2.Controls.Add(this.tbxAccount);
			this.spcAccountInfoList_Control.Panel2.Controls.Add(this.chkActivate);
			this.spcAccountInfoList_Control.Panel2.Controls.Add(this.chkAdmin);
			this.spcAccountInfoList_Control.Panel2.Controls.Add(this.btnApply);
			this.spcAccountInfoList_Control.Size = new System.Drawing.Size(784, 161);
			this.spcAccountInfoList_Control.SplitterDistance = 500;
			this.spcAccountInfoList_Control.TabIndex = 0;
			// 
			// splitSearchAccount_AccountList
			// 
			this.splitSearchAccount_AccountList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitSearchAccount_AccountList.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitSearchAccount_AccountList.IsSplitterFixed = true;
			this.splitSearchAccount_AccountList.Location = new System.Drawing.Point(0, 0);
			this.splitSearchAccount_AccountList.Name = "splitSearchAccount_AccountList";
			this.splitSearchAccount_AccountList.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitSearchAccount_AccountList.Panel1
			// 
			this.splitSearchAccount_AccountList.Panel1.Controls.Add(this.spcSearchAccount_Label_TextBox);
			// 
			// splitSearchAccount_AccountList.Panel2
			// 
			this.splitSearchAccount_AccountList.Panel2.Controls.Add(this.lsvAccountInfoList);
			this.splitSearchAccount_AccountList.Size = new System.Drawing.Size(500, 161);
			this.splitSearchAccount_AccountList.SplitterDistance = 25;
			this.splitSearchAccount_AccountList.TabIndex = 0;
			// 
			// spcSearchAccount_Label_TextBox
			// 
			this.spcSearchAccount_Label_TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.spcSearchAccount_Label_TextBox.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.spcSearchAccount_Label_TextBox.IsSplitterFixed = true;
			this.spcSearchAccount_Label_TextBox.Location = new System.Drawing.Point(0, 0);
			this.spcSearchAccount_Label_TextBox.Name = "spcSearchAccount_Label_TextBox";
			// 
			// spcSearchAccount_Label_TextBox.Panel1
			// 
			this.spcSearchAccount_Label_TextBox.Panel1.Controls.Add(this.lblSearchAccount);
			// 
			// spcSearchAccount_Label_TextBox.Panel2
			// 
			this.spcSearchAccount_Label_TextBox.Panel2.Controls.Add(this.tbxSearchAccount);
			this.spcSearchAccount_Label_TextBox.Size = new System.Drawing.Size(500, 25);
			this.spcSearchAccount_Label_TextBox.SplitterDistance = 148;
			this.spcSearchAccount_Label_TextBox.TabIndex = 0;
			// 
			// lblSearchAccount
			// 
			this.lblSearchAccount.AutoSize = true;
			this.lblSearchAccount.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblSearchAccount.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lblSearchAccount.Location = new System.Drawing.Point(0, 0);
			this.lblSearchAccount.Name = "lblSearchAccount";
			this.lblSearchAccount.Size = new System.Drawing.Size(126, 21);
			this.lblSearchAccount.TabIndex = 4;
			this.lblSearchAccount.Text = "Search Account";
			// 
			// tbxSearchAccount
			// 
			this.tbxSearchAccount.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbxSearchAccount.Location = new System.Drawing.Point(0, 0);
			this.tbxSearchAccount.Name = "tbxSearchAccount";
			this.tbxSearchAccount.Size = new System.Drawing.Size(348, 21);
			this.tbxSearchAccount.TabIndex = 3;
			this.tbxSearchAccount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxSearchFilter_KeyUp);
			// 
			// lsvAccountInfoList
			// 
			this.lsvAccountInfoList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(220)))));
			this.lsvAccountInfoList.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lsvAccountInfoList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colAccount,
            this.colPassword,
            this.colActivate,
            this.colAdmin});
			this.lsvAccountInfoList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lsvAccountInfoList.FullRowSelect = true;
			this.lsvAccountInfoList.GridLines = true;
			this.lsvAccountInfoList.Location = new System.Drawing.Point(0, 0);
			this.lsvAccountInfoList.Name = "lsvAccountInfoList";
			this.lsvAccountInfoList.Size = new System.Drawing.Size(500, 132);
			this.lsvAccountInfoList.TabIndex = 1;
			this.lsvAccountInfoList.UseCompatibleStateImageBehavior = false;
			this.lsvAccountInfoList.View = System.Windows.Forms.View.Details;
			// 
			// colAccount
			// 
			this.colAccount.Text = "Account";
			this.colAccount.Width = 150;
			// 
			// colPassword
			// 
			this.colPassword.Text = "Password";
			this.colPassword.Width = 150;
			// 
			// colActivate
			// 
			this.colActivate.Text = "Activate";
			this.colActivate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.colActivate.Width = 100;
			// 
			// colAdmin
			// 
			this.colAdmin.Text = "Admin";
			this.colAdmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.colAdmin.Width = 100;
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(191, 120);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(69, 24);
			this.btnDelete.TabIndex = 5;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// lblAccount
			// 
			this.lblAccount.AutoSize = true;
			this.lblAccount.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lblAccount.Location = new System.Drawing.Point(17, 17);
			this.lblAccount.Name = "lblAccount";
			this.lblAccount.Size = new System.Drawing.Size(71, 21);
			this.lblAccount.TabIndex = 0;
			this.lblAccount.Text = "Account";
			// 
			// tbxAccount
			// 
			this.tbxAccount.Location = new System.Drawing.Point(110, 17);
			this.tbxAccount.Name = "tbxAccount";
			this.tbxAccount.ReadOnly = true;
			this.tbxAccount.Size = new System.Drawing.Size(150, 21);
			this.tbxAccount.TabIndex = 1;
			// 
			// chkActivate
			// 
			this.chkActivate.AutoSize = true;
			this.chkActivate.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.chkActivate.Location = new System.Drawing.Point(21, 44);
			this.chkActivate.Name = "chkActivate";
			this.chkActivate.Size = new System.Drawing.Size(89, 25);
			this.chkActivate.TabIndex = 2;
			this.chkActivate.Text = "Activate";
			this.chkActivate.UseVisualStyleBackColor = true;
			// 
			// chkAdmin
			// 
			this.chkAdmin.AutoSize = true;
			this.chkAdmin.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.chkAdmin.Location = new System.Drawing.Point(21, 75);
			this.chkAdmin.Name = "chkAdmin";
			this.chkAdmin.Size = new System.Drawing.Size(77, 25);
			this.chkAdmin.TabIndex = 3;
			this.chkAdmin.Text = "Admin";
			this.chkAdmin.UseVisualStyleBackColor = true;
			// 
			// btnApply
			// 
			this.btnApply.Location = new System.Drawing.Point(110, 120);
			this.btnApply.Name = "btnApply";
			this.btnApply.Size = new System.Drawing.Size(69, 24);
			this.btnApply.TabIndex = 4;
			this.btnApply.Text = "Apply";
			this.btnApply.UseVisualStyleBackColor = true;
			this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
			// 
			// FormAdmin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 161);
			this.Controls.Add(this.spcAccountInfoList_Control);
			this.MinimumSize = new System.Drawing.Size(800, 200);
			this.Name = "FormAdmin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Admin";
			this.Load += new System.EventHandler(this.FormAdmin_Load);
			this.spcAccountInfoList_Control.Panel1.ResumeLayout(false);
			this.spcAccountInfoList_Control.Panel2.ResumeLayout(false);
			this.spcAccountInfoList_Control.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.spcAccountInfoList_Control)).EndInit();
			this.spcAccountInfoList_Control.ResumeLayout(false);
			this.splitSearchAccount_AccountList.Panel1.ResumeLayout(false);
			this.splitSearchAccount_AccountList.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitSearchAccount_AccountList)).EndInit();
			this.splitSearchAccount_AccountList.ResumeLayout(false);
			this.spcSearchAccount_Label_TextBox.Panel1.ResumeLayout(false);
			this.spcSearchAccount_Label_TextBox.Panel1.PerformLayout();
			this.spcSearchAccount_Label_TextBox.Panel2.ResumeLayout(false);
			this.spcSearchAccount_Label_TextBox.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.spcSearchAccount_Label_TextBox)).EndInit();
			this.spcSearchAccount_Label_TextBox.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer spcAccountInfoList_Control;
		private System.Windows.Forms.Label          lblAccount;
		private System.Windows.Forms.TextBox        tbxAccount;
		private System.Windows.Forms.CheckBox       chkActivate;
		private System.Windows.Forms.CheckBox       chkAdmin;
		private System.Windows.Forms.Button         btnApply;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.SplitContainer splitSearchAccount_AccountList;
		private System.Windows.Forms.ListView lsvAccountInfoList;
		private System.Windows.Forms.ColumnHeader colAccount;
		private System.Windows.Forms.ColumnHeader colPassword;
		private System.Windows.Forms.ColumnHeader colActivate;
		private System.Windows.Forms.ColumnHeader colAdmin;
		private System.Windows.Forms.SplitContainer spcSearchAccount_Label_TextBox;
		private System.Windows.Forms.Label lblSearchAccount;
		private System.Windows.Forms.TextBox tbxSearchAccount;
	}
}