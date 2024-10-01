using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job_Management_System
{
	public partial class LoginForm : Form
	{


		// Constants for Dragging the Form
		private const int WM_NCLBUTTONDOWN = 0xA1;
		private const int HT_CAPTION = 0x2;


		[System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		[System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern bool ReleaseCapture();





		public LoginForm()
		{
			InitializeComponent();
			//top_panel.DoubleClick += top_panel_DoubleClick; // Attach the event handler
			username_textBox.Focus();
			login_button.Enabled = false;
		}

		private void close_button_Click(object sender, EventArgs e)
		{
			Object_Handler.loginForm.Close();
		}

		

		private void signup_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Object_Handler.loginForm.Hide();
			SignupForm signupForm = new SignupForm();
			Object_Handler.signupForm = signupForm;
			Object_Handler.signupForm.Show();
		}

		private void login_button_Click(object sender, EventArgs e)
		{

			Database database = new Database();
			string password = database.getPasswordByUsername(username_textBox.Text);
			//MessageBox.Show(password);

			if (password == password_textBox.Text)
			{
				Object_Handler.username = username_textBox.Text;
				Object_Handler.loginForm.Hide();
				AdminPortal adminPortal = new AdminPortal();
				Object_Handler.adminPortal = adminPortal;
				Object_Handler.adminPortal.Show();
			}
			else
			{
				MessageBox.Show("Login failed!");
				password_textBox.Clear();
			}

			
		}





		private void top_panel_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				if (e.Clicks == 1 && e.Y <= this.Height && e.Y >= 0)
				{
					ReleaseCapture();
					SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
				}
			}
		}

		private void top_panel_DoubleClick(object sender, EventArgs e)
		{
			// Check if the form is already maximized, if so, restore it. Otherwise, maximize it.
			if (this.WindowState == FormWindowState.Maximized)
			{
				this.WindowState = FormWindowState.Normal; // Restore to normal size
			}
			else
			{
				this.WindowState = FormWindowState.Maximized; // Maximize the form
			}

		}

		private void username_textBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
			{
				password_textBox.Focus();
			}
		}

		private void password_textBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Up)
			{
				username_textBox.Focus();
			}else if(e.KeyCode == Keys.Enter && login_button.Enabled)
			{
				login_button_Click(this, EventArgs.Empty);
			}
		}

		private void username_textBox_TextChanged(object sender, EventArgs e)
		{
			if(username_textBox.Text.Length > 0 && password_textBox.Text.Length > 0 && username_textBox.Text != "" && password_label.Text != "")
			{
				login_button.Enabled = true;
			}
			else
			{
				login_button.Enabled = false;
			}
		}

		private void LoginForm_Load(object sender, EventArgs e)
		{
			username_textBox.Focus();
		}
	}
}
