using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class ProfileForm : Form
    {
        //Конструктор, который на вход получает параметры текущего авторизованного юзера

        public ProfileForm(string login, string password, string name, int age, List<Permissions> permissions)
        {
            InitializeComponent();
            GreetingLabel.Text += name;
            NameTB.Text = name;
            LoginTB.Text = login;
            PasswordTB.Text = password;
            AgeTB.Text = age.ToString();

            //Проходимся по каждому пермишену и вызваем метод Enable
            foreach (var permission in permissions)
            {
                permission.Enable(this);
            }
        }

        private void ProfileForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
