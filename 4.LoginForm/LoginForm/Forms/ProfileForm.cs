using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class ProfileForm : Form
    {
        public static Account currentSelectedAccount;
        public static Account previousAccount;
        public static Account loggedAccount;

        //На вход конструктора получаем текущего залогированного пользователя
        public ProfileForm(int id, string login, string password, string firstName, string lastName, DateTime birthDate, List<Permissions> permissions)
        {
           
            InitializeComponent();


            //Заполняем ЛК
            FirstNameTB.Text = firstName;
            LastNameTB.Text = lastName;
            PasswordTB.Text = password;
            BirthDatePicker.Value = birthDate;
            LoginTB.Text = login;

            //Запоминаем залогированный акк
            loggedAccount = new Account(id, firstName, lastName, login, password, birthDate, permissions);
            currentSelectedAccount = loggedAccount;

            //Проходимся по каждому пермишену и вызваем метод Apply
            foreach (var permission in permissions)
            {
                permission.ApplyPermission(this);
            }

            //Выбираем выбранным первый :)
            AccountsLB.SelectedIndex = 0;


        }



        //Заполнение данных по клику
        private void AccountsLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AccountsLB.SelectedItem != null)
            {
                string item = AccountsLB.SelectedItem.ToString();
                foreach (Account account in Account.Accounts)
                {
                    if (account.GetTitle().Equals(item))
                    {
                        currentSelectedAccount = account;

                        //Заполняем другого пользователя
                        OtherPersonGP.Text = account.GetTitle();
                        OPFirstName.Text = account.firstName;
                        OPLastName.Text = account.lastName;
                        OPLogin.Text = account.login;
                        OPPassword.Text = account.password;
                        OPBirthDate.Text = account.birthDate.ToString().Remove(account.birthDate.ToString().Length - 8);
                    }
                }
            }
        }

        private void GenerateLoginBTN_Click(object sender, EventArgs e)
        {
            //Генирируем логин
            LoginTB.Text = Account.Translate(FirstNameTB.Text) + Account.Translate(LastNameTB.Text);
        }
        private void GeneratePasswordBTN_Click(object sender, EventArgs e)
        {
            //Генирируем пароль
            PasswordTB.Text = PasswordGenerator.GetPassword(this);
        }
        private void ProfileForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide(); //Чтобы не забывалась информация в окне
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
        
        //Редактировать другого пользователя
        private void EditOPBTN_Click(object sender, EventArgs e)
        {

            previousAccount = currentSelectedAccount;

            OPFirstName.Visible = false;
            OPLastName.Visible = false;
            OPLogin.Visible = false;
            OPPassword.Visible = false;
            OPBirthDate.Visible = false;

            OPFirstNameTB.Text = currentSelectedAccount.firstName;
            OPLastNameTB.Text = currentSelectedAccount.lastName;
            OPLoginTB.Text = currentSelectedAccount.login;
            OPPasswordTB.Text = currentSelectedAccount.password;
            OPBirthDatePicker.Value = currentSelectedAccount.birthDate;

            OPFirstNameTB.Visible = true;
            OPLastNameTB.Visible = true;
            OPLoginTB.Visible = true;
            OPPasswordTB.Visible = true;
            OPBirthDatePicker.Visible = true;

            SaveOPChangesBTN.Visible = true;

        }

        private void SaveOPChangesBTN_Click(object sender, EventArgs e)
        {
            SaveOPChangesBTN.Visible = false;

            OPFirstNameTB.Visible = false;
            OPLastNameTB.Visible = false;
            OPLoginTB.Visible = false;
            OPPasswordTB.Visible = false;
            OPBirthDatePicker.Visible = false;

            OPFirstName.Visible = true;
            OPLastName.Visible = true;
            OPLogin.Visible = true;
            OPPassword.Visible = true;
            OPBirthDate.Visible = true;


            currentSelectedAccount.firstName = OPFirstNameTB.Text;
            currentSelectedAccount.lastName = OPLastNameTB.Text;
            currentSelectedAccount.login = OPLoginTB.Text;
            currentSelectedAccount.password = OPPasswordTB.Text;
            currentSelectedAccount.birthDate = OPBirthDatePicker.Value;

            //Те самые строки, почему в SeeAdminPerm код не эффективные (просто чтобы тут он был красивый)
            Account.Accounts[currentSelectedAccount.id] = currentSelectedAccount;
            AccountsLB.Items[currentSelectedAccount.id] = currentSelectedAccount.GetTitle();
        }

        //Форма создания аккаунта
        private void CreateNewAccountBTN_Click(object sender, EventArgs e)
        {
            CreateNewAccountForm createNewAccountForm = new CreateNewAccountForm(this);
            createNewAccountForm.ShowDialog();
        }

        //Редактировать свой ЛК
        private void SaveChangesBTN_Click(object sender, EventArgs e)
        {
            loggedAccount.firstName = FirstNameTB.Text;
            loggedAccount.lastName = LastNameTB.Text;
            loggedAccount.login = LoginTB.Text;
            loggedAccount.password = PasswordTB.Text;
            loggedAccount.birthDate = BirthDatePicker.Value;

            Account.Accounts[loggedAccount.id] = loggedAccount;
            AccountsLB.Items[loggedAccount.id] = loggedAccount.GetTitle();
        }
    }
}
