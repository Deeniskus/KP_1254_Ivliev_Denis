using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm
{
    internal class CreateNewAccountsPerm : Permissions
    {
        public override void ApplyPermission(ProfileForm profileForm)
        {
            profileForm.CreateNewAccountBTN.Visible = true;
        }
    }
}
