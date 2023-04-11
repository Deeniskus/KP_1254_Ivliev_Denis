using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm
{
    internal class SeeLoginPerm : Permissions
    {
        public override void ApplyPermission(ProfileForm profileForm)
        {
            profileForm.OPLogin.Visible = true;
            profileForm.OPLoginLabel.Visible = true;
        }
    }
}
