namespace yemekrandevu
{
    partial class Rapor
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rapor));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.yemekhanerandevuDataSet1 = new yemekrandevu.yemekhanerandevuDataSet1();
            this.Tbl_KayitlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Tbl_KayitlarTableAdapter = new yemekrandevu.yemekhanerandevuDataSet1TableAdapters.Tbl_KayitlarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.yemekhanerandevuDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_KayitlarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Tbl_KayitlarBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "yemekrandevu.deneme.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(859, 372);
            this.reportViewer1.TabIndex = 0;
            // 
            // yemekhanerandevuDataSet1
            // 
            this.yemekhanerandevuDataSet1.DataSetName = "yemekhanerandevuDataSet1";
            this.yemekhanerandevuDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Tbl_KayitlarBindingSource
            // 
            this.Tbl_KayitlarBindingSource.DataMember = "Tbl_Kayitlar";
            this.Tbl_KayitlarBindingSource.DataSource = this.yemekhanerandevuDataSet1;
            // 
            // Tbl_KayitlarTableAdapter
            // 
            this.Tbl_KayitlarTableAdapter.ClearBeforeFill = true;
            // 
            // Rapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(859, 372);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Rapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rapor";
            this.Load += new System.EventHandler(this.Rapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yemekhanerandevuDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_KayitlarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Tbl_KayitlarBindingSource;
        private yemekhanerandevuDataSet1 yemekhanerandevuDataSet1;
        private yemekhanerandevuDataSet1TableAdapters.Tbl_KayitlarTableAdapter Tbl_KayitlarTableAdapter;
    }
}