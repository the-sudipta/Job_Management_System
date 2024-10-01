using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Job_Management_System.Models;

namespace Job_Management_System
{
	public class Database
	{
		/// <summary>
		/// 1. Open the Server Explorer in Visual Studio
		/// 2. Connect to the database
		/// 3. Right-click on the database in 'Data Connection' and select Properties
		/// 4. Copy the Connection String from the Properties window
		/// </summary>
		private string connectionString = "Data Source=ANONYMOUS\\SQLEXPRESS;Initial Catalog=job_management;Integrated Security=True;";


		public Database(){}

		public DataTable getAllRowsFromJobApplicant()
		{
			DataTable dataTable = new DataTable();
			string query = "SELECT * FROM job_applicant";

			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();
					using (SqlCommand cmd = new SqlCommand(query, conn))
					{
						using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
						{
							adapter.Fill(dataTable);
						}
					}
					conn.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}");
			}
			return dataTable;
		}

		public string getPasswordByUsername(string username)
		{
			string password = "";
			string query = "SELECT password FROM users WHERE username = @username";

			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();
					using (SqlCommand cmd = new SqlCommand(query, conn))
					{
						cmd.Parameters.AddWithValue("@username", username);
						object result = cmd.ExecuteScalar();
						if (result != null)
						{
							password = result.ToString();
						}
					}
					conn.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}");
			}
			return password;
		}

		public Job_Applicant getJobApplicantById(int id)
		{
			string query = "SELECT * FROM job_applicant WHERE id = @id";

			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();
					using (SqlCommand cmd = new SqlCommand(query, conn))
					{
						cmd.Parameters.AddWithValue("@id", id);
						using (SqlDataReader reader = cmd.ExecuteReader())
						{
							if (reader.Read())
							{
								Job_Applicant job_Applicant = new Job_Applicant
								{
									Id = reader.GetInt32(0),        // Get id 
									Name = reader.GetString(1),      // Get name
									Address = reader.GetString(2),   // Get address
									Phone = reader.GetString(3),     // Get phone
									Email = reader.GetString(4)      // Get email
								};
								return job_Applicant;
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}");
			}
			return null;
		}

		public int deleteJobApplicantById(int id)
		{
			string query = "DELETE FROM job_applicant WHERE id = @id";

			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();
					using (SqlCommand cmd = new SqlCommand(query, conn))
					{
						cmd.Parameters.AddWithValue("@id", id);
						int rowsAffected = cmd.ExecuteNonQuery();
						conn.Close();
						return rowsAffected;
					}
					
				}
			}
			catch (Exception ex)
			{
				return -1;
			}
		}

		public int updateJobApplicantById(int id, Job_Applicant job_Applicant)
		{
			string query = "UPDATE job_applicant SET name = @name, address = @address, phone = @phone, email = @email WHERE id = @id";

			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();
					using (SqlCommand cmd = new SqlCommand(query, conn))
					{
						cmd.Parameters.AddWithValue("@name", job_Applicant.Name);
						cmd.Parameters.AddWithValue("@address", job_Applicant.Address);
						cmd.Parameters.AddWithValue("@phone", job_Applicant.Phone);
						cmd.Parameters.AddWithValue("@email", job_Applicant.Email);

						cmd.Parameters.AddWithValue("@id", id);

						int rowsAffected = cmd.ExecuteNonQuery();
						conn.Close();
						return rowsAffected;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}");
				return -1; // Return -1 in case of an error
			}
		}

		public int addJobApplicant(Job_Applicant job_Applicant)
		{
			string query = "INSERT INTO job_applicant (name, address, phone, email) VALUES (@name, @address, @phone, @email)";

			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();
					using (SqlCommand cmd = new SqlCommand(query, conn))
					{
						cmd.Parameters.AddWithValue("@name", job_Applicant.Name);
						cmd.Parameters.AddWithValue("@address", job_Applicant.Address);
						cmd.Parameters.AddWithValue("@phone", job_Applicant.Phone);
						cmd.Parameters.AddWithValue("@email", job_Applicant.Email);

						int rowsAffected = cmd.ExecuteNonQuery();
						conn.Close();
						return rowsAffected;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}");
				return -1; // Return -1 in case of an error
			}
		}

		public int addUser(User user)
		{
			string query = "INSERT INTO users (username, password, data_register) VALUES (@username, @password, @data_register)";

			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();
					using (SqlCommand cmd = new SqlCommand(query, conn))
					{
						cmd.Parameters.AddWithValue("@username", user.Username);
						cmd.Parameters.AddWithValue("@password", user.Password);
						cmd.Parameters.AddWithValue("@data_register", user.Data_register);

						int rowsAffected = cmd.ExecuteNonQuery();
						conn.Close();
						return rowsAffected;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}");
				return -1; // Return -1 in case of an error
			}
		}





	}
}
