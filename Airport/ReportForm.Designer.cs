namespace Airport
{
    partial class ReportForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.GetFullTicketInfoByTicketNumberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AirportDataSet = new Airport.AirportDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.GetFullTicketInfoByTicketNumberTableAdapter = new Airport.AirportDataSetTableAdapters.GetFullTicketInfoByTicketNumberTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.GetFullTicketInfoByTicketNumberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AirportDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // GetFullTicketInfoByTicketNumberBindingSource
            // 
            this.GetFullTicketInfoByTicketNumberBindingSource.DataMember = "GetFullTicketInfoByTicketNumber";
            this.GetFullTicketInfoByTicketNumberBindingSource.DataSource = this.AirportDataSet;
            // 
            // AirportDataSet
            // 
            this.AirportDataSet.DataSetName = "AirportDataSet";
            this.AirportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.GetFullTicketInfoByTicketNumberBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Airport.ReportTicket.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // GetFullTicketInfoByTicketNumberTableAdapter
            // 
            this.GetFullTicketInfoByTicketNumberTableAdapter.ClearBeforeFill = true;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ReportForm";
            this.ShowIcon = false;
            this.Text = "Билет";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GetFullTicketInfoByTicketNumberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AirportDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource GetFullTicketInfoByTicketNumberBindingSource;
        private AirportDataSet AirportDataSet;
        private AirportDataSetTableAdapters.GetFullTicketInfoByTicketNumberTableAdapter GetFullTicketInfoByTicketNumberTableAdapter;
    }
}