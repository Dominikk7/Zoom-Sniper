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
            this.components = new System.ComponentModel.Container();
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
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(25, 44);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(133, 27);
            this.nameBox.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.Location = new System.Drawing.Point(19, 12);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Palette = this.kryptonPalette1;
            this.nameLabel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.nameLabel.Size = new System.Drawing.Size(154, 23);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Values.Text = "Name (optional)";
            // 
            // linkBox
            // 
            this.linkBox.Location = new System.Drawing.Point(179, 44);
            this.linkBox.Name = "linkBox";
            this.linkBox.Size = new System.Drawing.Size(245, 27);
            this.linkBox.TabIndex = 2;
            // 
            // linkLabel
            // 
            this.linkLabel.Location = new System.Drawing.Point(179, 12);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Palette = this.kryptonPalette1;
            this.linkLabel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.linkLabel.Size = new System.Drawing.Size(50, 23);
            this.linkLabel.TabIndex = 3;
            this.linkLabel.Values.Text = "Link";
            // 
            // sBox
            // 
            this.sBox.Location = new System.Drawing.Point(434, 48);
            this.sBox.Name = "sBox";
            this.sBox.Palette = this.kryptonPalette1;
            this.sBox.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.sBox.Size = new System.Drawing.Size(34, 23);
            this.sBox.TabIndex = 4;
            this.sBox.Values.Text = "S";
            // 
            // mBox
            // 
            this.mBox.Location = new System.Drawing.Point(490, 48);
            this.mBox.Name = "mBox";
            this.mBox.Palette = this.kryptonPalette1;
            this.mBox.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.mBox.Size = new System.Drawing.Size(34, 23);
            this.mBox.TabIndex = 5;
            this.mBox.Values.Text = "M";
            // 
            // tBox
            // 
            this.tBox.Location = new System.Drawing.Point(543, 48);
            this.tBox.Name = "tBox";
            this.tBox.Palette = this.kryptonPalette1;
            this.tBox.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.tBox.Size = new System.Drawing.Size(34, 23);
            this.tBox.TabIndex = 6;
            this.tBox.Values.Text = "T";
            // 
            // wBox
            // 
            this.wBox.Location = new System.Drawing.Point(597, 48);
            this.wBox.Name = "wBox";
            this.wBox.Palette = this.kryptonPalette1;
            this.wBox.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.wBox.Size = new System.Drawing.Size(34, 23);
            this.wBox.TabIndex = 7;
            this.wBox.Values.Text = "W";
            // 
            // rBox
            // 
            this.rBox.Location = new System.Drawing.Point(648, 48);
            this.rBox.Name = "rBox";
            this.rBox.Palette = this.kryptonPalette1;
            this.rBox.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.rBox.Size = new System.Drawing.Size(34, 23);
            this.rBox.TabIndex = 8;
            this.rBox.Values.Text = "R";
            // 
            // fBox
            // 
            this.fBox.Location = new System.Drawing.Point(701, 48);
            this.fBox.Name = "fBox";
            this.fBox.Palette = this.kryptonPalette1;
            this.fBox.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.fBox.Size = new System.Drawing.Size(34, 23);
            this.fBox.TabIndex = 9;
            this.fBox.Values.Text = "F";
            // 
            // saBox
            // 
            this.saBox.Location = new System.Drawing.Point(756, 48);
            this.saBox.Name = "saBox";
            this.saBox.Palette = this.kryptonPalette1;
            this.saBox.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.saBox.Size = new System.Drawing.Size(34, 23);
            this.saBox.TabIndex = 10;
            this.saBox.Values.Text = "S";
            // 
            // timePicker
            // 
            this.timePicker.Location = new System.Drawing.Point(806, 46);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(146, 25);
            this.timePicker.TabIndex = 11;
            // 
            // cancelBtn
            // 
            this.cancelBtn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom1;
            this.cancelBtn.Location = new System.Drawing.Point(860, 119);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Palette = this.kryptonPalette1;
            this.cancelBtn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.cancelBtn.Size = new System.Drawing.Size(92, 34);
            this.cancelBtn.TabIndex = 12;
            this.cancelBtn.Values.Text = "Cancel";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom1;
            this.saveBtn.Location = new System.Drawing.Point(762, 119);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Palette = this.kryptonPalette1;
            this.saveBtn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.saveBtn.Size = new System.Drawing.Size(92, 34);
            this.saveBtn.TabIndex = 13;
            this.saveBtn.Values.Text = "Save";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(203)))), ((int)(((byte)(97)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(203)))), ((int)(((byte)(97)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(203)))), ((int)(((byte)(97)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(203)))), ((int)(((byte)(97)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Cascadia Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateNormal.Border.Rounding = 4;
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(148)))), ((int)(((byte)(71)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(148)))), ((int)(((byte)(71)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StatePressed.Border.Rounding = 4;
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(238)))), ((int)(((byte)(151)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(238)))), ((int)(((byte)(151)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateTracking.Border.Rounding = 4;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(148)))), ((int)(((byte)(71)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(148)))), ((int)(((byte)(71)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(203)))), ((int)(((byte)(97)))));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(203)))), ((int)(((byte)(97)))));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(148)))), ((int)(((byte)(71)))));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(148)))), ((int)(((byte)(71)))));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.ColorAngle = 1F;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 4;
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.Background.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.DataCell.Back.ColorAngle = 270F;
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.DataCell.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(148)))), ((int)(((byte)(71)))));
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.DataCell.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(148)))), ((int)(((byte)(71)))));
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.DataCell.Border.ColorAngle = 180F;
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.DataCell.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed;
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.DataCell.Content.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(148)))), ((int)(((byte)(71)))));
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(148)))), ((int)(((byte)(71)))));
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.HeaderColumn.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed;
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.HeaderColumn.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.GridStyles.GridCommon.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(203)))), ((int)(((byte)(97)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.ColorAngle = 180F;
            this.kryptonPalette1.LabelStyles.LabelNormalControl.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.LabelStyles.LabelNormalControl.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.LabelStyles.LabelNormalControl.StateCommon.ShortText.Font = new System.Drawing.Font("Cascadia Mono", 9.4F);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(977, 165);
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
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
    }
}