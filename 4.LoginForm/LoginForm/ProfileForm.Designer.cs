namespace LoginForm
{
    partial class ProfileForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.FirstNameTB = new System.Windows.Forms.TextBox();
            this.LastNameTB = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.BirthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordGeneratorGB = new System.Windows.Forms.GroupBox();
            this.DigitsNumNUD = new System.Windows.Forms.NumericUpDown();
            this.LettersNumNUD = new System.Windows.Forms.NumericUpDown();
            this.GeneratePasswordBTN = new System.Windows.Forms.Button();
            this.strictDigitsNumCB = new System.Windows.Forms.CheckBox();
            this.strictLettersNumCB = new System.Windows.Forms.CheckBox();
            this.isSpecSymbolsNeededCB = new System.Windows.Forms.CheckBox();
            this.isUpperCaseNeededCB = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PasswordLengthNUD = new System.Windows.Forms.NumericUpDown();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.AccountLabel = new System.Windows.Forms.Label();
            this.AccountsLB = new System.Windows.Forms.ListBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.GenerateLoginBTN = new System.Windows.Forms.Button();
            this.OtherPersonGP = new System.Windows.Forms.GroupBox();
            this.OPBirthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.OPPasswordTB = new System.Windows.Forms.TextBox();
            this.OPLoginTB = new System.Windows.Forms.TextBox();
            this.OPLastNameTB = new System.Windows.Forms.TextBox();
            this.OPFirstNameTB = new System.Windows.Forms.TextBox();
            this.OPPassword = new System.Windows.Forms.Label();
            this.OPLogin = new System.Windows.Forms.Label();
            this.OPBirthDate = new System.Windows.Forms.Label();
            this.OPLastName = new System.Windows.Forms.Label();
            this.OPFirstName = new System.Windows.Forms.Label();
            this.OPPasswordLabel = new System.Windows.Forms.Label();
            this.OPLoginLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SaveChangesBTN = new System.Windows.Forms.Button();
            this.EditOPBTN = new System.Windows.Forms.Button();
            this.SaveOPChangesBTN = new System.Windows.Forms.Button();
            this.CreateNewAccountBTN = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PasswordGeneratorGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DigitsNumNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LettersNumNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordLengthNUD)).BeginInit();
            this.OtherPersonGP.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // FirstNameTB
            // 
            this.FirstNameTB.Enabled = false;
            this.FirstNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstNameTB.Location = new System.Drawing.Point(16, 105);
            this.FirstNameTB.Name = "FirstNameTB";
            this.FirstNameTB.Size = new System.Drawing.Size(175, 26);
            this.FirstNameTB.TabIndex = 1;
            // 
            // LastNameTB
            // 
            this.LastNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastNameTB.Location = new System.Drawing.Point(206, 105);
            this.LastNameTB.Name = "LastNameTB";
            this.LastNameTB.Size = new System.Drawing.Size(181, 26);
            this.LastNameTB.TabIndex = 3;
            this.LastNameTB.Visible = false;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastNameLabel.Location = new System.Drawing.Point(202, 82);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(81, 20);
            this.LastNameLabel.TabIndex = 2;
            this.LastNameLabel.Text = "Фамилия";
            this.LastNameLabel.Visible = false;
            // 
            // BirthDatePicker
            // 
            this.BirthDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirthDatePicker.Location = new System.Drawing.Point(103, 199);
            this.BirthDatePicker.Name = "BirthDatePicker";
            this.BirthDatePicker.Size = new System.Drawing.Size(200, 26);
            this.BirthDatePicker.TabIndex = 4;
            this.BirthDatePicker.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.BirthDatePicker.Visible = false;
            // 
            // LoginTB
            // 
            this.LoginTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTB.Location = new System.Drawing.Point(16, 173);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.Size = new System.Drawing.Size(175, 26);
            this.LoginTB.TabIndex = 6;
            this.LoginTB.Visible = false;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.Location = new System.Drawing.Point(12, 150);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(55, 20);
            this.LoginLabel.TabIndex = 5;
            this.LoginLabel.Text = "Логин";
            this.LoginLabel.Visible = false;
            // 
            // PasswordGeneratorGB
            // 
            this.PasswordGeneratorGB.Controls.Add(this.DigitsNumNUD);
            this.PasswordGeneratorGB.Controls.Add(this.LettersNumNUD);
            this.PasswordGeneratorGB.Controls.Add(this.GeneratePasswordBTN);
            this.PasswordGeneratorGB.Controls.Add(this.strictDigitsNumCB);
            this.PasswordGeneratorGB.Controls.Add(this.strictLettersNumCB);
            this.PasswordGeneratorGB.Controls.Add(this.isSpecSymbolsNeededCB);
            this.PasswordGeneratorGB.Controls.Add(this.isUpperCaseNeededCB);
            this.PasswordGeneratorGB.Controls.Add(this.label4);
            this.PasswordGeneratorGB.Controls.Add(this.PasswordLengthNUD);
            this.PasswordGeneratorGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordGeneratorGB.Location = new System.Drawing.Point(13, 293);
            this.PasswordGeneratorGB.Name = "PasswordGeneratorGB";
            this.PasswordGeneratorGB.Size = new System.Drawing.Size(371, 238);
            this.PasswordGeneratorGB.TabIndex = 7;
            this.PasswordGeneratorGB.TabStop = false;
            this.PasswordGeneratorGB.Text = "Сгенерировать пароль";
            this.PasswordGeneratorGB.Visible = false;
            // 
            // DigitsNumNUD
            // 
            this.DigitsNumNUD.Location = new System.Drawing.Point(190, 142);
            this.DigitsNumNUD.Name = "DigitsNumNUD";
            this.DigitsNumNUD.Size = new System.Drawing.Size(137, 26);
            this.DigitsNumNUD.TabIndex = 15;
            this.DigitsNumNUD.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // LettersNumNUD
            // 
            this.LettersNumNUD.Location = new System.Drawing.Point(190, 114);
            this.LettersNumNUD.Name = "LettersNumNUD";
            this.LettersNumNUD.Size = new System.Drawing.Size(137, 26);
            this.LettersNumNUD.TabIndex = 14;
            this.LettersNumNUD.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // GeneratePasswordBTN
            // 
            this.GeneratePasswordBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.GeneratePasswordBTN.Location = new System.Drawing.Point(10, 188);
            this.GeneratePasswordBTN.Name = "GeneratePasswordBTN";
            this.GeneratePasswordBTN.Size = new System.Drawing.Size(158, 44);
            this.GeneratePasswordBTN.TabIndex = 13;
            this.GeneratePasswordBTN.Text = "Сгенерировать пароль";
            this.GeneratePasswordBTN.UseVisualStyleBackColor = true;
            this.GeneratePasswordBTN.Click += new System.EventHandler(this.GeneratePasswordBTN_Click);
            // 
            // strictDigitsNumCB
            // 
            this.strictDigitsNumCB.AutoSize = true;
            this.strictDigitsNumCB.Checked = true;
            this.strictDigitsNumCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.strictDigitsNumCB.Location = new System.Drawing.Point(10, 144);
            this.strictDigitsNumCB.Name = "strictDigitsNumCB";
            this.strictDigitsNumCB.Size = new System.Drawing.Size(165, 24);
            this.strictDigitsNumCB.TabIndex = 12;
            this.strictDigitsNumCB.Text = "Количество цифр";
            this.strictDigitsNumCB.UseVisualStyleBackColor = true;
            // 
            // strictLettersNumCB
            // 
            this.strictLettersNumCB.AutoSize = true;
            this.strictLettersNumCB.Checked = true;
            this.strictLettersNumCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.strictLettersNumCB.Location = new System.Drawing.Point(10, 114);
            this.strictLettersNumCB.Name = "strictLettersNumCB";
            this.strictLettersNumCB.Size = new System.Drawing.Size(156, 24);
            this.strictLettersNumCB.TabIndex = 11;
            this.strictLettersNumCB.Text = "Количество букв";
            this.strictLettersNumCB.UseVisualStyleBackColor = true;
            // 
            // isSpecSymbolsNeededCB
            // 
            this.isSpecSymbolsNeededCB.AutoSize = true;
            this.isSpecSymbolsNeededCB.Location = new System.Drawing.Point(178, 84);
            this.isSpecSymbolsNeededCB.Name = "isSpecSymbolsNeededCB";
            this.isSpecSymbolsNeededCB.Size = new System.Drawing.Size(169, 24);
            this.isSpecSymbolsNeededCB.TabIndex = 10;
            this.isSpecSymbolsNeededCB.Text = "Без спецсимволов";
            this.isSpecSymbolsNeededCB.UseVisualStyleBackColor = true;
            // 
            // isUpperCaseNeededCB
            // 
            this.isUpperCaseNeededCB.AutoSize = true;
            this.isUpperCaseNeededCB.Location = new System.Drawing.Point(178, 54);
            this.isUpperCaseNeededCB.Name = "isUpperCaseNeededCB";
            this.isUpperCaseNeededCB.Size = new System.Drawing.Size(131, 24);
            this.isUpperCaseNeededCB.TabIndex = 9;
            this.isUpperCaseNeededCB.Text = "Без аглавных";
            this.isUpperCaseNeededCB.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Длина пароля";
            // 
            // PasswordLengthNUD
            // 
            this.PasswordLengthNUD.Location = new System.Drawing.Point(10, 54);
            this.PasswordLengthNUD.Name = "PasswordLengthNUD";
            this.PasswordLengthNUD.Size = new System.Drawing.Size(41, 26);
            this.PasswordLengthNUD.TabIndex = 1;
            this.PasswordLengthNUD.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // PasswordTB
            // 
            this.PasswordTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTB.Location = new System.Drawing.Point(206, 173);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(181, 26);
            this.PasswordTB.TabIndex = 0;
            this.PasswordTB.Visible = false;
            // 
            // AccountLabel
            // 
            this.AccountLabel.AutoSize = true;
            this.AccountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccountLabel.Location = new System.Drawing.Point(432, 111);
            this.AccountLabel.Name = "AccountLabel";
            this.AccountLabel.Size = new System.Drawing.Size(185, 20);
            this.AccountLabel.TabIndex = 8;
            this.AccountLabel.Text = "Список пользователей";
            // 
            // AccountsLB
            // 
            this.AccountsLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccountsLB.FormattingEnabled = true;
            this.AccountsLB.ItemHeight = 20;
            this.AccountsLB.Location = new System.Drawing.Point(432, 145);
            this.AccountsLB.Name = "AccountsLB";
            this.AccountsLB.Size = new System.Drawing.Size(330, 264);
            this.AccountsLB.TabIndex = 9;
            this.AccountsLB.SelectedIndexChanged += new System.EventHandler(this.AccountsLB_SelectedIndexChanged);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordLabel.Location = new System.Drawing.Point(202, 150);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(67, 20);
            this.PasswordLabel.TabIndex = 10;
            this.PasswordLabel.Text = "Пароль";
            this.PasswordLabel.Visible = false;
            // 
            // GenerateLoginBTN
            // 
            this.GenerateLoginBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.GenerateLoginBTN.Location = new System.Drawing.Point(13, 238);
            this.GenerateLoginBTN.Name = "GenerateLoginBTN";
            this.GenerateLoginBTN.Size = new System.Drawing.Size(175, 44);
            this.GenerateLoginBTN.TabIndex = 16;
            this.GenerateLoginBTN.Text = "Сгенерировать логин";
            this.GenerateLoginBTN.UseVisualStyleBackColor = true;
            this.GenerateLoginBTN.Visible = false;
            this.GenerateLoginBTN.Click += new System.EventHandler(this.GenerateLoginBTN_Click);
            // 
            // OtherPersonGP
            // 
            this.OtherPersonGP.Controls.Add(this.OPBirthDatePicker);
            this.OtherPersonGP.Controls.Add(this.OPPasswordTB);
            this.OtherPersonGP.Controls.Add(this.OPLoginTB);
            this.OtherPersonGP.Controls.Add(this.OPLastNameTB);
            this.OtherPersonGP.Controls.Add(this.OPFirstNameTB);
            this.OtherPersonGP.Controls.Add(this.OPPassword);
            this.OtherPersonGP.Controls.Add(this.OPLogin);
            this.OtherPersonGP.Controls.Add(this.OPBirthDate);
            this.OtherPersonGP.Controls.Add(this.OPLastName);
            this.OtherPersonGP.Controls.Add(this.OPFirstName);
            this.OtherPersonGP.Controls.Add(this.OPPasswordLabel);
            this.OtherPersonGP.Controls.Add(this.OPLoginLabel);
            this.OtherPersonGP.Controls.Add(this.label7);
            this.OtherPersonGP.Controls.Add(this.label6);
            this.OtherPersonGP.Controls.Add(this.label5);
            this.OtherPersonGP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.OtherPersonGP.Location = new System.Drawing.Point(785, 145);
            this.OtherPersonGP.Name = "OtherPersonGP";
            this.OtherPersonGP.Size = new System.Drawing.Size(293, 192);
            this.OtherPersonGP.TabIndex = 17;
            this.OtherPersonGP.TabStop = false;
            // 
            // OPBirthDatePicker
            // 
            this.OPBirthDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OPBirthDatePicker.Location = new System.Drawing.Point(140, 86);
            this.OPBirthDatePicker.Name = "OPBirthDatePicker";
            this.OPBirthDatePicker.Size = new System.Drawing.Size(116, 26);
            this.OPBirthDatePicker.TabIndex = 22;
            this.OPBirthDatePicker.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.OPBirthDatePicker.Visible = false;
            // 
            // OPPasswordTB
            // 
            this.OPPasswordTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OPPasswordTB.Location = new System.Drawing.Point(79, 148);
            this.OPPasswordTB.Name = "OPPasswordTB";
            this.OPPasswordTB.Size = new System.Drawing.Size(150, 26);
            this.OPPasswordTB.TabIndex = 31;
            this.OPPasswordTB.Visible = false;
            // 
            // OPLoginTB
            // 
            this.OPLoginTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OPLoginTB.Location = new System.Drawing.Point(67, 120);
            this.OPLoginTB.Name = "OPLoginTB";
            this.OPLoginTB.Size = new System.Drawing.Size(150, 26);
            this.OPLoginTB.TabIndex = 30;
            this.OPLoginTB.Visible = false;
            // 
            // OPLastNameTB
            // 
            this.OPLastNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OPLastNameTB.Location = new System.Drawing.Point(93, 55);
            this.OPLastNameTB.Name = "OPLastNameTB";
            this.OPLastNameTB.Size = new System.Drawing.Size(150, 26);
            this.OPLastNameTB.TabIndex = 29;
            this.OPLastNameTB.Visible = false;
            // 
            // OPFirstNameTB
            // 
            this.OPFirstNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OPFirstNameTB.Location = new System.Drawing.Point(52, 23);
            this.OPFirstNameTB.Name = "OPFirstNameTB";
            this.OPFirstNameTB.Size = new System.Drawing.Size(150, 26);
            this.OPFirstNameTB.TabIndex = 22;
            this.OPFirstNameTB.Visible = false;
            // 
            // OPPassword
            // 
            this.OPPassword.AutoSize = true;
            this.OPPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OPPassword.Location = new System.Drawing.Point(79, 149);
            this.OPPassword.Name = "OPPassword";
            this.OPPassword.Size = new System.Drawing.Size(47, 20);
            this.OPPassword.TabIndex = 28;
            this.OPPassword.Text = "None";
            this.OPPassword.Visible = false;
            // 
            // OPLogin
            // 
            this.OPLogin.AutoSize = true;
            this.OPLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OPLogin.Location = new System.Drawing.Point(67, 123);
            this.OPLogin.Name = "OPLogin";
            this.OPLogin.Size = new System.Drawing.Size(47, 20);
            this.OPLogin.TabIndex = 27;
            this.OPLogin.Text = "None";
            this.OPLogin.Visible = false;
            // 
            // OPBirthDate
            // 
            this.OPBirthDate.AutoSize = true;
            this.OPBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OPBirthDate.Location = new System.Drawing.Point(140, 86);
            this.OPBirthDate.Name = "OPBirthDate";
            this.OPBirthDate.Size = new System.Drawing.Size(47, 20);
            this.OPBirthDate.TabIndex = 26;
            this.OPBirthDate.Text = "None";
            // 
            // OPLastName
            // 
            this.OPLastName.AutoSize = true;
            this.OPLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OPLastName.Location = new System.Drawing.Point(93, 57);
            this.OPLastName.Name = "OPLastName";
            this.OPLastName.Size = new System.Drawing.Size(47, 20);
            this.OPLastName.TabIndex = 25;
            this.OPLastName.Text = "None";
            // 
            // OPFirstName
            // 
            this.OPFirstName.AutoSize = true;
            this.OPFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OPFirstName.Location = new System.Drawing.Point(52, 26);
            this.OPFirstName.Name = "OPFirstName";
            this.OPFirstName.Size = new System.Drawing.Size(47, 20);
            this.OPFirstName.TabIndex = 24;
            this.OPFirstName.Text = "None";
            // 
            // OPPasswordLabel
            // 
            this.OPPasswordLabel.AutoSize = true;
            this.OPPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OPPasswordLabel.Location = new System.Drawing.Point(6, 149);
            this.OPPasswordLabel.Name = "OPPasswordLabel";
            this.OPPasswordLabel.Size = new System.Drawing.Size(67, 20);
            this.OPPasswordLabel.TabIndex = 23;
            this.OPPasswordLabel.Text = "Пароль";
            this.OPPasswordLabel.Visible = false;
            // 
            // OPLoginLabel
            // 
            this.OPLoginLabel.AutoSize = true;
            this.OPLoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OPLoginLabel.Location = new System.Drawing.Point(6, 123);
            this.OPLoginLabel.Name = "OPLoginLabel";
            this.OPLoginLabel.Size = new System.Drawing.Size(55, 20);
            this.OPLoginLabel.TabIndex = 22;
            this.OPLoginLabel.Text = "Логин";
            this.OPLoginLabel.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Дата рождения";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Фамилия";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(781, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Информация о пользователе";
            // 
            // SaveChangesBTN
            // 
            this.SaveChangesBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.SaveChangesBTN.Location = new System.Drawing.Point(203, 238);
            this.SaveChangesBTN.Name = "SaveChangesBTN";
            this.SaveChangesBTN.Size = new System.Drawing.Size(181, 44);
            this.SaveChangesBTN.TabIndex = 19;
            this.SaveChangesBTN.Text = "Сохранить изменения";
            this.SaveChangesBTN.UseVisualStyleBackColor = true;
            this.SaveChangesBTN.Visible = false;
            this.SaveChangesBTN.Click += new System.EventHandler(this.SaveChangesBTN_Click);
            // 
            // EditOPBTN
            // 
            this.EditOPBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EditOPBTN.Location = new System.Drawing.Point(785, 343);
            this.EditOPBTN.Name = "EditOPBTN";
            this.EditOPBTN.Size = new System.Drawing.Size(140, 49);
            this.EditOPBTN.TabIndex = 20;
            this.EditOPBTN.Text = "Редактировать пользователя";
            this.EditOPBTN.UseVisualStyleBackColor = true;
            this.EditOPBTN.Visible = false;
            this.EditOPBTN.Click += new System.EventHandler(this.EditOPBTN_Click);
            // 
            // SaveOPChangesBTN
            // 
            this.SaveOPChangesBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SaveOPChangesBTN.Location = new System.Drawing.Point(931, 343);
            this.SaveOPChangesBTN.Name = "SaveOPChangesBTN";
            this.SaveOPChangesBTN.Size = new System.Drawing.Size(140, 49);
            this.SaveOPChangesBTN.TabIndex = 21;
            this.SaveOPChangesBTN.Text = "Сохранить изменения";
            this.SaveOPChangesBTN.UseVisualStyleBackColor = true;
            this.SaveOPChangesBTN.Visible = false;
            this.SaveOPChangesBTN.Click += new System.EventHandler(this.SaveOPChangesBTN_Click);
            // 
            // CreateNewAccountBTN
            // 
            this.CreateNewAccountBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.CreateNewAccountBTN.Location = new System.Drawing.Point(432, 415);
            this.CreateNewAccountBTN.Name = "CreateNewAccountBTN";
            this.CreateNewAccountBTN.Size = new System.Drawing.Size(330, 44);
            this.CreateNewAccountBTN.TabIndex = 22;
            this.CreateNewAccountBTN.Text = "Создать нового пользователя";
            this.CreateNewAccountBTN.UseVisualStyleBackColor = true;
            this.CreateNewAccountBTN.Visible = false;
            this.CreateNewAccountBTN.Click += new System.EventHandler(this.CreateNewAccountBTN_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.PasswordGeneratorGB);
            this.groupBox1.Controls.Add(this.GenerateLoginBTN);
            this.groupBox1.Controls.Add(this.SaveChangesBTN);
            this.groupBox1.Controls.Add(this.BirthDatePicker);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.groupBox1.Location = new System.Drawing.Point(3, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 545);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Личный кабинет";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(138, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Дата рождения";
            this.label2.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.groupBox2.Location = new System.Drawing.Point(416, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(697, 461);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Пользователи";
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 588);
            this.Controls.Add(this.CreateNewAccountBTN);
            this.Controls.Add(this.SaveOPChangesBTN);
            this.Controls.Add(this.EditOPBTN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OtherPersonGP);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.AccountsLB);
            this.Controls.Add(this.AccountLabel);
            this.Controls.Add(this.LoginTB);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.LastNameTB);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameTB);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "ProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProfileForm_FormClosed);
            this.PasswordGeneratorGB.ResumeLayout(false);
            this.PasswordGeneratorGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DigitsNumNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LettersNumNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordLengthNUD)).EndInit();
            this.OtherPersonGP.ResumeLayout(false);
            this.OtherPersonGP.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox FirstNameTB;
        public System.Windows.Forms.TextBox LastNameTB;
        public System.Windows.Forms.Label LastNameLabel;
        public System.Windows.Forms.DateTimePicker BirthDatePicker;
        public System.Windows.Forms.TextBox LoginTB;
        public System.Windows.Forms.Label LoginLabel;
        public System.Windows.Forms.GroupBox PasswordGeneratorGB;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.NumericUpDown PasswordLengthNUD;
        public System.Windows.Forms.TextBox PasswordTB;
        public System.Windows.Forms.CheckBox strictDigitsNumCB;
        public System.Windows.Forms.CheckBox strictLettersNumCB;
        public System.Windows.Forms.CheckBox isSpecSymbolsNeededCB;
        public System.Windows.Forms.CheckBox isUpperCaseNeededCB;
        public System.Windows.Forms.Button GeneratePasswordBTN;
        public System.Windows.Forms.Label AccountLabel;
        public System.Windows.Forms.ListBox AccountsLB;
        public System.Windows.Forms.NumericUpDown DigitsNumNUD;
        public System.Windows.Forms.NumericUpDown LettersNumNUD;
        public System.Windows.Forms.Label PasswordLabel;
        public System.Windows.Forms.Button GenerateLoginBTN;
        private System.Windows.Forms.GroupBox OtherPersonGP;
        public System.Windows.Forms.Label OPPassword;
        public System.Windows.Forms.Label OPLogin;
        public System.Windows.Forms.Label OPBirthDate;
        public System.Windows.Forms.Label OPLastName;
        public System.Windows.Forms.Label OPFirstName;
        public System.Windows.Forms.Label OPPasswordLabel;
        public System.Windows.Forms.Label OPLoginLabel;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button SaveChangesBTN;
        public System.Windows.Forms.Button EditOPBTN;
        public System.Windows.Forms.Button SaveOPChangesBTN;
        public System.Windows.Forms.DateTimePicker OPBirthDatePicker;
        public System.Windows.Forms.TextBox OPPasswordTB;
        public System.Windows.Forms.TextBox OPLoginTB;
        public System.Windows.Forms.TextBox OPLastNameTB;
        public System.Windows.Forms.TextBox OPFirstNameTB;
        public System.Windows.Forms.Button CreateNewAccountBTN;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

