using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm
{
    internal class SeeUsersPerm : Permissions
    {
        public override void ApplyPermission(ProfileForm profileForm)
        {
            foreach (Account account in Account.Accounts)
            {
                if (!profileForm.AccountsLB.Items.Contains(account.GetTitle())) 
                {
                    if (account.permissions != Permissions.Admin)
                    {
                        profileForm.AccountsLB.Items.Add(account.GetTitle());
                    }
                }
            }
        }
    }
}
