
namespace ZoomSniper
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.addLink = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.deleteLink = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.editBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.selectLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.downBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.upBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.gridViewMain = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.nextLink = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.updateBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // addLink
            // 
            this.addLink.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom1;
            this.addLink.Location = new System.Drawing.Point(1017, 37);
            this.addLink.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addLink.Name = "addLink";
            this.addLink.Palette = this.kryptonPalette1;
            this.addLink.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.addLink.Size = new System.Drawing.Size(117, 44);
            this.addLink.TabIndex = 21;
            this.addLink.Values.Text = "Add Link";
            this.addLink.Click += new System.EventHandler(this.addLink_Click);
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(203)))), ((int)(((byte)(97)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(203)))), ((int)(((byte)(97)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.OverrideDefault.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(203)))), ((int)(((byte)(97)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(203)))), ((int)(((byte)(97)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Cascadia Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateNormal.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateNormal.Border.Rounding = 4;
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(148)))), ((int)(((byte)(71)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(148)))), ((int)(((byte)(71)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StatePressed.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StatePressed.Border.Rounding = 4;
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(238)))), ((int)(((byte)(151)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(238)))), ((int)(((byte)(151)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateTracking.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateTracking.Border.Rounding = 4;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(148)))), ((int)(((byte)(71)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(148)))), ((int)(((byte)(71)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(203)))), ((int)(((byte)(97)))));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(203)))), ((int)(((byte)(97)))));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.OverrideDefault.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(148)))), ((int)(((byte)(71)))));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(148)))), ((int)(((byte)(71)))));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.ColorAngle = 1F;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 4;
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.Background.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.Background.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.DataCell.Back.ColorAngle = 270F;
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.DataCell.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.DataCell.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(148)))), ((int)(((byte)(71)))));
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.DataCell.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(148)))), ((int)(((byte)(71)))));
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.DataCell.Border.ColorAngle = 180F;
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.DataCell.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed;
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.DataCell.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.DataCell.Content.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.DataCell.Content.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.DataCell.Content.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.HeaderColumn.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(148)))), ((int)(((byte)(71)))));
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(148)))), ((int)(((byte)(71)))));
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.HeaderColumn.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed;
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.HeaderColumn.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.HeaderColumn.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.HeaderColumn.Content.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.HeaderColumn.Content.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.HeaderRow.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette1.GridStyles.GridCommon.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(203)))), ((int)(((byte)(97)))));
            this.kryptonPalette1.GridStyles.GridCommon.StateSelected.DataCell.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.ColorAngle = 180F;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette1.LabelStyles.LabelNormalControl.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.LabelStyles.LabelNormalControl.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.LabelStyles.LabelNormalControl.StateCommon.ShortText.Font = new System.Drawing.Font("Cascadia Mono", 9.4F);
            this.kryptonPalette1.LabelStyles.LabelNormalControl.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette1.LabelStyles.LabelNormalControl.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            // 
            // deleteLink
            // 
            this.deleteLink.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom1;
            this.deleteLink.Location = new System.Drawing.Point(1042, 598);
            this.deleteLink.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteLink.Name = "deleteLink";
            this.deleteLink.Palette = this.kryptonPalette1;
            this.deleteLink.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.deleteLink.Size = new System.Drawing.Size(92, 34);
            this.deleteLink.TabIndex = 22;
            this.deleteLink.Values.Text = "Delete";
            this.deleteLink.Click += new System.EventHandler(this.deleteLink_Click);
            // 
            // editBtn
            // 
            this.editBtn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom1;
            this.editBtn.Location = new System.Drawing.Point(944, 598);
            this.editBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editBtn.Name = "editBtn";
            this.editBtn.Palette = this.kryptonPalette1;
            this.editBtn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.editBtn.Size = new System.Drawing.Size(92, 34);
            this.editBtn.TabIndex = 23;
            this.editBtn.Values.Text = "Edit";
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // selectLabel
            // 
            this.selectLabel.Location = new System.Drawing.Point(825, 605);
            this.selectLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Palette = this.kryptonPalette1;
            this.selectLabel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.selectLabel.Size = new System.Drawing.Size(106, 23);
            this.selectLabel.TabIndex = 24;
            this.selectLabel.Values.Text = "0 selected";
            // 
            // downBtn
            // 
            this.downBtn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom1;
            this.downBtn.Location = new System.Drawing.Point(109, 592);
            this.downBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.downBtn.Name = "downBtn";
            this.downBtn.Palette = this.kryptonPalette1;
            this.downBtn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.downBtn.Size = new System.Drawing.Size(44, 44);
            this.downBtn.TabIndex = 25;
            this.downBtn.Values.Text = "▼";
            this.downBtn.Click += new System.EventHandler(this.downBtn_Click);
            // 
            // upBtn
            // 
            this.upBtn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom1;
            this.upBtn.Location = new System.Drawing.Point(59, 592);
            this.upBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.upBtn.Name = "upBtn";
            this.upBtn.Palette = this.kryptonPalette1;
            this.upBtn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.upBtn.Size = new System.Drawing.Size(44, 44);
            this.upBtn.TabIndex = 26;
            this.upBtn.Values.Text = "▲";
            this.upBtn.Click += new System.EventHandler(this.upBtn_Click);
            // 
            // gridViewMain
            // 
            this.gridViewMain.AllowUserToAddRows = false;
            this.gridViewMain.AllowUserToDeleteRows = false;
            this.gridViewMain.AllowUserToResizeColumns = false;
            this.gridViewMain.AllowUserToResizeRows = false;
            this.gridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewMain.Location = new System.Drawing.Point(59, 87);
            this.gridViewMain.Margin = new System.Windows.Forms.Padding(4);
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.Palette = this.kryptonPalette1;
            this.gridViewMain.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.gridViewMain.RowHeadersWidth = 10;
            this.gridViewMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewMain.Size = new System.Drawing.Size(1075, 496);
            this.gridViewMain.TabIndex = 27;
            this.gridViewMain.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewMain_DoubleClick);
            this.gridViewMain.SelectionChanged += new System.EventHandler(this.gridViewMain_SelectChange);
            // 
            // nextLink
            // 
            this.nextLink.AllowDrop = true;
            this.nextLink.Location = new System.Drawing.Point(417, 605);
            this.nextLink.Name = "nextLink";
            this.nextLink.Palette = this.kryptonPalette1;
            this.nextLink.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.nextLink.Size = new System.Drawing.Size(191, 23);
            this.nextLink.TabIndex = 29;
            this.nextLink.Values.Text = "No more links today";
            // 
            // updateBtn
            // 
            this.updateBtn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom1;
            this.updateBtn.Location = new System.Drawing.Point(59, 37);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Palette = this.kryptonPalette1;
            this.updateBtn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.updateBtn.Size = new System.Drawing.Size(205, 44);
            this.updateBtn.StateCommon.Back.Color1 = System.Drawing.Color.LightSkyBlue;
            this.updateBtn.StateCommon.Back.Color2 = System.Drawing.Color.LightSkyBlue;
            this.updateBtn.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.updateBtn.StateNormal.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.updateBtn.StateNormal.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.updateBtn.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.updateBtn.StateTracking.Back.Color1 = System.Drawing.Color.LightSkyBlue;
            this.updateBtn.StateTracking.Back.Color2 = System.Drawing.Color.LightSkyBlue;
            this.updateBtn.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.updateBtn.TabIndex = 30;
            this.updateBtn.Values.Text = "Update Available";
            this.updateBtn.Visible = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1203, 675);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.nextLink);
            this.Controls.Add(this.gridViewMain);
            this.Controls.Add(this.upBtn);
            this.Controls.Add(this.downBtn);
            this.Controls.Add(this.selectLabel);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.deleteLink);
            this.Controls.Add(this.addLink);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1221, 722);
            this.MinimumSize = new System.Drawing.Size(1221, 722);
            this.Name = "Form1";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zoom Sniper";
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button adLinkBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton addLink;
        private ComponentFactory.Krypton.Toolkit.KryptonButton deleteLink;
        private ComponentFactory.Krypton.Toolkit.KryptonButton editBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel selectLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton downBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton upBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gridViewMain;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel nextLink;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton updateBtn;
    }
}

