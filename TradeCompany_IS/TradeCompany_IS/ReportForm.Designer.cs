namespace TradeCompany_IS
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this._7_Active_Users_DataSet = new TradeCompany_IS._7_Active_Users_DataSet();
            this.activeUsersDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.документПродажаТовараBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.документ__Продажа_товара_TableAdapter = new TradeCompany_IS._7_Active_Users_DataSetTableAdapters.Документ__Продажа_товара_TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this._7_Active_Users_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeUsersDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.документПродажаТовараBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet_Report";
            reportDataSource1.Value = this.документПродажаТовараBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TradeCompany_IS.Отчет_.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(646, 487);
            this.reportViewer1.TabIndex = 0;
            // 
            // _7_Active_Users_DataSet
            // 
            this._7_Active_Users_DataSet.DataSetName = "7_Active_Users_DataSet";
            this._7_Active_Users_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // activeUsersDataSetBindingSource
            // 
            this.activeUsersDataSetBindingSource.DataSource = this._7_Active_Users_DataSet;
            this.activeUsersDataSetBindingSource.Position = 0;
            // 
            // документПродажаТовараBindingSource
            // 
            this.документПродажаТовараBindingSource.DataMember = "Документ \"Продажа товара\"";
            this.документПродажаТовараBindingSource.DataSource = this.activeUsersDataSetBindingSource;
            // 
            // документ__Продажа_товара_TableAdapter
            // 
            this.документ__Продажа_товара_TableAdapter.ClearBeforeFill = true;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 511);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._7_Active_Users_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeUsersDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.документПродажаТовараBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource activeUsersDataSetBindingSource;
        private _7_Active_Users_DataSet _7_Active_Users_DataSet;
        private System.Windows.Forms.BindingSource документПродажаТовараBindingSource;
        private _7_Active_Users_DataSetTableAdapters.Документ__Продажа_товара_TableAdapter документ__Продажа_товара_TableAdapter;
    }
}