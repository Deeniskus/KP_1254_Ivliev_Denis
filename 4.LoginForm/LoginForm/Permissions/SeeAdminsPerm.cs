namespace LoginForm
{
    internal class SeeAdminsPerm : Permission
    {
        //Чистим список, и и заполняем заново с админами. Да, не эффективно, но мне было лень в профайл форме там кое-что внизу делать
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
