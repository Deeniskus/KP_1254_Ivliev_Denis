using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm
{
    //Родительский класс всех пермишенов
    public class Permissions
    {
        //Пустой виртуальный метод, который мы будем переписывать в каждом классе наследнике
        public virtual void Enable(ProfileForm profileForm)
        {

        }
    }
}
