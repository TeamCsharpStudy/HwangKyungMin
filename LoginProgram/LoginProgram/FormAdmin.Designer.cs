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
			this.lsvAccountInfoList = new System.Windows.Forms.ListView();
			this.colAccount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colPassword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colActivate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colAdmin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lblAccount = new System.Windows.Forms.Label();
			this.tbxAccount = new System.Windows.Forms.TextBox();
			this.chkActivate = new System.Windows.Forms.CheckBox();
			this.chkAdmin = new System.Windows.Forms.CheckBox();
			this.btnApply = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.spcAccountInfoList_Control)).BeginInit();
			this.spcAccountInfoList_Control.Panel1.SuspendLayout();
			this.spcAccountInfoList_Control.Panel2.SuspendLayout();
			this.spcAccountInfoList_Control.SuspendLayout();
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
			this.spcAccountInfoList_Control.Panel1.Controls.Add(this.lsvAccountInfoList);
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
			this.spcAccountInfoList_Control.Size = new System.Drawing.Size(784, 561);
			this.spcAccountInfoList_Control.SplitterDistance = 500;
			this.spcAccountInfoList_Control.TabIndex = 1;
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
			this.lsvAccountInfoList.Size = new System.Drawing.Size(500, 561);
			this.lsvAccountInfoList.TabIndex = 0;
			this.lsvAccountInfoList.UseCompatibleStateImageBehavior = false;
			this.lsvAccountInfoList.View = System.Windows.Forms.View.Details;
			this.lsvAccountInfoList.SelectedIndexChanged += new System.EventHandler(this.lsvAccountInfoList_SelectedIndexChanged);
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
			// FormAdmin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.spcAccountInfoList_Control);
			this.Name = "FormAdmin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Admin";
			this.Load += new System.EventHandler(this.FormAdmin_Load);
			this.spcAccountInfoList_Control.Panel1.ResumeLayout(false);
			this.spcAccountInfoList_Control.Panel2.ResumeLayout(false);
			this.spcAccountInfoList_Control.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.spcAccountInfoList_Control)).EndInit();
			this.spcAccountInfoList_Control.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer spcAccountInfoList_Control;
		private System.Windows.Forms.ListView       lsvAccountInfoList;
		private System.Windows.Forms.ColumnHeader   colAccount;
		private System.Windows.Forms.ColumnHeader   colPassword;
		private System.Windows.Forms.ColumnHeader   colActivate;
		private System.Windows.Forms.ColumnHeader   colAdmin;
		private System.Windows.Forms.Label          lblAccount;
		private System.Windows.Forms.TextBox        tbxAccount;
		private System.Windows.Forms.CheckBox       chkActivate;
		private System.Windows.Forms.CheckBox       chkAdmin;
		private System.Windows.Forms.Button         btnApply;
		private System.Windows.Forms.Button btnDelete;
	}
}