namespace _12M_CaseStudyApp
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lbl_baslangicTarihi = new DevExpress.XtraEditors.LabelControl();
            this.lbl_bitisTarihi = new DevExpress.XtraEditors.LabelControl();
            this.lbl_malKodu = new DevExpress.XtraEditors.LabelControl();
            this.cmbx_malKodu = new DevExpress.XtraEditors.ComboBoxEdit();
            this.datePicker_baslangicTarihi = new System.Windows.Forms.DateTimePicker();
            this.datePicker_bitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.btn_yazdir = new DevExpress.XtraEditors.SimpleButton();
            this.btn_excel = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbx_malKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(131, 130);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(546, 330);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // lbl_baslangicTarihi
            // 
            this.lbl_baslangicTarihi.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_baslangicTarihi.Appearance.Options.UseFont = true;
            this.lbl_baslangicTarihi.Location = new System.Drawing.Point(16, 26);
            this.lbl_baslangicTarihi.Name = "lbl_baslangicTarihi";
            this.lbl_baslangicTarihi.Size = new System.Drawing.Size(104, 16);
            this.lbl_baslangicTarihi.TabIndex = 6;
            this.lbl_baslangicTarihi.Text = "Başlangıç Tarihi:";
            // 
            // lbl_bitisTarihi
            // 
            this.lbl_bitisTarihi.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_bitisTarihi.Appearance.Options.UseFont = true;
            this.lbl_bitisTarihi.Location = new System.Drawing.Point(297, 26);
            this.lbl_bitisTarihi.Name = "lbl_bitisTarihi";
            this.lbl_bitisTarihi.Size = new System.Drawing.Size(71, 16);
            this.lbl_bitisTarihi.TabIndex = 7;
            this.lbl_bitisTarihi.Text = "Bitiş Tarihi:";
            // 
            // lbl_malKodu
            // 
            this.lbl_malKodu.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_malKodu.Appearance.Options.UseFont = true;
            this.lbl_malKodu.Location = new System.Drawing.Point(16, 61);
            this.lbl_malKodu.Name = "lbl_malKodu";
            this.lbl_malKodu.Size = new System.Drawing.Size(92, 16);
            this.lbl_malKodu.TabIndex = 8;
            this.lbl_malKodu.Text = "Mal Kodu/Adı:";
            // 
            // cmbx_malKodu
            // 
            this.cmbx_malKodu.Location = new System.Drawing.Point(114, 60);
            this.cmbx_malKodu.Name = "cmbx_malKodu";
            this.cmbx_malKodu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbx_malKodu.Size = new System.Drawing.Size(317, 20);
            this.cmbx_malKodu.TabIndex = 3;
            this.cmbx_malKodu.SelectedIndexChanged += new System.EventHandler(this.cmbx_malKodu_SelectedIndexChanged);
            this.cmbx_malKodu.TextChanged += new System.EventHandler(this.cmbx_malKodu_TextChanged);
            // 
            // datePicker_baslangicTarihi
            // 
            this.datePicker_baslangicTarihi.Location = new System.Drawing.Point(126, 24);
            this.datePicker_baslangicTarihi.Name = "datePicker_baslangicTarihi";
            this.datePicker_baslangicTarihi.Size = new System.Drawing.Size(156, 21);
            this.datePicker_baslangicTarihi.TabIndex = 1;
            this.datePicker_baslangicTarihi.Value = new System.DateTime(2016, 1, 1, 13, 22, 0, 0);
            this.datePicker_baslangicTarihi.ValueChanged += new System.EventHandler(this.datePicker_baslangicTarihi_ValueChanged);
            // 
            // datePicker_bitisTarihi
            // 
            this.datePicker_bitisTarihi.Location = new System.Drawing.Point(374, 22);
            this.datePicker_bitisTarihi.Name = "datePicker_bitisTarihi";
            this.datePicker_bitisTarihi.Size = new System.Drawing.Size(156, 21);
            this.datePicker_bitisTarihi.TabIndex = 2;
            this.datePicker_bitisTarihi.ValueChanged += new System.EventHandler(this.datePicker_bitisTarihi_ValueChanged);
            // 
            // btn_yazdir
            // 
            this.btn_yazdir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_yazdir.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.btn_yazdir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_yazdir.ImageOptions.Image")));
            this.btn_yazdir.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_yazdir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_yazdir.Location = new System.Drawing.Point(493, 52);
            this.btn_yazdir.Name = "btn_yazdir";
            this.btn_yazdir.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_yazdir.Size = new System.Drawing.Size(37, 38);
            this.btn_yazdir.TabIndex = 4;
            this.btn_yazdir.Click += new System.EventHandler(this.btn_yazdir_Click);
            // 
            // btn_excel
            // 
            this.btn_excel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_excel.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.btn_excel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_excel.ImageOptions.Image")));
            this.btn_excel.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_excel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_excel.Location = new System.Drawing.Point(450, 52);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_excel.Size = new System.Drawing.Size(37, 38);
            this.btn_excel.TabIndex = 9;
            this.btn_excel.Click += new System.EventHandler(this.btn_excel_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cmbx_malKodu);
            this.panelControl1.Controls.Add(this.btn_excel);
            this.panelControl1.Controls.Add(this.lbl_baslangicTarihi);
            this.panelControl1.Controls.Add(this.btn_yazdir);
            this.panelControl1.Controls.Add(this.lbl_bitisTarihi);
            this.panelControl1.Controls.Add(this.datePicker_bitisTarihi);
            this.panelControl1.Controls.Add(this.lbl_malKodu);
            this.panelControl1.Controls.Add(this.datePicker_baslangicTarihi);
            this.panelControl1.Location = new System.Drawing.Point(130, 24);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(547, 100);
            this.panelControl1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 534);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "12M Consulting";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbx_malKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl lbl_baslangicTarihi;
        private DevExpress.XtraEditors.LabelControl lbl_bitisTarihi;
        private DevExpress.XtraEditors.LabelControl lbl_malKodu;
        private DevExpress.XtraEditors.ComboBoxEdit cmbx_malKodu;
        private System.Windows.Forms.DateTimePicker datePicker_baslangicTarihi;
        private System.Windows.Forms.DateTimePicker datePicker_bitisTarihi;
        private DevExpress.XtraEditors.SimpleButton btn_yazdir;
        private DevExpress.XtraEditors.SimpleButton btn_excel;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}

