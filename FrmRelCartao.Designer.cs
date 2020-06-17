namespace LojaCL
{
    partial class FrmRelCartao
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DbLojaDataSet1 = new LojaCL.DbLojaDataSet1();
            this.cartaovendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cartaovendaTableAdapter = new LojaCL.DbLojaDataSet1TableAdapters.cartaovendaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DbLojaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartaovendaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.cartaovendaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LojaCL.RelCartao.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DbLojaDataSet1
            // 
            this.DbLojaDataSet1.DataSetName = "DbLojaDataSet1";
            this.DbLojaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cartaovendaBindingSource
            // 
            this.cartaovendaBindingSource.DataMember = "cartaovenda";
            this.cartaovendaBindingSource.DataSource = this.DbLojaDataSet1;
            // 
            // cartaovendaTableAdapter
            // 
            this.cartaovendaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRelCartao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRelCartao";
            this.Text = "Relatorio Cartao Venda";
            this.Load += new System.EventHandler(this.FrmRelCartao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DbLojaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartaovendaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource cartaovendaBindingSource;
        private DbLojaDataSet1 DbLojaDataSet1;
        private DbLojaDataSet1TableAdapters.cartaovendaTableAdapter cartaovendaTableAdapter;
    }
}