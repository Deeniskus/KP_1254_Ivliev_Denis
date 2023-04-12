using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm
{
    internal class SeePasswordPerm : Permission
    {
        public override void ApplyPermission(ProfileForm profileForm)
        {
            profileForm.OPPassword.Visible = true;
            profileForm.OPPasswordLabel.Visible = true;
        }
    }
}
