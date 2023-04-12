using LoginForm.AdditionalHelpers;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class LoginForm : Form
    {
        

        public LoginForm()
        {
            Account.Accounts = JsonHelper.DeserializeUserInfo("UsersInfo.json");
            JsonHelper.DeserializePasswords("UsersPasswords.json");
            InitializeComponent();
        }

        private void EnterBTN_Click(object sender, EventArgs e)
        {
            //Если нашли совпадение по логину и паролю, создаём новое окно со всеми полями объекта
            foreach (Account account in Account.Accounts)
            {
                if (account != null)
                {
                    if (account.login.Equals(LoginTB.Text) && account.password.Equals(PasswordTB.Text))
                    {
                        //Новый объект профайл формы
                        ProfileForm profileForm = new ProfileForm(account.id, account.login, account.password, account.firstName, account.lastName, account.birthDate, account.permissions);
                        //Прячем текущее окно
                        this.Hide();
                        //Показываем окно профайл формы
                        profileForm.Show();
                        break;
                    }
                }
            }
        }
        //Без этого процесс не завершается, если закрыть форму
        //(хз почему, по дефолту это работает, но если вызвать другое окно, а потом снова это окно,
        //то по закрытию процесс не завершается)
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void EnterAsGuestBTN_Click(object sender, EventArgs e)
        {
            //Входим как гость
            ProfileForm profileForm = new ProfileForm(-1, "Guest", "", "Гость", "", DateTime.Today, Permission.Guest);
            this.Hide();
            profileForm.Show();
        }
    }
}
