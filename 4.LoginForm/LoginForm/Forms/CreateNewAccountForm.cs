using LoginForm.AdditionalHelpers;
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
            //Проверяем радио батн
            List<Permission> permissions;
            if (AdminRB.Checked)
            {
                permissions = Permission.Admin;
            }
            else
            {
                permissions = Permission.DefaultUser;
            }

            //Создаём аккаунт на основе TB'ов
            Account account = new Account(Account.Accounts.Count,
                OPFirstNameTB.Text,
                OPLastNameTB.Text,
                OPLoginTB.Text,
                OPPasswordTB.Text,
                OPBirthDatePicker.Value,
                permissions);
            //Добавляем в общий список аккаунтов
            Account.Accounts.Add(account);


            //Добавляем в LB профайл формы
            profileForm.AccountsLB.Items.Add(account.GetTitle());
            Close();
        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
