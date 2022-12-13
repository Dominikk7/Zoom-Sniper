namespace ZoomSniper
{
    partial class Form2
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
            this.nameBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.nameLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.linkBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.linkLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.sBox = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.mBox = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.tBox = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.wBox = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.rBox = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.fBox = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.saBox = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.timePicker = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.cancelBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.saveBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(25, 44);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(133, 29);
            this.nameBox.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.Location = new System.Drawing.Point(25, 12);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(130, 26);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Values.Text = "Name (optional)";
            // 
            // linkBox
            // 
            this.linkBox.Location = new System.Drawing.Point(179, 44);
            this.linkBox.Name = "linkBox";
            this.linkBox.Size = new System.Drawing.Size(245, 29);
            this.linkBox.TabIndex = 2;
            // 
            // linkLabel
            // 
            this.linkLabel.Location = new System.Drawing.Point(179, 12);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(41, 26);
            this.linkLabel.TabIndex = 3;
            this.linkLabel.Values.Text = "Link";
            // 
            // sBox
            // 
            this.sBox.Location = new System.Drawing.Point(441, 47);
            this.sBox.Name = "sBox";
            this.sBox.Size = new System.Drawing.Size(34, 26);
            this.sBox.TabIndex = 4;
            this.sBox.Values.Text = "S";
            // 
            // mBox
            // 
            this.mBox.Location = new System.Drawing.Point(481, 47);
            this.mBox.Name = "mBox";
            this.mBox.Size = new System.Drawing.Size(40, 26);
            this.mBox.TabIndex = 5;
            this.mBox.Values.Text = "M";
            // 
            // tBox
            // 
            this.tBox.Location = new System.Drawing.Point(521, 47);
            this.tBox.Name = "tBox";
            this.tBox.Size = new System.Drawing.Size(33, 26);
            this.tBox.TabIndex = 6;
            this.tBox.Values.Text = "T";
            // 
            // wBox
            // 
            this.wBox.Location = new System.Drawing.Point(561, 47);
            this.wBox.Name = "wBox";
            this.wBox.Size = new System.Drawing.Size(40, 26);
            this.wBox.TabIndex = 7;
            this.wBox.Values.Text = "W";
            // 
            // rBox
            // 
            this.rBox.Location = new System.Drawing.Point(601, 47);
            this.rBox.Name = "rBox";
            this.rBox.Size = new System.Drawing.Size(35, 26);
            this.rBox.TabIndex = 8;
            this.rBox.Values.Text = "R";
            // 
            // fBox
            // 
            this.fBox.Location = new System.Drawing.Point(641, 47);
            this.fBox.Name = "fBox";
            this.fBox.Size = new System.Drawing.Size(33, 26);
            this.fBox.TabIndex = 9;
            this.fBox.Values.Text = "F";
            // 
            // saBox
            // 
            this.saBox.Location = new System.Drawing.Point(681, 47);
            this.saBox.Name = "saBox";
            this.saBox.Size = new System.Drawing.Size(34, 26);
            this.saBox.TabIndex = 10;
            this.saBox.Values.Text = "S";
            // 
            // timePicker
            // 
            this.timePicker.Location = new System.Drawing.Point(722, 47);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(236, 27);
            this.timePicker.TabIndex = 11;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(778, 103);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(79, 37);
            this.cancelBtn.TabIndex = 12;
            this.cancelBtn.Values.Text = "Cancel";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(879, 103);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(79, 37);
            this.saveBtn.TabIndex = 13;
            this.saveBtn.Values.Text = "Save";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 165);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.saBox);
            this.Controls.Add(this.fBox);
            this.Controls.Add(this.rBox);
            this.Controls.Add(this.wBox);
            this.Controls.Add(this.tBox);
            this.Controls.Add(this.mBox);
            this.Controls.Add(this.sBox);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.linkBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameBox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonTextBox nameBox;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel nameLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox linkBox;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel linkLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox sBox;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox mBox;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox tBox;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox wBox;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox rBox;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox fBox;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox saBox;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker timePicker;
        private ComponentFactory.Krypton.Toolkit.KryptonButton cancelBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton saveBtn;
    }
}