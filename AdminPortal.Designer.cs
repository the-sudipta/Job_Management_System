namespace Job_Management_System
{
	partial class AdminPortal
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPortal));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.navigation_panel = new System.Windows.Forms.Panel();
			this.username_label = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.user_CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
			this.main_panel = new System.Windows.Forms.Panel();
			this.bottom_container_panel = new System.Windows.Forms.Panel();
			this.botttom_right_container_panel = new System.Windows.Forms.Panel();
			this.add_button = new System.Windows.Forms.Button();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel8 = new System.Windows.Forms.Panel();
			this.email_textBox = new System.Windows.Forms.TextBox();
			this.phone_textBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.bottom_left_container_panel = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.address_textBox = new System.Windows.Forms.TextBox();
			this.name_textBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.applicant_label = new System.Windows.Forms.Label();
			this.job_applicants_dataGridView = new System.Windows.Forms.DataGridView();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EditColumnButton = new System.Windows.Forms.DataGridViewButtonColumn();
			this.DeleteColumnButton = new System.Windows.Forms.DataGridViewButtonColumn();
			this.top_panel = new System.Windows.Forms.Panel();
			this.logout_button = new System.Windows.Forms.Button();
			this.close_button = new System.Windows.Forms.Button();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.navigation_panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.user_CirclePictureBox1)).BeginInit();
			this.main_panel.SuspendLayout();
			this.bottom_container_panel.SuspendLayout();
			this.botttom_right_container_panel.SuspendLayout();
			this.bottom_left_container_panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.job_applicants_dataGridView)).BeginInit();
			this.top_panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// navigation_panel
			// 
			this.navigation_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
			this.navigation_panel.Controls.Add(this.username_label);
			this.navigation_panel.Controls.Add(this.label1);
			this.navigation_panel.Controls.Add(this.user_CirclePictureBox1);
			this.navigation_panel.Dock = System.Windows.Forms.DockStyle.Left;
			this.navigation_panel.ForeColor = System.Drawing.SystemColors.ControlText;
			this.navigation_panel.Location = new System.Drawing.Point(0, 0);
			this.navigation_panel.Name = "navigation_panel";
			this.navigation_panel.Size = new System.Drawing.Size(266, 595);
			this.navigation_panel.TabIndex = 0;
			// 
			// username_label
			// 
			this.username_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.username_label.ForeColor = System.Drawing.Color.White;
			this.username_label.Location = new System.Drawing.Point(4, 453);
			this.username_label.Name = "username_label";
			this.username_label.Size = new System.Drawing.Size(257, 29);
			this.username_label.TabIndex = 1;
			this.username_label.Text = "username";
			this.username_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.toolTip.SetToolTip(this.username_label, "Username");
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(79, 417);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(107, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Welcome!";
			// 
			// user_CirclePictureBox1
			// 
			this.user_CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("user_CirclePictureBox1.Image")));
			this.user_CirclePictureBox1.ImageRotate = 0F;
			this.user_CirclePictureBox1.Location = new System.Drawing.Point(20, 170);
			this.user_CirclePictureBox1.Name = "user_CirclePictureBox1";
			this.user_CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.user_CirclePictureBox1.Size = new System.Drawing.Size(224, 224);
			this.user_CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.user_CirclePictureBox1.TabIndex = 0;
			this.user_CirclePictureBox1.TabStop = false;
			// 
			// main_panel
			// 
			this.main_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
			this.main_panel.Controls.Add(this.bottom_container_panel);
			this.main_panel.Controls.Add(this.applicant_label);
			this.main_panel.Controls.Add(this.job_applicants_dataGridView);
			this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.main_panel.Location = new System.Drawing.Point(266, 0);
			this.main_panel.Name = "main_panel";
			this.main_panel.Size = new System.Drawing.Size(740, 595);
			this.main_panel.TabIndex = 1;
			// 
			// bottom_container_panel
			// 
			this.bottom_container_panel.Controls.Add(this.botttom_right_container_panel);
			this.bottom_container_panel.Controls.Add(this.bottom_left_container_panel);
			this.bottom_container_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.bottom_container_panel.Location = new System.Drawing.Point(0, 451);
			this.bottom_container_panel.Name = "bottom_container_panel";
			this.bottom_container_panel.Size = new System.Drawing.Size(740, 144);
			this.bottom_container_panel.TabIndex = 2;
			// 
			// botttom_right_container_panel
			// 
			this.botttom_right_container_panel.Controls.Add(this.add_button);
			this.botttom_right_container_panel.Controls.Add(this.panel5);
			this.botttom_right_container_panel.Controls.Add(this.panel8);
			this.botttom_right_container_panel.Controls.Add(this.email_textBox);
			this.botttom_right_container_panel.Controls.Add(this.phone_textBox);
			this.botttom_right_container_panel.Controls.Add(this.label5);
			this.botttom_right_container_panel.Controls.Add(this.label4);
			this.botttom_right_container_panel.Dock = System.Windows.Forms.DockStyle.Right;
			this.botttom_right_container_panel.Location = new System.Drawing.Point(333, 0);
			this.botttom_right_container_panel.Name = "botttom_right_container_panel";
			this.botttom_right_container_panel.Size = new System.Drawing.Size(407, 144);
			this.botttom_right_container_panel.TabIndex = 23;
			// 
			// add_button
			// 
			this.add_button.BackColor = System.Drawing.Color.Green;
			this.add_button.Cursor = System.Windows.Forms.Cursors.Hand;
			this.add_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.add_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.add_button.ForeColor = System.Drawing.Color.White;
			this.add_button.Location = new System.Drawing.Point(311, 95);
			this.add_button.Name = "add_button";
			this.add_button.Size = new System.Drawing.Size(75, 37);
			this.add_button.TabIndex = 28;
			this.add_button.Text = "ADD";
			this.toolTip.SetToolTip(this.add_button, "Add New Appliicant");
			this.add_button.UseVisualStyleBackColor = false;
			this.add_button.Click += new System.EventHandler(this.add_button_Click);
			// 
			// panel5
			// 
			this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel5.BackColor = System.Drawing.Color.Black;
			this.panel5.Location = new System.Drawing.Point(66, 95);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(230, 2);
			this.panel5.TabIndex = 26;
			// 
			// panel8
			// 
			this.panel8.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel8.BackColor = System.Drawing.Color.Black;
			this.panel8.Location = new System.Drawing.Point(66, 39);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(230, 2);
			this.panel8.TabIndex = 27;
			// 
			// email_textBox
			// 
			this.email_textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.email_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
			this.email_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.email_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.email_textBox.Location = new System.Drawing.Point(66, 74);
			this.email_textBox.Name = "email_textBox";
			this.email_textBox.Size = new System.Drawing.Size(230, 19);
			this.email_textBox.TabIndex = 24;
			this.email_textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
			this.email_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.email_textBox_KeyDown);
			// 
			// phone_textBox
			// 
			this.phone_textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.phone_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
			this.phone_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.phone_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.phone_textBox.Location = new System.Drawing.Point(66, 18);
			this.phone_textBox.Name = "phone_textBox";
			this.phone_textBox.Size = new System.Drawing.Size(230, 19);
			this.phone_textBox.TabIndex = 25;
			this.phone_textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
			this.phone_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.phone_textBox_KeyDown);
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(12, 81);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 20);
			this.label5.TabIndex = 22;
			this.label5.Text = "Email";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(5, 20);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(55, 20);
			this.label4.TabIndex = 23;
			this.label4.Text = "Phone";
			// 
			// bottom_left_container_panel
			// 
			this.bottom_left_container_panel.Controls.Add(this.panel6);
			this.bottom_left_container_panel.Controls.Add(this.panel7);
			this.bottom_left_container_panel.Controls.Add(this.address_textBox);
			this.bottom_left_container_panel.Controls.Add(this.name_textBox);
			this.bottom_left_container_panel.Controls.Add(this.label3);
			this.bottom_left_container_panel.Controls.Add(this.label2);
			this.bottom_left_container_panel.Dock = System.Windows.Forms.DockStyle.Left;
			this.bottom_left_container_panel.Location = new System.Drawing.Point(0, 0);
			this.bottom_left_container_panel.Name = "bottom_left_container_panel";
			this.bottom_left_container_panel.Size = new System.Drawing.Size(336, 144);
			this.bottom_left_container_panel.TabIndex = 22;
			// 
			// panel6
			// 
			this.panel6.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.panel6.BackColor = System.Drawing.Color.Black;
			this.panel6.Location = new System.Drawing.Point(95, 96);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(230, 2);
			this.panel6.TabIndex = 25;
			// 
			// panel7
			// 
			this.panel7.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.panel7.BackColor = System.Drawing.Color.Black;
			this.panel7.Location = new System.Drawing.Point(95, 40);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(230, 2);
			this.panel7.TabIndex = 26;
			// 
			// address_textBox
			// 
			this.address_textBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.address_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
			this.address_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.address_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.address_textBox.Location = new System.Drawing.Point(95, 75);
			this.address_textBox.Name = "address_textBox";
			this.address_textBox.Size = new System.Drawing.Size(230, 19);
			this.address_textBox.TabIndex = 23;
			this.address_textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
			this.address_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.address_textBox_KeyDown);
			// 
			// name_textBox
			// 
			this.name_textBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.name_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
			this.name_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.name_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.name_textBox.Location = new System.Drawing.Point(95, 19);
			this.name_textBox.Name = "name_textBox";
			this.name_textBox.Size = new System.Drawing.Size(230, 19);
			this.name_textBox.TabIndex = 24;
			this.name_textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
			this.name_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.name_textBox_KeyDown);
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(15, 81);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 20);
			this.label3.TabIndex = 21;
			this.label3.Text = "Address";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(32, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 20);
			this.label2.TabIndex = 22;
			this.label2.Text = "Name";
			// 
			// applicant_label
			// 
			this.applicant_label.AutoSize = true;
			this.applicant_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.applicant_label.Location = new System.Drawing.Point(7, 50);
			this.applicant_label.Name = "applicant_label";
			this.applicant_label.Size = new System.Drawing.Size(165, 24);
			this.applicant_label.TabIndex = 1;
			this.applicant_label.Text = "Applicant Details";
			// 
			// job_applicants_dataGridView
			// 
			this.job_applicants_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.job_applicants_dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.job_applicants_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.job_applicants_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.job_applicants_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.address,
            this.phone,
            this.email,
            this.EditColumnButton,
            this.DeleteColumnButton});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.job_applicants_dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
			this.job_applicants_dataGridView.Location = new System.Drawing.Point(6, 91);
			this.job_applicants_dataGridView.Name = "job_applicants_dataGridView";
			this.job_applicants_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.job_applicants_dataGridView.Size = new System.Drawing.Size(730, 351);
			this.job_applicants_dataGridView.TabIndex = 0;
			this.toolTip.SetToolTip(this.job_applicants_dataGridView, "Applicants");
			this.job_applicants_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.job_applicants_dataGridView_CellClick);
			// 
			// id
			// 
			this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.id.DataPropertyName = "id";
			this.id.HeaderText = "ID";
			this.id.Name = "id";
			// 
			// name
			// 
			this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.name.DataPropertyName = "name";
			this.name.HeaderText = "Name";
			this.name.Name = "name";
			// 
			// address
			// 
			this.address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.address.DataPropertyName = "address";
			this.address.HeaderText = "Address";
			this.address.Name = "address";
			// 
			// phone
			// 
			this.phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.phone.DataPropertyName = "phone";
			this.phone.HeaderText = "Phone";
			this.phone.Name = "phone";
			// 
			// email
			// 
			this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.email.DataPropertyName = "email";
			this.email.HeaderText = "Email";
			this.email.Name = "email";
			// 
			// EditColumnButton
			// 
			this.EditColumnButton.HeaderText = "Edit";
			this.EditColumnButton.Name = "EditColumnButton";
			this.EditColumnButton.Text = "Edit";
			this.EditColumnButton.UseColumnTextForButtonValue = true;
			// 
			// DeleteColumnButton
			// 
			this.DeleteColumnButton.HeaderText = "Delete";
			this.DeleteColumnButton.Name = "DeleteColumnButton";
			this.DeleteColumnButton.Text = "Delete";
			this.DeleteColumnButton.UseColumnTextForButtonValue = true;
			// 
			// top_panel
			// 
			this.top_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
			this.top_panel.Controls.Add(this.logout_button);
			this.top_panel.Controls.Add(this.close_button);
			this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
			this.top_panel.Location = new System.Drawing.Point(266, 0);
			this.top_panel.Name = "top_panel";
			this.top_panel.Size = new System.Drawing.Size(740, 34);
			this.top_panel.TabIndex = 2;
			this.top_panel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.top_panel_MouseDoubleClick);
			this.top_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.top_panel_MouseDown);
			// 
			// logout_button
			// 
			this.logout_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.logout_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
			this.logout_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logout_button.BackgroundImage")));
			this.logout_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.logout_button.Cursor = System.Windows.Forms.Cursors.Hand;
			this.logout_button.FlatAppearance.BorderSize = 0;
			this.logout_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.logout_button.Location = new System.Drawing.Point(664, 2);
			this.logout_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.logout_button.Name = "logout_button";
			this.logout_button.Size = new System.Drawing.Size(32, 32);
			this.logout_button.TabIndex = 2;
			this.toolTip.SetToolTip(this.logout_button, "Logout");
			this.logout_button.UseVisualStyleBackColor = false;
			this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
			// 
			// close_button
			// 
			this.close_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.close_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
			this.close_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close_button.BackgroundImage")));
			this.close_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.close_button.Cursor = System.Windows.Forms.Cursors.Hand;
			this.close_button.FlatAppearance.BorderSize = 0;
			this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.close_button.Location = new System.Drawing.Point(704, 1);
			this.close_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.close_button.Name = "close_button";
			this.close_button.Size = new System.Drawing.Size(32, 32);
			this.close_button.TabIndex = 2;
			this.toolTip.SetToolTip(this.close_button, "Close");
			this.close_button.UseVisualStyleBackColor = false;
			this.close_button.Click += new System.EventHandler(this.close_button_Click);
			// 
			// AdminPortal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(1006, 595);
			this.Controls.Add(this.top_panel);
			this.Controls.Add(this.main_panel);
			this.Controls.Add(this.navigation_panel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AdminPortal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AdminPortal";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.AdminPortal_Load);
			this.navigation_panel.ResumeLayout(false);
			this.navigation_panel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.user_CirclePictureBox1)).EndInit();
			this.main_panel.ResumeLayout(false);
			this.main_panel.PerformLayout();
			this.bottom_container_panel.ResumeLayout(false);
			this.botttom_right_container_panel.ResumeLayout(false);
			this.botttom_right_container_panel.PerformLayout();
			this.bottom_left_container_panel.ResumeLayout(false);
			this.bottom_left_container_panel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.job_applicants_dataGridView)).EndInit();
			this.top_panel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel navigation_panel;
		private System.Windows.Forms.Panel main_panel;
		private Guna.UI2.WinForms.Guna2CirclePictureBox user_CirclePictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label username_label;
		private System.Windows.Forms.Panel top_panel;
		private System.Windows.Forms.Button close_button;
		private System.Windows.Forms.Button logout_button;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.DataGridView job_applicants_dataGridView;
		private System.Windows.Forms.Label applicant_label;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewTextBoxColumn name;
		private System.Windows.Forms.DataGridViewTextBoxColumn address;
		private System.Windows.Forms.DataGridViewTextBoxColumn phone;
		private System.Windows.Forms.DataGridViewTextBoxColumn email;
		private System.Windows.Forms.DataGridViewButtonColumn EditColumnButton;
		private System.Windows.Forms.DataGridViewButtonColumn DeleteColumnButton;
		private System.Windows.Forms.Panel bottom_container_panel;
		private System.Windows.Forms.Panel botttom_right_container_panel;
		private System.Windows.Forms.Button add_button;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.TextBox email_textBox;
		private System.Windows.Forms.TextBox phone_textBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel bottom_left_container_panel;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.TextBox address_textBox;
		private System.Windows.Forms.TextBox name_textBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
	}
}