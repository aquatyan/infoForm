namespace InfoWF
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txbSurname = new System.Windows.Forms.TextBox();
            this.txbPatronymic = new System.Windows.Forms.TextBox();
            this.txbFirstname = new System.Windows.Forms.TextBox();
            this.maskedtxbDate = new System.Windows.Forms.MaskedTextBox();
            this.cbFamily = new System.Windows.Forms.ComboBox();
            this.txbInfo = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txbGender = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(31, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(70, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(28, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(31, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Пол(ж/м)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(31, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Год и дата рождения";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(31, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Семейный статус";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(31, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(245, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Дополнительная информация";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Aquamarine;
            this.btnSave.Location = new System.Drawing.Point(518, 406);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightPink;
            this.btnClear.Location = new System.Drawing.Point(600, 406);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txbSurname
            // 
            this.txbSurname.Location = new System.Drawing.Point(128, 25);
            this.txbSurname.Name = "txbSurname";
            this.txbSurname.Size = new System.Drawing.Size(165, 20);
            this.txbSurname.TabIndex = 0;
            // 
            // txbPatronymic
            // 
            this.txbPatronymic.Location = new System.Drawing.Point(128, 84);
            this.txbPatronymic.Name = "txbPatronymic";
            this.txbPatronymic.Size = new System.Drawing.Size(165, 20);
            this.txbPatronymic.TabIndex = 2;
            // 
            // txbFirstname
            // 
            this.txbFirstname.Location = new System.Drawing.Point(128, 58);
            this.txbFirstname.Name = "txbFirstname";
            this.txbFirstname.Size = new System.Drawing.Size(165, 20);
            this.txbFirstname.TabIndex = 1;
            // 
            // maskedtxbDate
            // 
            this.maskedtxbDate.Location = new System.Drawing.Point(213, 167);
            this.maskedtxbDate.Mask = "00/00/0000";
            this.maskedtxbDate.Name = "maskedtxbDate";
            this.maskedtxbDate.Size = new System.Drawing.Size(100, 20);
            this.maskedtxbDate.TabIndex = 4;
            this.maskedtxbDate.ValidatingType = typeof(System.DateTime);
            // 
            // cbFamily
            // 
            this.cbFamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFamily.FormattingEnabled = true;
            this.cbFamily.Items.AddRange(new object[] {
            "Не замужем/не женат",
            "Разведен/разведена",
            "Женат/замужем",
            "Помолвлен(а)",
            "В гражданском браке"});
            this.cbFamily.Location = new System.Drawing.Point(192, 208);
            this.cbFamily.Name = "cbFamily";
            this.cbFamily.Size = new System.Drawing.Size(121, 21);
            this.cbFamily.TabIndex = 5;
            // 
            // txbInfo
            // 
            this.txbInfo.Location = new System.Drawing.Point(34, 283);
            this.txbInfo.MaxLength = 5000;
            this.txbInfo.Multiline = true;
            this.txbInfo.Name = "txbInfo";
            this.txbInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbInfo.Size = new System.Drawing.Size(628, 97);
            this.txbInfo.TabIndex = 6;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Info|*.txt|All files|*.*";
            // 
            // txbGender
            // 
            this.txbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txbGender.FormattingEnabled = true;
            this.txbGender.Items.AddRange(new object[] {
            "Мужчина",
            "Женщина"});
            this.txbGender.Location = new System.Drawing.Point(128, 118);
            this.txbGender.Name = "txbGender";
            this.txbGender.Size = new System.Drawing.Size(121, 21);
            this.txbGender.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.txbGender);
            this.Controls.Add(this.txbInfo);
            this.Controls.Add(this.cbFamily);
            this.Controls.Add(this.maskedtxbDate);
            this.Controls.Add(this.txbFirstname);
            this.Controls.Add(this.txbPatronymic);
            this.Controls.Add(this.txbSurname);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Info";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txbSurname;
        private System.Windows.Forms.TextBox txbPatronymic;
        private System.Windows.Forms.TextBox txbFirstname;
        private System.Windows.Forms.MaskedTextBox maskedtxbDate;
        private System.Windows.Forms.ComboBox cbFamily;
        private System.Windows.Forms.TextBox txbInfo;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ComboBox txbGender;
    }
}

