namespace TrackMyTime
{
    partial class DataForm
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
            this.hoursCompletedInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.submitButton = new System.Windows.Forms.Button();
            this.hoursAccruedValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.lastUpdatedBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hoursCompletedInput
            // 
            this.hoursCompletedInput.Location = new System.Drawing.Point(23, 40);
            this.hoursCompletedInput.Name = "hoursCompletedInput";
            this.hoursCompletedInput.Size = new System.Drawing.Size(127, 23);
            this.hoursCompletedInput.TabIndex = 0;
            this.hoursCompletedInput.Enter += new System.EventHandler(this.hoursCompletedInput_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter hours completed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "For date";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(184, 40);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker.TabIndex = 3;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(309, 79);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // hoursAccruedValue
            // 
            this.hoursAccruedValue.Enabled = false;
            this.hoursAccruedValue.Location = new System.Drawing.Point(23, 114);
            this.hoursAccruedValue.Name = "hoursAccruedValue";
            this.hoursAccruedValue.Size = new System.Drawing.Size(127, 23);
            this.hoursAccruedValue.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hours accrued";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(184, 117);
            this.ErrorLabel.MaximumSize = new System.Drawing.Size(200, 0);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(97, 15);
            this.ErrorLabel.TabIndex = 7;
            this.ErrorLabel.Text = "<error message>";
            // 
            // lastUpdatedBox
            // 
            this.lastUpdatedBox.Enabled = false;
            this.lastUpdatedBox.Location = new System.Drawing.Point(23, 177);
            this.lastUpdatedBox.Name = "lastUpdatedBox";
            this.lastUpdatedBox.Size = new System.Drawing.Size(127, 23);
            this.lastUpdatedBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Last updated";
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 222);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lastUpdatedBox);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hoursAccruedValue);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hoursCompletedInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DataForm";
            this.Text = "Track My Time";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DataForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox hoursCompletedInput;
        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePicker;
        private Button submitButton;
        private TextBox hoursAccruedValue;
        private Label label3;
        private Label ErrorLabel;
        private TextBox lastUpdatedBox;
        private Label label4;
    }
}