namespace Sales_management_software.PL
{
    partial class FRM_Cat
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
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition2 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement2 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            this.colCAT_Name = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colCAT_Cover = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_search = new DevExpress.XtraEditors.SimpleButton();
            this.edt_search = new System.Windows.Forms.TextBox();
            this.btn_update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_edit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.pn_cat = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tileView1 = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.colID = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.tBCATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.pn_cat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBCATBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // colCAT_Name
            // 
            this.colCAT_Name.FieldName = "CAT_Name";
            this.colCAT_Name.MinWidth = 25;
            this.colCAT_Name.Name = "colCAT_Name";
            this.colCAT_Name.Visible = true;
            this.colCAT_Name.VisibleIndex = 1;
            this.colCAT_Name.Width = 94;
            // 
            // colCAT_Cover
            // 
            this.colCAT_Cover.FieldName = "CAT_Cover";
            this.colCAT_Cover.MinWidth = 25;
            this.colCAT_Cover.Name = "colCAT_Cover";
            this.colCAT_Cover.Visible = true;
            this.colCAT_Cover.VisibleIndex = 2;
            this.colCAT_Cover.Width = 94;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.edt_search);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.btn_edit);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 593);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 127);
            this.panel1.TabIndex = 2;
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btn_search.Appearance.Options.UseFont = true;
            this.btn_search.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_search.ImageOptions.SvgImage = global::Sales_management_software.Properties.Resources.actions_zoom;
            this.btn_search.Location = new System.Drawing.Point(946, 24);
            this.btn_search.Margin = new System.Windows.Forms.Padding(5);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(49, 34);
            this.btn_search.TabIndex = 11;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // edt_search
            // 
            this.edt_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.edt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.edt_search.Location = new System.Drawing.Point(553, 24);
            this.edt_search.Name = "edt_search";
            this.edt_search.Size = new System.Drawing.Size(385, 34);
            this.edt_search.TabIndex = 10;
            // 
            // btn_update
            // 
            this.btn_update.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_update.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btn_update.Appearance.Options.UseFont = true;
            this.btn_update.ImageOptions.Image = global::Sales_management_software.Properties.Resources.refreshallpivottable_32x32;
            this.btn_update.Location = new System.Drawing.Point(379, 14);
            this.btn_update.Margin = new System.Windows.Forms.Padding(5);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(122, 61);
            this.btn_update.TabIndex = 9;
            this.btn_update.Text = "Update";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_edit.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btn_edit.Appearance.Options.UseFont = true;
            this.btn_edit.ImageOptions.Image = global::Sales_management_software.Properties.Resources.edit_32x32;
            this.btn_edit.Location = new System.Drawing.Point(135, 14);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(5);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(111, 61);
            this.btn_edit.TabIndex = 8;
            this.btn_edit.Text = "Edit";
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_delete.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btn_delete.Appearance.Options.UseFont = true;
            this.btn_delete.ImageOptions.Image = global::Sales_management_software.Properties.Resources.removepivotfield_32x32;
            this.btn_delete.Location = new System.Drawing.Point(256, 14);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(5);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(113, 61);
            this.btn_delete.TabIndex = 7;
            this.btn_delete.Text = "Delete";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_add.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.ImageOptions.Image = global::Sales_management_software.Properties.Resources.addfile_32x32;
            this.btn_add.Location = new System.Drawing.Point(13, 14);
            this.btn_add.Margin = new System.Windows.Forms.Padding(5);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(112, 61);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Add";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // pn_cat
            // 
            this.pn_cat.Controls.Add(this.gridControl1);
            this.pn_cat.Controls.Add(this.panel1);
            this.pn_cat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_cat.Location = new System.Drawing.Point(0, 0);
            this.pn_cat.Name = "pn_cat";
            this.pn_cat.Size = new System.Drawing.Size(1030, 720);
            this.pn_cat.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(Sales_management_software.DB.TB_CAT);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.tileView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1030, 593);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileView1});
            // 
            // tileView1
            // 
            this.tileView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colCAT_Name,
            this.colCAT_Cover});
            this.tileView1.GridControl = this.gridControl1;
            this.tileView1.Name = "tileView1";
            this.tileView1.OptionsTiles.ItemSize = new System.Drawing.Size(270, 262);
            this.tileView1.OptionsTiles.RowCount = 0;
            this.tileView1.TileColumns.Add(tableColumnDefinition1);
            tableRowDefinition1.Length.Value = 57D;
            tableRowDefinition2.Length.Value = 185D;
            this.tileView1.TileRows.Add(tableRowDefinition1);
            this.tileView1.TileRows.Add(tableRowDefinition2);
            tileViewItemElement1.Column = this.colCAT_Name;
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement1.Text = "colCAT_Name";
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.Column = this.colCAT_Cover;
            tileViewItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement2.RowIndex = 1;
            tileViewItemElement2.Text = "colCAT_Cover";
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileView1.TileTemplate.Add(tileViewItemElement1);
            this.tileView1.TileTemplate.Add(tileViewItemElement2);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 25;
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 94;
            // 
            // tBCATBindingSource
            // 
            this.tBCATBindingSource.DataMember = "TB_CAT";
            // 
            // FRM_Cat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1030, 720);
            this.Controls.Add(this.pn_cat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Cat";
            this.Text = "FRM_Cat";
            this.Load += new System.EventHandler(this.FRM_Cat_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pn_cat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBCATBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btn_search;
        private System.Windows.Forms.TextBox edt_search;
        private DevExpress.XtraEditors.SimpleButton btn_update;
        private DevExpress.XtraEditors.SimpleButton btn_edit;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.SimpleButton btn_add;
        public System.Windows.Forms.Panel pn_cat;
        private DevExpress.XtraGrid.Views.Tile.TileView tileView1;
        public DevExpress.XtraGrid.GridControl gridControl1;

        private System.Windows.Forms.BindingSource tBCATBindingSource;
        private DevExpress.XtraGrid.Columns.TileViewColumn colID;
        private DevExpress.XtraGrid.Columns.TileViewColumn colCAT_Name;
        private DevExpress.XtraGrid.Columns.TileViewColumn colCAT_Cover;
    }
}