namespace LoginProgram
{
	partial class FormMain
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblAccount = new System.Windows.Forms.Label();
			this.tbxAccount = new System.Windows.Forms.TextBox();
			this.lblPassword = new System.Windows.Forms.Label();
			this.tbxPassword = new System.Windows.Forms.TextBox();
			this.lblConfirmPassword = new System.Windows.Forms.Label();
			this.tbxConfirmPassword = new System.Windows.Forms.TextBox();
			this.chkActivate = new System.Windows.Forms.CheckBox();
			this.chkAdmin = new System.Windows.Forms.CheckBox();
			this.btnAdmin = new System.Windows.Forms.Button();
			this.btnApply = new System.Windows.Forms.Button();
			this.btnLogout = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblAccount
			// 
			this.lblAccount.AutoSize = true;
			this.lblAccount.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lblAccount.Location = new System.Drawing.Point(13, 12);
			this.lblAccount.Name = "lblAccount";
			this.lblAccount.Size = new System.Drawing.Size(71, 21);
			this.lblAccount.TabIndex = 0;
			this.lblAccount.Text = "Account";
			// 
			// tbxAccount
			// 
			this.tbxAccount.Location = new System.Drawing.Point(162, 12);
			this.tbxAccount.Name = "tbxAccount";
			this.tbxAccount.ReadOnly = true;
			this.tbxAccount.Size = new System.Drawing.Size(150, 21);
			this.tbxAccount.TabIndex = 1;
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lblPassword.Location = new System.Drawing.Point(13, 39);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(79, 21);
			this.lblPassword.TabIndex = 2;
			this.lblPassword.Text = "Password";
			// 
			// tbxPassword
			// 
			this.tbxPassword.Location = new System.Drawing.Point(162, 39);
			this.tbxPassword.Name = "tbxPassword";
			this.tbxPassword.Size = new System.Drawing.Size(150, 21);
			this.tbxPassword.TabIndex = 3;
			this.tbxPassword.UseSystemPasswordChar = true;
			// 
			// lblConfirmPassword
			// 
			this.lblConfirmPassword.AutoSize = true;
			this.lblConfirmPassword.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lblConfirmPassword.Location = new System.Drawing.Point(13, 66);
			this.lblConfirmPassword.Name = "lblConfirmPassword";
			this.lblConfirmPassword.Size = new System.Drawing.Size(143, 21);
			this.lblConfirmPassword.TabIndex = 4;
			this.lblConfirmPassword.Text = "Confirm Password";
			// 
			// tbxConfirmPassword
			// 
			this.tbxConfirmPassword.Location = new System.Drawing.Point(162, 66);
			this.tbxConfirmPassword.Name = "tbxConfirmPassword";
			this.tbxConfirmPassword.Size = new System.Drawing.Size(150, 21);
			this.tbxConfirmPassword.TabIndex = 5;
			this.tbxConfirmPassword.UseSystemPasswordChar = true;
			// 
			// chkActivate
			// 
			this.chkActivate.AutoSize = true;
			this.chkActivate.Enabled = false;
			this.chkActivate.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.chkActivate.Location = new System.Drawing.Point(17, 96);
			this.chkActivate.Name = "chkActivate";
			this.chkActivate.Size = new System.Drawing.Size(89, 25);
			this.chkActivate.TabIndex = 6;
			this.chkActivate.Text = "Activate";
			this.chkActivate.UseVisualStyleBackColor = true;
			// 
			// chkAdmin
			// 
			this.chkAdmin.AutoSize = true;
			this.chkAdmin.Enabled = false;
			this.chkAdmin.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.chkAdmin.Location = new System.Drawing.Point(17, 127);
			this.chkAdmin.Name = "chkAdmin";
			this.chkAdmin.Size = new System.Drawing.Size(77, 25);
			this.chkAdmin.TabIndex = 7;
			this.chkAdmin.Text = "Admin";
			this.chkAdmin.UseVisualStyleBackColor = true;
			// 
			// btnAdmin
			// 
			this.btnAdmin.Location = new System.Drawing.Point(81, 164);
			this.btnAdmin.Name = "btnAdmin";
			this.btnAdmin.Size = new System.Drawing.Size(69, 24);
			this.btnAdmin.TabIndex = 8;
			this.btnAdmin.Text = "Admin";
			this.btnAdmin.UseVisualStyleBackColor = true;
			this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
			// 
			// btnApply
			// 
			this.btnApply.Location = new System.Drawing.Point(162, 164);
			this.btnApply.Name = "btnApply";
			this.btnApply.Size = new System.Drawing.Size(69, 24);
			this.btnApply.TabIndex = 9;
			this.btnApply.Text = "Apply";
			this.btnApply.UseVisualStyleBackColor = true;
			this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
			// 
			// btnLogout
			// 
			this.btnLogout.Location = new System.Drawing.Point(244, 164);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(69, 24);
			this.btnLogout.TabIndex = 10;
			this.btnLogout.Text = "Logout";
			this.btnLogout.UseVisualStyleBackColor = true;
			this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(325, 205);
			this.Controls.Add(this.lblAccount);
			this.Controls.Add(this.tbxAccount);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.tbxPassword);
			this.Controls.Add(this.lblConfirmPassword);
			this.Controls.Add(this.tbxConfirmPassword);
			this.Controls.Add(this.chkActivate);
			this.Controls.Add(this.chkAdmin);
			this.Controls.Add(this.btnAdmin);
			this.Controls.Add(this.btnApply);
			this.Controls.Add(this.btnLogout);
			this.Name = "FormMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Main";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label    lblAccount;
		private System.Windows.Forms.TextBox  tbxAccount;
		private System.Windows.Forms.Label    lblPassword;
		private System.Windows.Forms.TextBox  tbxPassword;
		private System.Windows.Forms.Label    lblConfirmPassword;
		private System.Windows.Forms.TextBox  tbxConfirmPassword;
		private System.Windows.Forms.CheckBox chkActivate;
		private System.Windows.Forms.CheckBox chkAdmin;
		private System.Windows.Forms.Button   btnAdmin;
		private System.Windows.Forms.Button   btnApply;
		private System.Windows.Forms.Button   btnLogout;
	}
}

