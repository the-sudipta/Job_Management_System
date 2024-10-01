namespace Job_Management_System
{
	partial class LoginForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			this.label2 = new System.Windows.Forms.Label();
			this.top_panel = new System.Windows.Forms.Panel();
			this.close_button = new System.Windows.Forms.Button();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.signup_linkLabel = new System.Windows.Forms.LinkLabel();
			this.login_button = new System.Windows.Forms.Button();
			this.password_label = new System.Windows.Forms.Label();
			this.username_label = new System.Windows.Forms.Label();
			this.password_textBox = new System.Windows.Forms.TextBox();
			this.username_textBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.top_panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(12, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(99, 15);
			this.label2.TabIndex = 4;
			this.label2.Text = "Job Management";
			// 
			// top_panel
			// 
			this.top_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(80)))));
			this.top_panel.Controls.Add(this.label2);
			this.top_panel.Controls.Add(this.close_button);
			this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
			this.top_panel.Location = new System.Drawing.Point(0, 0);
			this.top_panel.Name = "top_panel";
			this.top_panel.Size = new System.Drawing.Size(1006, 35);
			this.top_panel.TabIndex = 1;
			this.top_panel.DoubleClick += new System.EventHandler(this.top_panel_DoubleClick);
			this.top_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.top_panel_MouseDown);
			// 
			// close_button
			// 
			this.close_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.close_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(80)))));
			this.close_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close_button.BackgroundImage")));
			this.close_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.close_button.Cursor = System.Windows.Forms.Cursors.Hand;
			this.close_button.FlatAppearance.BorderSize = 0;
			this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.close_button.Location = new System.Drawing.Point(974, 0);
			this.close_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.close_button.Name = "close_button";
			this.close_button.Size = new System.Drawing.Size(32, 32);
			this.close_button.TabIndex = 0;
			this.close_button.UseVisualStyleBackColor = false;
			this.close_button.Click += new System.EventHandler(this.close_button_Click);
			// 
			// pictureBox3
			// 
			this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(0, 0);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(1006, 595);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 6;
			this.pictureBox3.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.signup_linkLabel);
			this.panel1.Controls.Add(this.login_button);
			this.panel1.Controls.Add(this.password_label);
			this.panel1.Controls.Add(this.username_label);
			this.panel1.Controls.Add(this.password_textBox);
			this.panel1.Controls.Add(this.username_textBox);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(15, 124);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(369, 367);
			this.panel1.TabIndex = 5;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(45, 162);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(32, 31);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 6;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(45, 104);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(32, 31);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// signup_linkLabel
			// 
			this.signup_linkLabel.AutoSize = true;
			this.signup_linkLabel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.signup_linkLabel.ForeColor = System.Drawing.Color.White;
			this.signup_linkLabel.LinkColor = System.Drawing.Color.WhiteSmoke;
			this.signup_linkLabel.Location = new System.Drawing.Point(142, 276);
			this.signup_linkLabel.Name = "signup_linkLabel";
			this.signup_linkLabel.Size = new System.Drawing.Size(116, 15);
			this.signup_linkLabel.TabIndex = 5;
			this.signup_linkLabel.TabStop = true;
			this.signup_linkLabel.Text = "Create New Account";
			this.signup_linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signup_linkLabel_LinkClicked);
			// 
			// login_button
			// 
			this.login_button.Cursor = System.Windows.Forms.Cursors.Hand;
			this.login_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.login_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.login_button.ForeColor = System.Drawing.Color.White;
			this.login_button.Location = new System.Drawing.Point(127, 227);
			this.login_button.Name = "login_button";
			this.login_button.Size = new System.Drawing.Size(147, 33);
			this.login_button.TabIndex = 2;
			this.login_button.Text = "Login";
			this.login_button.UseVisualStyleBackColor = true;
			this.login_button.Click += new System.EventHandler(this.login_button_Click);
			// 
			// password_label
			// 
			this.password_label.AutoSize = true;
			this.password_label.ForeColor = System.Drawing.Color.White;
			this.password_label.Location = new System.Drawing.Point(77, 149);
			this.password_label.Name = "password_label";
			this.password_label.Size = new System.Drawing.Size(57, 15);
			this.password_label.TabIndex = 4;
			this.password_label.Text = "Password";
			// 
			// username_label
			// 
			this.username_label.AutoSize = true;
			this.username_label.ForeColor = System.Drawing.Color.White;
			this.username_label.Location = new System.Drawing.Point(77, 90);
			this.username_label.Name = "username_label";
			this.username_label.Size = new System.Drawing.Size(60, 15);
			this.username_label.TabIndex = 4;
			this.username_label.Text = "Username";
			// 
			// password_textBox
			// 
			this.password_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.password_textBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.password_textBox.Location = new System.Drawing.Point(78, 167);
			this.password_textBox.Name = "password_textBox";
			this.password_textBox.Size = new System.Drawing.Size(245, 27);
			this.password_textBox.TabIndex = 3;
			this.password_textBox.UseSystemPasswordChar = true;
			this.password_textBox.TextChanged += new System.EventHandler(this.username_textBox_TextChanged);
			this.password_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_textBox_KeyDown);
			// 
			// username_textBox
			// 
			this.username_textBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.username_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.username_textBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.username_textBox.Location = new System.Drawing.Point(78, 108);
			this.username_textBox.Name = "username_textBox";
			this.username_textBox.Size = new System.Drawing.Size(245, 27);
			this.username_textBox.TabIndex = 3;
			this.username_textBox.TextChanged += new System.EventHandler(this.username_textBox_TextChanged);
			this.username_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.username_textBox_KeyDown);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(158, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 37);
			this.label1.TabIndex = 4;
			this.label1.Text = "Login";
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(98)))));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(1006, 595);
			this.ControlBox = false;
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.top_panel);
			this.Controls.Add(this.pictureBox3);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "LoginForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.LoginForm_Load);
			this.top_panel.ResumeLayout(false);
			this.top_panel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel top_panel;
		private System.Windows.Forms.Button close_button;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.LinkLabel signup_linkLabel;
		private System.Windows.Forms.Button login_button;
		private System.Windows.Forms.Label password_label;
		private System.Windows.Forms.Label username_label;
		private System.Windows.Forms.TextBox password_textBox;
		private System.Windows.Forms.TextBox username_textBox;
		private System.Windows.Forms.Label label1;
	}
}