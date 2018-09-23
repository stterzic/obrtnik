namespace Modules.Editors
{
    partial class ObrtPodaci
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnPickImage = new DevExpress.XtraEditors.SimpleButton();
            this.txtImagePath = new DevExpress.XtraEditors.TextEdit();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.obrtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtDjelatnost = new DevExpress.XtraEditors.TextEdit();
            this.txtBanka = new DevExpress.XtraEditors.TextEdit();
            this.txtIban = new DevExpress.XtraEditors.TextEdit();
            this.txtOib = new DevExpress.XtraEditors.TextEdit();
            this.txtAdresa = new DevExpress.XtraEditors.TextEdit();
            this.txtVlasnik = new DevExpress.XtraEditors.TextEdit();
            this.txtNazivObrta = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtImagePath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obrtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDjelatnost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBanka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIban.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOib.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdresa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVlasnik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNazivObrta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnPickImage);
            this.layoutControl1.Controls.Add(this.txtImagePath);
            this.layoutControl1.Controls.Add(this.logoPictureBox);
            this.layoutControl1.Controls.Add(this.btnSave);
            this.layoutControl1.Controls.Add(this.txtDjelatnost);
            this.layoutControl1.Controls.Add(this.txtBanka);
            this.layoutControl1.Controls.Add(this.txtIban);
            this.layoutControl1.Controls.Add(this.txtOib);
            this.layoutControl1.Controls.Add(this.txtAdresa);
            this.layoutControl1.Controls.Add(this.txtVlasnik);
            this.layoutControl1.Controls.Add(this.txtNazivObrta);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(410, 234, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(800, 478);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnPickImage
            // 
            this.btnPickImage.Location = new System.Drawing.Point(712, 278);
            this.btnPickImage.Name = "btnPickImage";
            this.btnPickImage.Size = new System.Drawing.Size(76, 22);
            this.btnPickImage.StyleController = this.layoutControl1;
            this.btnPickImage.TabIndex = 14;
            this.btnPickImage.Text = "Browse";
            this.btnPickImage.Click += new System.EventHandler(this.btnPickImage_Click);
            // 
            // txtImagePath
            // 
            this.txtImagePath.Location = new System.Drawing.Point(74, 278);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.Size = new System.Drawing.Size(634, 20);
            this.txtImagePath.StyleController = this.layoutControl1;
            this.txtImagePath.TabIndex = 13;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackColor = System.Drawing.Color.White;
            this.logoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.obrtBindingSource, "Logo", true));
            this.logoPictureBox.Location = new System.Drawing.Point(12, 320);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(776, 118);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 12;
            this.logoPictureBox.TabStop = false;
            // 
            // obrtBindingSource
            // 
            this.obrtBindingSource.DataSource = typeof(Library.Obrt);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(673, 442);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 22);
            this.btnSave.StyleController = this.layoutControl1;
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Spremi";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDjelatnost
            // 
            this.txtDjelatnost.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.obrtBindingSource, "Djelatnost", true));
            this.txtDjelatnost.Location = new System.Drawing.Point(74, 156);
            this.txtDjelatnost.Name = "txtDjelatnost";
            this.txtDjelatnost.Size = new System.Drawing.Size(714, 20);
            this.txtDjelatnost.StyleController = this.layoutControl1;
            this.txtDjelatnost.TabIndex = 10;
            // 
            // txtBanka
            // 
            this.txtBanka.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.obrtBindingSource, "Banka", true));
            this.txtBanka.Location = new System.Drawing.Point(74, 132);
            this.txtBanka.Name = "txtBanka";
            this.txtBanka.Size = new System.Drawing.Size(714, 20);
            this.txtBanka.StyleController = this.layoutControl1;
            this.txtBanka.TabIndex = 9;
            // 
            // txtIban
            // 
            this.txtIban.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.obrtBindingSource, "Iban", true));
            this.txtIban.Location = new System.Drawing.Point(74, 108);
            this.txtIban.Name = "txtIban";
            this.txtIban.Size = new System.Drawing.Size(714, 20);
            this.txtIban.StyleController = this.layoutControl1;
            this.txtIban.TabIndex = 8;
            // 
            // txtOib
            // 
            this.txtOib.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.obrtBindingSource, "Oib", true));
            this.txtOib.Location = new System.Drawing.Point(74, 84);
            this.txtOib.Name = "txtOib";
            this.txtOib.Size = new System.Drawing.Size(714, 20);
            this.txtOib.StyleController = this.layoutControl1;
            this.txtOib.TabIndex = 7;
            // 
            // txtAdresa
            // 
            this.txtAdresa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.obrtBindingSource, "Adresa", true));
            this.txtAdresa.Location = new System.Drawing.Point(74, 60);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(714, 20);
            this.txtAdresa.StyleController = this.layoutControl1;
            this.txtAdresa.TabIndex = 6;
            // 
            // txtVlasnik
            // 
            this.txtVlasnik.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.obrtBindingSource, "Vlasnik", true));
            this.txtVlasnik.Location = new System.Drawing.Point(74, 36);
            this.txtVlasnik.Name = "txtVlasnik";
            this.txtVlasnik.Size = new System.Drawing.Size(714, 20);
            this.txtVlasnik.StyleController = this.layoutControl1;
            this.txtVlasnik.TabIndex = 5;
            // 
            // txtNazivObrta
            // 
            this.txtNazivObrta.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.obrtBindingSource, "NazivObrta", true));
            this.txtNazivObrta.Location = new System.Drawing.Point(74, 12);
            this.txtNazivObrta.Name = "txtNazivObrta";
            this.txtNazivObrta.Size = new System.Drawing.Size(714, 20);
            this.txtNazivObrta.StyleController = this.layoutControl1;
            this.txtNazivObrta.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem9,
            this.emptySpaceItem2,
            this.layoutControlItem1,
            this.layoutControlItem10,
            this.layoutControlItem11});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(800, 478);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 168);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(780, 98);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(780, 98);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(780, 98);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtNazivObrta;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(780, 24);
            this.layoutControlItem2.Text = "Naziv obrta:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(59, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtVlasnik;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(780, 24);
            this.layoutControlItem3.Text = "Vlasnik:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(59, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtAdresa;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(780, 24);
            this.layoutControlItem4.Text = "Adresa:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(59, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtOib;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(780, 24);
            this.layoutControlItem5.Text = "OIB:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(59, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtIban;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(780, 24);
            this.layoutControlItem6.Text = "IBAN:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(59, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtBanka;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(780, 24);
            this.layoutControlItem7.Text = "Banka:";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(59, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txtDjelatnost;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 144);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(780, 24);
            this.layoutControlItem8.Text = "Djelatnost:";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(59, 13);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.btnSave;
            this.layoutControlItem9.Location = new System.Drawing.Point(661, 430);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(119, 28);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 430);
            this.emptySpaceItem2.MaxSize = new System.Drawing.Size(661, 28);
            this.emptySpaceItem2.MinSize = new System.Drawing.Size(661, 28);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(661, 28);
            this.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.logoPictureBox;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 292);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(780, 138);
            this.layoutControlItem1.Text = "Logo";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(59, 13);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.txtImagePath;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 266);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(700, 26);
            this.layoutControlItem10.Text = "Logo path";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(59, 13);
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.btnPickImage;
            this.layoutControlItem11.Location = new System.Drawing.Point(700, 266);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(80, 26);
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextVisible = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // ObrtPodaci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.layoutControl1);
            this.Name = "ObrtPodaci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Obrt podaci";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtImagePath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obrtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDjelatnost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBanka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIban.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOib.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdresa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVlasnik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNazivObrta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtDjelatnost;
        private DevExpress.XtraEditors.TextEdit txtBanka;
        private DevExpress.XtraEditors.TextEdit txtIban;
        private DevExpress.XtraEditors.TextEdit txtOib;
        private DevExpress.XtraEditors.TextEdit txtAdresa;
        private DevExpress.XtraEditors.TextEdit txtVlasnik;
        private DevExpress.XtraEditors.TextEdit txtNazivObrta;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private System.Windows.Forms.BindingSource obrtBindingSource;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btnPickImage;
        private DevExpress.XtraEditors.TextEdit txtImagePath;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
    }
}