using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm
{
    //Пермишен на редактирование себя
    internal class EditSelfPerm : Permissions
    {
        //Переписываем метод Enable
        public override void Enable(ProfileForm profileForm)
        {
            profileForm.NameTB.Enabled = true;
            profileForm.LoginTB.Enabled = true;
            profileForm.PasswordTB.Enabled = true;
            profileForm.AgeTB.Enabled = true;
        }
    }
}
