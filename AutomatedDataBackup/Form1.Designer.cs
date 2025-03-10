namespace AutomatedDataBackupUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnStart = new Button();
            btnStop = new Button();
            lblStatus = new Label();
            comboBoxFrequency = new ComboBox();
            dateTimePickerTime = new DateTimePicker();
            numericUpDownDayOfWeek = new NumericUpDown();
            numericUpDownDayOfMonth = new NumericUpDown();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDayOfWeek).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDayOfMonth).BeginInit();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.FromArgb(0, 223, 130);
            btnStart.Location = new Point(514, 92);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(221, 127);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start Backup";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.BackColor = Color.FromArgb(0, 223, 130);
            btnStop.Location = new Point(514, 520);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(221, 127);
            btnStop.TabIndex = 1;
            btnStop.Text = "Stop Backup";
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += btnStop_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.White;
            lblStatus.Font = new Font("Segoe UI", 20F);
            lblStatus.Location = new Point(459, 362);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(331, 37);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Status: Waiting for action...";
            // 
            // comboBoxFrequency
            // 
            comboBoxFrequency.FormattingEnabled = true;
            comboBoxFrequency.Items.AddRange(new object[] { "Daily", "Weekly", "Monthly", "Custom" });
            comboBoxFrequency.Location = new Point(53, 37);
            comboBoxFrequency.Name = "comboBoxFrequency";
            comboBoxFrequency.Size = new Size(121, 23);
            comboBoxFrequency.TabIndex = 3;
            // 
            // dateTimePickerTime
            // 
            dateTimePickerTime.Location = new Point(137, 142);
            dateTimePickerTime.Name = "dateTimePickerTime";
            dateTimePickerTime.Size = new Size(200, 23);
            dateTimePickerTime.TabIndex = 4;
            // 
            // numericUpDownDayOfWeek
            // 
            numericUpDownDayOfWeek.Location = new Point(217, 307);
            numericUpDownDayOfWeek.Name = "numericUpDownDayOfWeek";
            numericUpDownDayOfWeek.Size = new Size(120, 23);
            numericUpDownDayOfWeek.TabIndex = 5;
            // 
            // numericUpDownDayOfMonth
            // 
            numericUpDownDayOfMonth.Location = new Point(237, 386);
            numericUpDownDayOfMonth.Name = "numericUpDownDayOfMonth";
            numericUpDownDayOfMonth.Size = new Size(120, 23);
            numericUpDownDayOfMonth.TabIndex = 6;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(0, 223, 130);
            btnCancel.Location = new Point(878, 520);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(221, 127);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1263, 808);
            Controls.Add(btnCancel);
            Controls.Add(numericUpDownDayOfMonth);
            Controls.Add(numericUpDownDayOfWeek);
            Controls.Add(dateTimePickerTime);
            Controls.Add(comboBoxFrequency);
            Controls.Add(lblStatus);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDownDayOfWeek).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDayOfMonth).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private Button btnStop;
        private Label lblStatus;
        private ComboBox comboBoxFrequency;
        private DateTimePicker dateTimePickerTime;
        private NumericUpDown numericUpDownDayOfWeek;
        private NumericUpDown numericUpDownDayOfMonth;
        private Button btnCancel;
    }
}
