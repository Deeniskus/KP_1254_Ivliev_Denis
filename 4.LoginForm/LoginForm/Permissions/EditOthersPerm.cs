namespace LoginForm
{
    internal class EditOthersPerm : Permissions
    {
        //Проверяет текущего залогиненого пользователя с текущим выбранным, если есть пирмишн на редактирование, то разрешает редактировать

        public override void ApplyPermission(ProfileForm profileForm)
        {
            profileForm.EditOPBTN.Visible = true;
        }
    }
}
