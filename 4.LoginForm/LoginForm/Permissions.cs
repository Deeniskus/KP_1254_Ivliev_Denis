using System.Collections.Generic;

namespace LoginForm
{
    //Родительский класс всех пермишенов
    public class Permissions
    {
        //Пустой виртуальный метод, который мы будем переписывать в каждом классе наследнике (активирует пермишн)
        public virtual void ApplyPermission(ProfileForm profileForm)
        {

        }
        //Константы списков пермишенов
        public static List<Permissions> Admin = new List<Permissions>() { new EditSelfPerm(), new SeeUsersPerm(), new EditOthersPerm(), new SeeAdminsPerm(), new SeeLoginPerm(), new SeePasswordPerm(), new CreateNewAccountsPerm()};
        public static List<Permissions> DefaultUser = new List<Permissions>() { new EditSelfPerm(), new SeeUsersPerm(), new SeeAdminsPerm(), new SeeLoginPerm()};
        public static List<Permissions> Guest = new List<Permissions>() { new SeeUsersPerm() };
    }
}
