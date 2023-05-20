namespace Cypher
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
            this.InputTB = new System.Windows.Forms.TextBox();
            this.AvailableInstructionsLB = new System.Windows.Forms.ListBox();
            this.AddBTN = new System.Windows.Forms.Button();
            this.RemoveBTN = new System.Windows.Forms.Button();
            this.ActualInstructionsLB = new System.Windows.Forms.ListBox();
            this.UpBTN = new System.Windows.Forms.Button();
            this.DownBTN = new System.Windows.Forms.Button();
            this.CryptBTN = new System.Windows.Forms.Button();
            this.OutputTB = new System.Windows.Forms.TextBox();
            this.KeyTB = new System.Windows.Forms.TextBox();
            this.DeCryptBTN = new System.Windows.Forms.Button();
            this.DecryptedTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // InputTB
            // 
            this.InputTB.Location = new System.Drawing.Point(12, 12);
            this.InputTB.Multiline = true;
            this.InputTB.Name = "InputTB";
            this.InputTB.Size = new System.Drawing.Size(560, 96);
            this.InputTB.TabIndex = 0;
            // 
            // AvailableInstructionsLB
            // 
            this.AvailableInstructionsLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AvailableInstructionsLB.FormattingEnabled = true;
            this.AvailableInstructionsLB.ItemHeight = 20;
            this.AvailableInstructionsLB.Items.AddRange(new object[] {
            "Inc(+1)",
            "Dec(-1)",
            "Zero(0)"});
            this.AvailableInstructionsLB.Location = new System.Drawing.Point(13, 115);
            this.AvailableInstructionsLB.Name = "AvailableInstructionsLB";
            this.AvailableInstructionsLB.Size = new System.Drawing.Size(163, 104);
            this.AvailableInstructionsLB.TabIndex = 1;
            this.AvailableInstructionsLB.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.AvailableInstructionsLB_MouseDoubleClick);
            // 
            // AddBTN
            // 
            this.AddBTN.Location = new System.Drawing.Point(182, 114);
            this.AddBTN.Name = "AddBTN";
            this.AddBTN.Size = new System.Drawing.Size(84, 47);
            this.AddBTN.TabIndex = 2;
            this.AddBTN.Text = "+";
            this.AddBTN.UseVisualStyleBackColor = true;
            this.AddBTN.Click += new System.EventHandler(this.AddBTN_Click);
            // 
            // RemoveBTN
            // 
            this.RemoveBTN.Location = new System.Drawing.Point(182, 171);
            this.RemoveBTN.Name = "RemoveBTN";
            this.RemoveBTN.Size = new System.Drawing.Size(84, 47);
            this.RemoveBTN.TabIndex = 3;
            this.RemoveBTN.Text = "-";
            this.RemoveBTN.UseVisualStyleBackColor = true;
            this.RemoveBTN.Click += new System.EventHandler(this.RemoveBTN_Click);
            // 
            // ActualInstructionsLB
            // 
            this.ActualInstructionsLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ActualInstructionsLB.FormattingEnabled = true;
            this.ActualInstructionsLB.ItemHeight = 20;
            this.ActualInstructionsLB.Location = new System.Drawing.Point(272, 115);
            this.ActualInstructionsLB.Name = "ActualInstructionsLB";
            this.ActualInstructionsLB.Size = new System.Drawing.Size(208, 104);
            this.ActualInstructionsLB.TabIndex = 4;
            this.ActualInstructionsLB.DoubleClick += new System.EventHandler(this.ActualInstructionsLB_DoubleClick);
            // 
            // UpBTN
            // 
            this.UpBTN.Location = new System.Drawing.Point(486, 115);
            this.UpBTN.Name = "UpBTN";
            this.UpBTN.Size = new System.Drawing.Size(84, 47);
            this.UpBTN.TabIndex = 5;
            this.UpBTN.Text = "Up";
            this.UpBTN.UseVisualStyleBackColor = true;
            this.UpBTN.Click += new System.EventHandler(this.UpBTN_Click);
            // 
            // DownBTN
            // 
            this.DownBTN.Location = new System.Drawing.Point(486, 171);
            this.DownBTN.Name = "DownBTN";
            this.DownBTN.Size = new System.Drawing.Size(84, 47);
            this.DownBTN.TabIndex = 6;
            this.DownBTN.Text = "Down";
            this.DownBTN.UseVisualStyleBackColor = true;
            this.DownBTN.Click += new System.EventHandler(this.DownBTN_Click);
            // 
            // CryptBTN
            // 
            this.CryptBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.CryptBTN.Location = new System.Drawing.Point(182, 224);
            this.CryptBTN.Name = "CryptBTN";
            this.CryptBTN.Size = new System.Drawing.Size(207, 47);
            this.CryptBTN.TabIndex = 7;
            this.CryptBTN.Text = "Шифровать";
            this.CryptBTN.UseVisualStyleBackColor = true;
            this.CryptBTN.Click += new System.EventHandler(this.CryptBTN_Click);
            // 
            // OutputTB
            // 
            this.OutputTB.Location = new System.Drawing.Point(14, 277);
            this.OutputTB.Multiline = true;
            this.OutputTB.Name = "OutputTB";
            this.OutputTB.Size = new System.Drawing.Size(560, 96);
            this.OutputTB.TabIndex = 8;
            // 
            // KeyTB
            // 
            this.KeyTB.Location = new System.Drawing.Point(14, 379);
            this.KeyTB.Multiline = true;
            this.KeyTB.Name = "KeyTB";
            this.KeyTB.Size = new System.Drawing.Size(560, 34);
            this.KeyTB.TabIndex = 9;
            // 
            // DeCryptBTN
            // 
            this.DeCryptBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.DeCryptBTN.Location = new System.Drawing.Point(182, 419);
            this.DeCryptBTN.Name = "DeCryptBTN";
            this.DeCryptBTN.Size = new System.Drawing.Size(207, 47);
            this.DeCryptBTN.TabIndex = 10;
            this.DeCryptBTN.Text = "Расшифровать";
            this.DeCryptBTN.UseVisualStyleBackColor = true;
            this.DeCryptBTN.Click += new System.EventHandler(this.DeCryptBTN_Click);
            // 
            // DecryptedTB
            // 
            this.DecryptedTB.Location = new System.Drawing.Point(14, 472);
            this.DecryptedTB.Multiline = true;
            this.DecryptedTB.Name = "DecryptedTB";
            this.DecryptedTB.Size = new System.Drawing.Size(560, 96);
            this.DecryptedTB.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 567);
            this.Controls.Add(this.DecryptedTB);
            this.Controls.Add(this.DeCryptBTN);
            this.Controls.Add(this.KeyTB);
            this.Controls.Add(this.OutputTB);
            this.Controls.Add(this.CryptBTN);
            this.Controls.Add(this.DownBTN);
            this.Controls.Add(this.UpBTN);
            this.Controls.Add(this.ActualInstructionsLB);
            this.Controls.Add(this.RemoveBTN);
            this.Controls.Add(this.AddBTN);
            this.Controls.Add(this.AvailableInstructionsLB);
            this.Controls.Add(this.InputTB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputTB;
        private System.Windows.Forms.ListBox AvailableInstructionsLB;
        private System.Windows.Forms.Button AddBTN;
        private System.Windows.Forms.Button RemoveBTN;
        private System.Windows.Forms.ListBox ActualInstructionsLB;
        private System.Windows.Forms.Button UpBTN;
        private System.Windows.Forms.Button DownBTN;
        private System.Windows.Forms.Button CryptBTN;
        private System.Windows.Forms.TextBox OutputTB;
        private System.Windows.Forms.TextBox KeyTB;
        private System.Windows.Forms.Button DeCryptBTN;
        private System.Windows.Forms.TextBox DecryptedTB;
    }
}

