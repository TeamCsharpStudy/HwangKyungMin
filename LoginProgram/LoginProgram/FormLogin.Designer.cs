namespace LoginProgram
{
	partial class FormLogin
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
			this.lblAccount = new System.Windows.Forms.Label();
			this.tbxAccount = new System.Windows.Forms.TextBox();
			this.lblPassword = new System.Windows.Forms.Label();
			this.tbxPassword = new System.Windows.Forms.TextBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.btnJoin = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblAccount
			// 
			this.lblAccount.AutoSize = true;
			this.lblAccount.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lblAccount.Location = new System.Drawing.Point(12, 12);
			this.lblAccount.Name = "lblAccount";
			this.lblAccount.Size = new System.Drawing.Size(71, 21);
			this.lblAccount.TabIndex = 0;
			this.lblAccount.Text = "Account";
			// 
			// tbxAccount
			// 
			this.tbxAccount.Location = new System.Drawing.Point(97, 12);
			this.tbxAccount.Name = "tbxAccount";
			this.tbxAccount.Size = new System.Drawing.Size(150, 21);
			this.tbxAccount.TabIndex = 1;
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lblPassword.Location = new System.Drawing.Point(12, 39);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(79, 21);
			this.lblPassword.TabIndex = 2;
			this.lblPassword.Text = "Password";
			// 
			// tbxPassword
			// 
			this.tbxPassword.Location = new System.Drawing.Point(97, 39);
			this.tbxPassword.Name = "tbxPassword";
			this.tbxPassword.Size = new System.Drawing.Size(150, 21);
			this.tbxPassword.TabIndex = 3;
			this.tbxPassword.UseSystemPasswordChar = true;
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(253, 12);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(75, 48);
			this.btnLogin.TabIndex = 4;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// btnJoin
			// 
			this.btnJoin.Location = new System.Drawing.Point(334, 12);
			this.btnJoin.Name = "btnJoin";
			this.btnJoin.Size = new System.Drawing.Size(75, 48);
			this.btnJoin.TabIndex = 5;
			this.btnJoin.Text = "Join";
			this.btnJoin.UseVisualStyleBackColor = true;
			this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
			// 
			// FormLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(421, 72);
			this.Controls.Add(this.lblAccount);
			this.Controls.Add(this.tbxAccount);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.tbxPassword);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.btnJoin);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "FormLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label   lblAccount;
		private System.Windows.Forms.TextBox tbxAccount;
		private System.Windows.Forms.Label   lblPassword;
		private System.Windows.Forms.TextBox tbxPassword;
		private System.Windows.Forms.Button  btnLogin;
		private System.Windows.Forms.Button  btnJoin;
	}
}