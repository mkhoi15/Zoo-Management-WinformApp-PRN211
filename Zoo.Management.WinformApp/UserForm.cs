using Microsoft.VisualBasic.ApplicationServices;
using Repositories;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Zoo.Management.WinformApp
{
    public partial class UserForm : Form
    {
        private readonly UserRepository _resipotory;
        private List<ApplicationUser> _applicationUsers = new List<ApplicationUser>();
        public UserForm()
        {
            _resipotory = new UserRepository();
            InitializeComponent();
            this.ShowListUser();
        }

        private void ShowListUser()
        {
            _applicationUsers = _resipotory.GetAll().AsNoTracking().ToList();
            dgvUser.DataSource = _applicationUsers.Select(u => new
            {
                Id = u.Id.ToString(),
                userName = u.UserName,
                fullName = u.FullName,
                email = u.Email,
                phoneNumber = u.PhoneNumber,
                gender = u.Gender,
                role = u.Role,
                dob = u.Dob,
            }).ToList();
        }
        private void EmptyBoxes()
        {
            txtId.Text = String.Empty;
            txtUserName.Text = String.Empty;
            txtPassword.Text = String.Empty;
            txtFullName.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtPhoneNumber.Text = String.Empty;
            cbGender.Text = String.Empty;
            cbRole.Text = String.Empty;
            dtpDateOfBirth.Value = DateTime.UtcNow;
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            var userName = txtUserName.Text;
            var password = txtPassword.Text;
            var fullName = txtFullName.Text;
            var email = txtEmail.Text;
            var phoneNumber = txtPhoneNumber.Text;

            var gender = cbGender.Text;
            var role = cbRole.Text;
            var dob = dtpDateOfBirth.Value;

            var newUser = new ApplicationUser()
            {
                UserName = userName,
                Password = password,
                FullName = fullName,
                Email = email,
                PhoneNumber = phoneNumber,
                Gender = gender,
                Role = role,
                Dob = dob,
            };
            await _resipotory.AddAsync(newUser);
            ShowListUser();
        }

        private void dgvUser_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnCreate.Enabled = false;
            var data = _applicationUsers[e.RowIndex];
            txtId.Text = data.Id.ToString();
            txtUserName.Text = data.UserName;
            txtPassword.Text = data.Password;
            txtFullName.Text = data.FullName;
            txtEmail.Text = data.Email;
            txtPhoneNumber.Text = data.PhoneNumber;
            cbGender.Text = data.Gender.ToString();
            cbRole.Text = data.Role.ToString();
            dtpDateOfBirth.Text = data.Dob.ToString();

        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            var userName = txtUserName.Text;
            var password = txtPassword.Text;
            var fullName = txtFullName.Text;
            var email = txtEmail.Text;
            var phoneNumber = txtPhoneNumber.Text;
            var id = txtId.Text;

            var gender = cbGender.Text;
            var role = cbRole.Text;
            var dob = dtpDateOfBirth.Value;

            var newUser = new ApplicationUser()
            {
                Id = int.Parse(id),
                UserName = userName,
                Password = password,
                FullName = fullName,
                Email = email,
                PhoneNumber = phoneNumber,
                Gender = gender,
                Role = role,
                Dob = dob,
            };
            await _resipotory.UpdateAsync(newUser);
            EmptyBoxes();
            MessageBox.Show("Updated");
            ShowListUser();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }


    }

}
