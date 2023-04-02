namespace RegistrationForm
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.BitthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.label5 = new System.Windows.Forms.Label();
            this.AccountsLB = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DigitsNumNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LettersNumNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordLengthNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // FirstNameTB
            // 
            this.FirstNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstNameTB.Location = new System.Drawing.Point(16, 32);
            this.FirstNameTB.Name = "FirstNameTB";
            this.FirstNameTB.Size = new System.Drawing.Size(147, 26);
            this.FirstNameTB.TabIndex = 1;
            // 
            // LastNameTB
            // 
            this.LastNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastNameTB.Location = new System.Drawing.Point(169, 32);
            this.LastNameTB.Name = "LastNameTB";
            this.LastNameTB.Size = new System.Drawing.Size(147, 26);
            this.LastNameTB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(165, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Фамилия";
            // 
            // BitthDatePicker
            // 
            this.BitthDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BitthDatePicker.Location = new System.Drawing.Point(322, 32);
            this.BitthDatePicker.Name = "BitthDatePicker";
            this.BitthDatePicker.Size = new System.Drawing.Size(200, 26);
            this.BitthDatePicker.TabIndex = 4;
            // 
            // LoginTB
            // 
            this.LoginTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTB.Location = new System.Drawing.Point(16, 100);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.Size = new System.Drawing.Size(147, 26);
            this.LoginTB.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Логин";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DigitsNumNUD);
            this.groupBox1.Controls.Add(this.LettersNumNUD);
            this.groupBox1.Controls.Add(this.GeneratePasswordBTN);
            this.groupBox1.Controls.Add(this.strictDigitsNumCB);
            this.groupBox1.Controls.Add(this.strictLettersNumCB);
            this.groupBox1.Controls.Add(this.isSpecSymbolsNeededCB);
            this.groupBox1.Controls.Add(this.isUpperCaseNeededCB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.PasswordLengthNUD);
            this.groupBox1.Controls.Add(this.PasswordTB);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(16, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 260);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Пароль";
            // 
            // DigitsNumNUD
            // 
            this.DigitsNumNUD.Location = new System.Drawing.Point(190, 166);
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
            this.LettersNumNUD.Location = new System.Drawing.Point(190, 138);
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
            this.GeneratePasswordBTN.Location = new System.Drawing.Point(93, 210);
            this.GeneratePasswordBTN.Name = "GeneratePasswordBTN";
            this.GeneratePasswordBTN.Size = new System.Drawing.Size(158, 44);
            this.GeneratePasswordBTN.TabIndex = 13;
            this.GeneratePasswordBTN.Text = "Сгенерировать";
            this.GeneratePasswordBTN.UseVisualStyleBackColor = true;
            this.GeneratePasswordBTN.Click += new System.EventHandler(this.GeneratePasswordBTN_Click);
            // 
            // strictDigitsNumCB
            // 
            this.strictDigitsNumCB.AutoSize = true;
            this.strictDigitsNumCB.Checked = true;
            this.strictDigitsNumCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.strictDigitsNumCB.Location = new System.Drawing.Point(10, 168);
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
            this.strictLettersNumCB.Location = new System.Drawing.Point(10, 138);
            this.strictLettersNumCB.Name = "strictLettersNumCB";
            this.strictLettersNumCB.Size = new System.Drawing.Size(156, 24);
            this.strictLettersNumCB.TabIndex = 11;
            this.strictLettersNumCB.Text = "Количество букв";
            this.strictLettersNumCB.UseVisualStyleBackColor = true;
            // 
            // isSpecSymbolsNeededCB
            // 
            this.isSpecSymbolsNeededCB.AutoSize = true;
            this.isSpecSymbolsNeededCB.Location = new System.Drawing.Point(178, 108);
            this.isSpecSymbolsNeededCB.Name = "isSpecSymbolsNeededCB";
            this.isSpecSymbolsNeededCB.Size = new System.Drawing.Size(169, 24);
            this.isSpecSymbolsNeededCB.TabIndex = 10;
            this.isSpecSymbolsNeededCB.Text = "Без спецсимволов";
            this.isSpecSymbolsNeededCB.UseVisualStyleBackColor = true;
            // 
            // isUpperCaseNeededCB
            // 
            this.isUpperCaseNeededCB.AutoSize = true;
            this.isUpperCaseNeededCB.Location = new System.Drawing.Point(178, 78);
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
            this.label4.Location = new System.Drawing.Point(6, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Длина пароля";
            // 
            // PasswordLengthNUD
            // 
            this.PasswordLengthNUD.Location = new System.Drawing.Point(10, 78);
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
            this.PasswordTB.Location = new System.Drawing.Point(7, 26);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(217, 26);
            this.PasswordTB.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(441, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Список пользователей";
            // 
            // AccountsLB
            // 
            this.AccountsLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccountsLB.FormattingEnabled = true;
            this.AccountsLB.ItemHeight = 20;
            this.AccountsLB.Location = new System.Drawing.Point(445, 132);
            this.AccountsLB.Name = "AccountsLB";
            this.AccountsLB.Size = new System.Drawing.Size(330, 264);
            this.AccountsLB.TabIndex = 9;
            this.AccountsLB.SelectedIndexChanged += new System.EventHandler(this.AccountsLB_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AccountsLB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LoginTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BitthDatePicker);
            this.Controls.Add(this.LastNameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FirstNameTB);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DigitsNumNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LettersNumNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordLengthNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FirstNameTB;
        private System.Windows.Forms.TextBox LastNameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker BitthDatePicker;
        private System.Windows.Forms.TextBox LoginTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown PasswordLengthNUD;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.CheckBox strictDigitsNumCB;
        private System.Windows.Forms.CheckBox strictLettersNumCB;
        private System.Windows.Forms.CheckBox isSpecSymbolsNeededCB;
        private System.Windows.Forms.CheckBox isUpperCaseNeededCB;
        private System.Windows.Forms.Button GeneratePasswordBTN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox AccountsLB;
        private System.Windows.Forms.NumericUpDown DigitsNumNUD;
        private System.Windows.Forms.NumericUpDown LettersNumNUD;
    }
}

