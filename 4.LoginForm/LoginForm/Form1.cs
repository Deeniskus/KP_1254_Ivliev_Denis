using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Form1 : Form
    {

        //Нулевой пользователь
        static Persons person = new Persons("admin", "admin", "Админ", 99);
        //Список пользователей
        static List<Persons> persons = new List<Persons>() { person };
        //Пермишены
        static EditSelfPerm editSelfPerm = new EditSelfPerm();
        //Список пермишенов
        public static List<Permissions> permissions = new List<Permissions>() { editSelfPerm };

        public Form1()
        {
            InitializeComponent();
        }

        private void EnterBTN_Click(object sender, EventArgs e)
        {
            //Если нашли совпадение по логину и паролю, создаём новое окно со всеми полями объекта
            foreach (Persons person in persons)
            {
                if (person != null)
                {
                    if (person.login.Equals(LoginTB.Text))
                    {
                        //Новый объект профайл формы
                        ProfileForm profileForm = new ProfileForm(person.login, person.password, person.name, person.age, permissions);
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
    }
}
