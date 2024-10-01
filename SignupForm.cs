using Job_Management_System.Models;
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
	public partial class SignupForm : Form
	{


		// Constants for Dragging the Form
		private const int WM_NCLBUTTONDOWN = 0xA1;
		private const int HT_CAPTION = 0x2;


		[System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		[System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern bool ReleaseCapture();





		public SignupForm()
		{
			InitializeComponent();
			username_textBox.Focus();
			signup_button.Enabled = false;
		}

		private void close_button_Click(object sender, EventArgs e)
		{
			Object_Handler.signupForm.Hide();
			Object_Handler.loginForm.Show();
		}

		

		private void login_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Object_Handler.signupForm.Hide();
			Object_Handler.loginForm.Show();
		}

		private void signup_button_Click(object sender, EventArgs e)
		{
			User user = new User()
			{
				Username = username_textBox.Text,
				Password = password_textBox.Text,
				Data_register = DateTime.Now
			};
			Database database = new Database();
			int decision = database.addUser(user);
			if (decision > 0)
			{
				//MessageBox.Show("Signup successful!");
				Object_Handler.signupForm.Close();
				Object_Handler.loginForm.Show();
			}
			else
			{
				MessageBox.Show("Error: Signup Failed!");
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

		private void top_panel_MouseDoubleClick(object sender, MouseEventArgs e)
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
			}
			else if (e.KeyCode == Keys.Enter && signup_button.Enabled)
			{
				signup_button_Click(this, EventArgs.Empty);
			}
		}

		private void username_textBox_TextChanged(object sender, EventArgs e)
		{
			if (username_textBox.Text.Length > 0 && password_textBox.Text.Length > 0 && username_textBox.Text != "" && password_label.Text != "")
			{
				signup_button.Enabled = true;
			}
			else
			{
				signup_button.Enabled = false;
			}
		}

		private void SignupForm_Load(object sender, EventArgs e)
		{
			username_textBox.Focus();
		}
	}
}
