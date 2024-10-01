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
	public partial class AdminPortal : Form
	{

		// Constants for Dragging the Form
		private const int WM_NCLBUTTONDOWN = 0xA1;
		private const int HT_CAPTION = 0x2;


		[System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		[System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern bool ReleaseCapture();



		public AdminPortal()
		{
			InitializeComponent();
			InitializeComponent2();
		}

		private void InitializeComponent2()
		{
			add_button.Enabled = false;
			username_label.Text = Object_Handler.username;
			/// Load the Data from DataTable
			Database database = new Database();
			DataTable all_job_applicants = database.getAllRowsFromJobApplicant();
			all_job_applicants.DefaultView.Sort = "id DESC"; // Descending Order Sorting
			job_applicants_dataGridView.DataSource = all_job_applicants;
		}

		private void close_button_Click(object sender, EventArgs e)
		{
			Object_Handler.adminPortal.Close();
			Object_Handler.loginForm.Close();
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

		private void logout_button_Click(object sender, EventArgs e)
		{
			Object_Handler.username = "";
			Object_Handler.adminPortal.Hide();
			Object_Handler.loginForm.Show();
		}

		private void job_applicants_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (job_applicants_dataGridView.Columns[e.ColumnIndex].HeaderText == "Delete")
			{
				int job_applicant_id = Convert.ToInt32(job_applicants_dataGridView.Rows[e.RowIndex].Cells["id"].Value);
				//// Call Delete Function to delete the row
				//MessageBox.Show("Delete Button Clicked, on Row = "+ job_applicant_id);
				DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (dialogResult == DialogResult.Yes)
				{
					Database database = new Database();
					int decision_num = database.deleteJobApplicantById(job_applicant_id);
					if (decision_num > 0)
					{
						MessageBox.Show("Job Applicant Deleted Successfully");
						DataTable all_job_applicants = database.getAllRowsFromJobApplicant();
						all_job_applicants.DefaultView.Sort = "id DESC"; // Descending Order Sorting
						job_applicants_dataGridView.DataSource = all_job_applicants;
					}
					else
					{
						MessageBox.Show("Error Deleting Job Applicant");
					}
				}
			}
			else if(job_applicants_dataGridView.Columns[e.ColumnIndex].HeaderText == "Edit")
			{
				int job_applicant_id = Convert.ToInt32(job_applicants_dataGridView.Rows[e.RowIndex].Cells["id"].Value);
				//MessageBox.Show("Edit Button Clicked of ID = " + job_applicant_id);
				UpdateApplicantForm updateApplicantForm = new UpdateApplicantForm(job_applicant_id);
				Object_Handler.updateApplicantForm = updateApplicantForm;
				DialogResult result = Object_Handler.updateApplicantForm.ShowDialog();
				if (result == DialogResult.OK)
				{
					Database database = new Database();
					DataTable all_job_applicants = database.getAllRowsFromJobApplicant();
					all_job_applicants.DefaultView.Sort = "id DESC"; // Descending Order Sorting
					job_applicants_dataGridView.DataSource = all_job_applicants;
				}



			}

		}

		private void add_button_Click(object sender, EventArgs e)
		{
			Job_Applicant job_Applicant = new Job_Applicant
			{
				Name = name_textBox.Text,
				Phone = phone_textBox.Text,
				Address = address_textBox.Text,
				Email = email_textBox.Text
			};
			Database database = new Database();
			int decision_num = database.addJobApplicant(job_Applicant);
			if (decision_num > 0)
			{
				MessageBox.Show("Job Applicant Added Successfully");
				DataTable all_job_applicants = database.getAllRowsFromJobApplicant();
				all_job_applicants.DefaultView.Sort = "id DESC"; // Descending Order Sorting
				job_applicants_dataGridView.DataSource = all_job_applicants;
				clear_all_textBoxes();
			}
			else
			{
				MessageBox.Show("Error Adding Job Applicant");
			}

		}






		private void AdminPortal_Load(object sender, EventArgs e)
		{
			name_textBox.Focus();
		}

		private void textBox_TextChanged(object sender, EventArgs e)
		{
			if(name_textBox.Text != "" && phone_textBox.Text != "" && address_textBox.Text != "" && email_textBox.Text != "" &&
				name_textBox.Text.Length > 0 && phone_textBox.Text.Length > 0 && address_textBox.Text.Length > 0 && email_textBox.Text.Length  > 0)
			{
				add_button.Enabled = true;
			}
			else
			{
				add_button.Enabled = false;
			}
		}

		private void name_textBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Down)
			{
				address_textBox.Focus();
			}
			else if (e.KeyCode == Keys.Right)
			{
				phone_textBox.Focus();
			}
			else if (e.KeyCode == Keys.Enter && add_button.Enabled)
			{
				add_button_Click(this, EventArgs.Empty);
			}
		}

		private void address_textBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Up)
			{
				name_textBox.Focus();
			}
			else if (e.KeyCode == Keys.Right)
			{
				email_textBox.Focus();
			}
			else if (e.KeyCode == Keys.Enter && add_button.Enabled)
			{
				add_button_Click(this, EventArgs.Empty);
			}
		}

		private void phone_textBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Down)
			{
				email_textBox.Focus();
			}
			else if (e.KeyCode == Keys.Left)
			{
				name_textBox.Focus();
			}
			else if (e.KeyCode == Keys.Enter && add_button.Enabled)
			{
				add_button_Click(this, EventArgs.Empty);
			}
		}

		private void email_textBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Up)
			{
				phone_textBox.Focus();
			}
			else if (e.KeyCode == Keys.Left)
			{
				address_textBox.Focus();
			}
			else if (e.KeyCode == Keys.Enter && add_button.Enabled)
			{
				add_button_Click(this, EventArgs.Empty);
			}
		}
		


		private void clear_all_textBoxes()
		{
			name_textBox.Text = "";
			phone_textBox.Text = "";
			address_textBox.Text = "";
			email_textBox.Text = "";
		}
	}

}
