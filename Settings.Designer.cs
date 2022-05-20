namespace Alarm
{
    partial class Settings
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SettingsBox = new System.Windows.Forms.GroupBox();
            this.min_cb = new System.Windows.Forms.ComboBox();
            this.hours_cb = new System.Windows.Forms.ComboBox();
            this.repeat = new System.Windows.Forms.GroupBox();
            this.No = new System.Windows.Forms.RadioButton();
            this.Yes = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.alarm_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SettingsBox.SuspendLayout();
            this.repeat.SuspendLayout();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(13, 13);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(104, 37);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(298, 13);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(104, 37);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(111, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // SettingsBox
            // 
            this.SettingsBox.Controls.Add(this.min_cb);
            this.SettingsBox.Controls.Add(this.hours_cb);
            this.SettingsBox.Controls.Add(this.repeat);
            this.SettingsBox.Controls.Add(this.label4);
            this.SettingsBox.Controls.Add(this.alarm_name);
            this.SettingsBox.Controls.Add(this.label3);
            this.SettingsBox.Controls.Add(this.label2);
            this.SettingsBox.Controls.Add(this.label1);
            this.SettingsBox.Location = new System.Drawing.Point(64, 290);
            this.SettingsBox.Name = "SettingsBox";
            this.SettingsBox.Size = new System.Drawing.Size(247, 197);
            this.SettingsBox.TabIndex = 3;
            this.SettingsBox.TabStop = false;
            this.SettingsBox.Text = "Настройки:";
            // 
            // min_cb
            // 
            this.min_cb.FormattingEnabled = true;
            this.min_cb.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "10",
            "11",
            "12"});
            this.min_cb.Location = new System.Drawing.Point(143, 21);
            this.min_cb.Name = "min_cb";
            this.min_cb.Size = new System.Drawing.Size(48, 24);
            this.min_cb.TabIndex = 9;
            // 
            // hours_cb
            // 
            this.hours_cb.FormattingEnabled = true;
            this.hours_cb.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.hours_cb.Location = new System.Drawing.Point(70, 22);
            this.hours_cb.Name = "hours_cb";
            this.hours_cb.Size = new System.Drawing.Size(51, 24);
            this.hours_cb.TabIndex = 8;
            // 
            // repeat
            // 
            this.repeat.Controls.Add(this.No);
            this.repeat.Controls.Add(this.Yes);
            this.repeat.Location = new System.Drawing.Point(16, 95);
            this.repeat.Name = "repeat";
            this.repeat.Size = new System.Drawing.Size(205, 77);
            this.repeat.TabIndex = 7;
            this.repeat.TabStop = false;
            this.repeat.Text = "Повтор сигнала:";
            // 
            // No
            // 
            this.No.AutoSize = true;
            this.No.Location = new System.Drawing.Point(14, 48);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(53, 20);
            this.No.TabIndex = 1;
            this.No.TabStop = true;
            this.No.Text = "Нет";
            this.No.UseVisualStyleBackColor = true;
            // 
            // Yes
            // 
            this.Yes.AutoSize = true;
            this.Yes.Location = new System.Drawing.Point(14, 22);
            this.Yes.Name = "Yes";
            this.Yes.Size = new System.Drawing.Size(45, 20);
            this.Yes.TabIndex = 0;
            this.Yes.TabStop = true;
            this.Yes.Text = "Да";
            this.Yes.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 6;
            // 
            // alarm_name
            // 
            this.alarm_name.Location = new System.Drawing.Point(95, 58);
            this.alarm_name.Name = "alarm_name";
            this.alarm_name.Size = new System.Drawing.Size(126, 22);
            this.alarm_name.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Название:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Время:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = ":";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 525);
            this.Controls.Add(this.SettingsBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CancelButton);
            this.Name = "Settings";
            this.Text = " Добавить";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.SettingsBox.ResumeLayout(false);
            this.SettingsBox.PerformLayout();
            this.repeat.ResumeLayout(false);
            this.repeat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox SettingsBox;
        private System.Windows.Forms.GroupBox repeat;
        private System.Windows.Forms.RadioButton No;
        private System.Windows.Forms.RadioButton Yes;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox alarm_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox min_cb;
        public System.Windows.Forms.ComboBox hours_cb;
    }
}