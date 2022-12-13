
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.addLink = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.deleteLink = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.editBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.selectLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.downBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.upBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.gridViewMain = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.nextLink = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // addLink
            // 
            this.addLink.Location = new System.Drawing.Point(1033, 34);
            this.addLink.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addLink.Name = "addLink";
            this.addLink.Size = new System.Drawing.Size(101, 33);
            this.addLink.TabIndex = 21;
            this.addLink.Values.Text = "Add Link";
            this.addLink.Click += new System.EventHandler(this.addLink_Click);
            // 
            // deleteLink
            // 
            this.deleteLink.Location = new System.Drawing.Point(1042, 608);
            this.deleteLink.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteLink.Name = "deleteLink";
            this.deleteLink.Size = new System.Drawing.Size(92, 34);
            this.deleteLink.TabIndex = 22;
            this.deleteLink.Values.Text = "Delete";
            this.deleteLink.Click += new System.EventHandler(this.deleteLink_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(933, 608);
            this.editBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(92, 34);
            this.editBtn.TabIndex = 23;
            this.editBtn.Values.Text = "Edit";
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // selectLabel
            // 
            this.selectLabel.Location = new System.Drawing.Point(828, 616);
            this.selectLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(85, 26);
            this.selectLabel.TabIndex = 24;
            this.selectLabel.Values.Text = "0 selected";
            this.selectLabel.Paint += new System.Windows.Forms.PaintEventHandler(this.selectLabel_Paint);
            // 
            // downBtn
            // 
            this.downBtn.Location = new System.Drawing.Point(122, 592);
            this.downBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.downBtn.Name = "downBtn";
            this.downBtn.Size = new System.Drawing.Size(57, 50);
            this.downBtn.TabIndex = 25;
            this.downBtn.Values.Text = "▼";
            this.downBtn.Click += new System.EventHandler(this.downBtn_Click);
            // 
            // upBtn
            // 
            this.upBtn.Location = new System.Drawing.Point(59, 592);
            this.upBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.upBtn.Name = "upBtn";
            this.upBtn.Size = new System.Drawing.Size(57, 50);
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
            this.gridViewMain.RowHeadersWidth = 10;
            this.gridViewMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewMain.Size = new System.Drawing.Size(1075, 496);
            this.gridViewMain.TabIndex = 27;
            this.gridViewMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewMain_ItemClick);
            this.gridViewMain.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewMain_DoubleClick);
            // 
            // nextLink
            // 
            this.nextLink.Location = new System.Drawing.Point(544, 616);
            this.nextLink.Name = "nextLink";
            this.nextLink.Size = new System.Drawing.Size(20, 26);
            this.nextLink.TabIndex = 29;
            this.nextLink.Values.Text = "T";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 675);
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
            this.Name = "Form1";
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
    }
}

