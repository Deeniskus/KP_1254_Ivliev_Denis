using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class CreateNewAccountForm : Form
    {
        ProfileForm profileForm;
        public CreateNewAccountForm(ProfileForm profileForm)
        {
            this.profileForm = profileForm;
            InitializeComponent();
        }

        private void AcceptBTN_Click(object sender, EventArgs e)
        {
            List<Permissions> permissions;
            if (AdminRB.Checked)
            {
                permissions = Permissions.Admin;
            }
            else
            {
                permissions = Permissions.DefaultUser;
            }


            Account account = new Account(Account.Accounts.Count,
                OPFirstNameTB.Text,
                OPLastNameTB.Text,
                OPLoginTB.Text,
                OPPasswordTB.Text,
                OPBirthDatePicker.Value,
                permissions);
            Account.Accounts.Add(account);
            profileForm.AccountsLB.Items.Add(account.GetTitle());
            Close();
        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
