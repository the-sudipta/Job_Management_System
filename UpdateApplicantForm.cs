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
	public partial class UpdateApplicantForm : Form
	{
		private int update_id = -1;
		public UpdateApplicantForm(int id)
		{
			InitializeComponent();
			//MessageBox.Show($"ID: {id}");
			InitializeComponent2(id);
				
		}

		public void InitializeComponent2(int id)
		{
			if (id > 0)
			{
				update_id = id;
				load_applicant_data();
			}
			else
			{
				//MessageBox.Show("Error: No ID provided");
				this.Close();
				//Object_Handler.adminPortal.Show();
			}
		}

		private void cancel_button_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void update_button_Click(object sender, EventArgs e)
		{
			Database database = new Database();
			Job_Applicant job_Applicant = new Job_Applicant();
			job_Applicant.Name = name_textBox.Text;
			job_Applicant.Email = email_textBox.Text;
			job_Applicant.Phone = phone_textBox.Text;
			job_Applicant.Address = address_textBox.Text;

			int decision = database.updateJobApplicantById(update_id, job_Applicant);
			if(decision > 0)
			{
				this.DialogResult = DialogResult.OK;
				MessageBox.Show("Data Updated Successfully");
				this.Close();
				Object_Handler.adminPortal.Show();
			}
			else
			{
				MessageBox.Show("Error: Data not updated");
			}
		}










		private void load_applicant_data()
		{
			Database database = new Database();
			Job_Applicant job_applicant = database.getJobApplicantById(update_id);
			if (job_applicant.Id > 0)
			{
				name_textBox.Text = job_applicant.Name;
				email_textBox.Text = job_applicant.Email;
				phone_textBox.Text = job_applicant.Phone;
				address_textBox.Text = job_applicant.Address;
			}
			else
			{
				MessageBox.Show("Error: No data found");
				this.Close();
			}
		}


	}
}
