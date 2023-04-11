namespace LoginForm
{
    internal class SeeAdminsPerm : Permissions
    {
        public override void ApplyPermission(ProfileForm profileForm)
        {
            profileForm.AccountsLB.Items.Clear();
            foreach (Account account in Account.Accounts)
            {
                profileForm.AccountsLB.Items.Add(account.GetTitle());
            }
        }
    }
}
