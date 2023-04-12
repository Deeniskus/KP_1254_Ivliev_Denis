namespace LoginForm
{
    //Пермишен на редактирование себя
    internal class EditSelfPerm : Permission
    {
        //Переписываем метод Enable
        public override void ApplyPermission(ProfileForm profileForm)
        {
            profileForm.FirstNameTB.Enabled = true;
            profileForm.LastNameTB.Visible = true;
            profileForm.LoginTB.Visible = true;
            profileForm.SaveChangesBTN.Visible = true;
            profileForm.PasswordTB.Visible = true;
            profileForm.GenerateLoginBTN.Visible = true;
            profileForm.BirthDatePicker.Visible = true;
            profileForm.PasswordGeneratorGB.Visible = true;
            profileForm.PasswordLabel.Visible = true;
            profileForm.LoginLabel.Visible = true;
            profileForm.LastNameLabel.Visible = true;
        }
    }
}
