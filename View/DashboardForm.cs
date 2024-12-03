using facial_recognition.FormIdentity;
using facial_recognition.Model;
using facial_recognition.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace facial_recognition.View
{
	public partial class DashboardForm : Form
	{

		private int Id = 0;

		public DashboardForm()
		{
			InitializeComponent();
		}

		private void DashboardForm_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'facialDataSet2.WORKSTATUS' table. You can move, or remove it, as needed.
			this.wORKSTATUSTableAdapter.Fill(this.facialDataSet2.WORKSTATUS);
			// TODO: This line of code loads data into the 'facialDataSet1.CIVILSTATUS' table. You can move, or remove it, as needed.
			this.cIVILSTATUSTableAdapter.Fill(this.facialDataSet1.CIVILSTATUS);
			// TODO: This line of code loads data into the 'facialDataSet.GENDER' table. You can move, or remove it, as needed.
			this.gENDERTableAdapter.Fill(this.facialDataSet.GENDER);

			GetUser();
		}

		private void EditButton_Click(object sender, EventArgs e)
		{
			FieldStatus(true);
		}

		private void FieldStatus(bool isEnabled)
		{
			FullnameTextBox.Enabled = isEnabled;
			AddressTextBox.Enabled = isEnabled;
			EmailTextBox.Enabled = isEnabled;
			PNumberTextBox.Enabled = isEnabled;
			AgeTextBox.Enabled = isEnabled;
			GenderComboBox.Enabled = isEnabled;
			CivilStatusComboBox.Enabled = isEnabled;
			WorkStatusComboBox.Enabled = isEnabled;
			DateOfBirthTextBox.Enabled = isEnabled;
			UpdateButton.Enabled = isEnabled;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var login = new LoginForm();
			Session.Clear();
			login.Show();
			this.Hide();
		}

		private void GetUser()
		{
			var repo = new DashboardRepository();

			string stringify = Session.GetClaim("Id").ToString();
			int userId = int.Parse(stringify);

			foreach (var i in repo.GetUser(userId))
			{
				FullnameTextBox.Text = i.Fullname;
				AddressTextBox.Text = i.Address;
				EmailTextBox.Text = i.Email;
				PNumberTextBox.Text = i.Phone;
				AgeTextBox.Text = i.Age.ToString();
				GenderComboBox.Text = i.Gender;
				CivilStatusComboBox.Text = i.CivilStatus;
				GuardianTextBox.Text = i.Guardian;
				WorkStatusComboBox.Text = i.WorkStatus;
				DateOfBirthTextBox.Text = i.DateOfBirth.ToString();
				pictureBox1.Image = i.ProfileImage;
				Id = i.Id;
				UpdateButton.Enabled = true;
			}
		}

		private void UpdateButton_Click(object sender, EventArgs e)
		{
			try
			{
				ErrorLabel.Visible = false;
				var model = new Update
				(FullnameTextBox.Text, AddressTextBox.Text, EmailTextBox.Text, PNumberTextBox.Text,
				AgeTextBox.Text, GenderComboBox.Text, GuardianTextBox.Text, CivilStatusComboBox.Text, WorkStatusComboBox.Text, DateOfBirthTextBox.Text, Id);

				bool isSuccess = model.UpdateUser();

				if(!isSuccess)
				{
					ErrorLabel.Visible = true;
					ErrorLabel.Text = "Failed to update user.";
					return;
				}	

				FieldStatus(false);
			}
			catch(Exception ex)
			{
				ErrorLabel.Visible = true;
				ErrorLabel.Text = ex.Message;
			}
		}
	}
}
