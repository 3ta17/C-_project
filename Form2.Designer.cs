namespace AlarmTimer
{
    partial class FormSet
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
            this.radioButtonAlarm = new System.Windows.Forms.RadioButton();
            this.radioButtonTimer = new System.Windows.Forms.RadioButton();
            this.numericUpDownAlmHour = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAlmMnt = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTimMnt = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTimSec = new System.Windows.Forms.NumericUpDown();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlmHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlmMnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimMnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimSec)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonAlarm
            // 
            this.radioButtonAlarm.AutoSize = true;
            this.radioButtonAlarm.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.radioButtonAlarm.Location = new System.Drawing.Point(199, 105);
            this.radioButtonAlarm.Name = "radioButtonAlarm";
            this.radioButtonAlarm.Size = new System.Drawing.Size(109, 34);
            this.radioButtonAlarm.TabIndex = 0;
            this.radioButtonAlarm.TabStop = true;
            this.radioButtonAlarm.Text = "Alarm";
            this.radioButtonAlarm.UseVisualStyleBackColor = true;
            this.radioButtonAlarm.CheckedChanged += new System.EventHandler(this.radioButtonAlarm_CheckedChanged);
            // 
            // radioButtonTimer
            // 
            this.radioButtonTimer.AutoSize = true;
            this.radioButtonTimer.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.radioButtonTimer.Location = new System.Drawing.Point(443, 105);
            this.radioButtonTimer.Name = "radioButtonTimer";
            this.radioButtonTimer.Size = new System.Drawing.Size(109, 34);
            this.radioButtonTimer.TabIndex = 1;
            this.radioButtonTimer.TabStop = true;
            this.radioButtonTimer.Text = "Timer";
            this.radioButtonTimer.UseVisualStyleBackColor = true;
            this.radioButtonTimer.CheckedChanged += new System.EventHandler(this.radioButtonTimer_CheckedChanged);
            // 
            // numericUpDownAlmHour
            // 
            this.numericUpDownAlmHour.Location = new System.Drawing.Point(199, 209);
            this.numericUpDownAlmHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDownAlmHour.Name = "numericUpDownAlmHour";
            this.numericUpDownAlmHour.Size = new System.Drawing.Size(120, 25);
            this.numericUpDownAlmHour.TabIndex = 2;
            this.numericUpDownAlmHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownAlmHour.ValueChanged += new System.EventHandler(this.NumericUpDownAlm_ValueChanged);
            // 
            // numericUpDownAlmMnt
            // 
            this.numericUpDownAlmMnt.Location = new System.Drawing.Point(199, 274);
            this.numericUpDownAlmMnt.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownAlmMnt.Name = "numericUpDownAlmMnt";
            this.numericUpDownAlmMnt.Size = new System.Drawing.Size(120, 25);
            this.numericUpDownAlmMnt.TabIndex = 3;
            this.numericUpDownAlmMnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownAlmMnt.ValueChanged += new System.EventHandler(this.NumericUpDownAlm_ValueChanged);
            // 
            // numericUpDownTimMnt
            // 
            this.numericUpDownTimMnt.Location = new System.Drawing.Point(443, 209);
            this.numericUpDownTimMnt.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownTimMnt.Name = "numericUpDownTimMnt";
            this.numericUpDownTimMnt.Size = new System.Drawing.Size(120, 25);
            this.numericUpDownTimMnt.TabIndex = 4;
            this.numericUpDownTimMnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownTimMnt.ValueChanged += new System.EventHandler(this.numericUpDownTimMnt_ValueChanged);
            // 
            // numericUpDownTimSec
            // 
            this.numericUpDownTimSec.Location = new System.Drawing.Point(443, 274);
            this.numericUpDownTimSec.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownTimSec.Name = "numericUpDownTimSec";
            this.numericUpDownTimSec.Size = new System.Drawing.Size(120, 25);
            this.numericUpDownTimSec.TabIndex = 5;
            this.numericUpDownTimSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownTimSec.ValueChanged += new System.EventHandler(this.numericUpDownTimSec_ValueChanged);
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.MediumBlue;
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.buttonOK.ForeColor = System.Drawing.Color.White;
            this.buttonOK.Location = new System.Drawing.Point(218, 355);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(90, 40);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.MediumBlue;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(462, 355);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(90, 40);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.numericUpDownTimSec);
            this.Controls.Add(this.numericUpDownTimMnt);
            this.Controls.Add(this.numericUpDownAlmMnt);
            this.Controls.Add(this.numericUpDownAlmHour);
            this.Controls.Add(this.radioButtonTimer);
            this.Controls.Add(this.radioButtonAlarm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormSet";
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.FormSet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlmHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlmMnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimMnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimSec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonAlarm;
        private System.Windows.Forms.RadioButton radioButtonTimer;
        private System.Windows.Forms.NumericUpDown numericUpDownAlmHour;
        private System.Windows.Forms.NumericUpDown numericUpDownAlmMnt;
        private System.Windows.Forms.NumericUpDown numericUpDownTimMnt;
        private System.Windows.Forms.NumericUpDown numericUpDownTimSec;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
    }
}