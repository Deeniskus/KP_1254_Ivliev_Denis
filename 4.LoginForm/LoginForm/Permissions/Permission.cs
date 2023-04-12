using System.Collections.Generic;

namespace LoginForm
{
    //Родительский класс всех пермишенов
    public class Permission
    {
        //Пустой виртуальный метод, который мы будем переписывать в каждом классе наследнике (активирует пермишн)
        public virtual void ApplyPermission(ProfileForm profileForm)
        {

        }
        //Константы списки пермишенов
        public static List<Permission> Admin = new List<Permission>() { new EditSelfPerm(), new SeeUsersPerm(), new EditOthersPerm(), new SeeAdminsPerm(), new SeeLoginPerm(), new SeePasswordPerm(), new CreateNewAccountsPerm()};
        public static List<Permission> DefaultUser = new List<Permission>() { new EditSelfPerm(), new SeeUsersPerm(), new SeeAdminsPerm(), new SeeLoginPerm()};
        public static List<Permission> Guest = new List<Permission>() { new SeeUsersPerm() };
    }
}
