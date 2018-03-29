namespace DataMiner
{
    partial class DataMinerForm
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
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.rtbMain = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalEntries = new System.Windows.Forms.Label();
            this.panelGraph = new System.Windows.Forms.Panel();
            this.gbChartChange = new System.Windows.Forms.GroupBox();
            this.radAvgItemsPerInvoice = new System.Windows.Forms.RadioButton();
            this.radUniqueCustomers = new System.Windows.Forms.RadioButton();
            this.radInvoicesGenerated = new System.Windows.Forms.RadioButton();
            this.radTotalValue = new System.Windows.Forms.RadioButton();
            this.radTotalQuantity = new System.Windows.Forms.RadioButton();
            this.txtSearchRecords = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupInterrogate = new System.Windows.Forms.GroupBox();
            this.radInvoice = new System.Windows.Forms.RadioButton();
            this.radCustomer = new System.Windows.Forms.RadioButton();
            this.gbChartChange.SuspendLayout();
            this.groupInterrogate.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(13, 13);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(95, 34);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "Open file";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.InitialDirectory = "C:";
            // 
            // rtbMain
            // 
            this.rtbMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbMain.Location = new System.Drawing.Point(912, 83);
            this.rtbMain.Name = "rtbMain";
            this.rtbMain.Size = new System.Drawing.Size(352, 580);
            this.rtbMain.TabIndex = 1;
            this.rtbMain.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "No. Records:";
            // 
            // lblTotalEntries
            // 
            this.lblTotalEntries.AutoSize = true;
            this.lblTotalEntries.Location = new System.Drawing.Point(88, 67);
            this.lblTotalEntries.Name = "lblTotalEntries";
            this.lblTotalEntries.Size = new System.Drawing.Size(25, 13);
            this.lblTotalEntries.TabIndex = 3;
            this.lblTotalEntries.Text = "000";
            // 
            // panelGraph
            // 
            this.panelGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGraph.BackColor = System.Drawing.Color.White;
            this.panelGraph.Location = new System.Drawing.Point(12, 86);
            this.panelGraph.Name = "panelGraph";
            this.panelGraph.Size = new System.Drawing.Size(894, 577);
            this.panelGraph.TabIndex = 4;
            this.panelGraph.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGraph_Paint);
            // 
            // gbChartChange
            // 
            this.gbChartChange.Controls.Add(this.radAvgItemsPerInvoice);
            this.gbChartChange.Controls.Add(this.radUniqueCustomers);
            this.gbChartChange.Controls.Add(this.radInvoicesGenerated);
            this.gbChartChange.Controls.Add(this.radTotalValue);
            this.gbChartChange.Controls.Add(this.radTotalQuantity);
            this.gbChartChange.Location = new System.Drawing.Point(144, 13);
            this.gbChartChange.Name = "gbChartChange";
            this.gbChartChange.Size = new System.Drawing.Size(424, 67);
            this.gbChartChange.TabIndex = 8;
            this.gbChartChange.TabStop = false;
            this.gbChartChange.Text = "Change Chart";
            // 
            // radAvgItemsPerInvoice
            // 
            this.radAvgItemsPerInvoice.AutoSize = true;
            this.radAvgItemsPerInvoice.Location = new System.Drawing.Point(246, 16);
            this.radAvgItemsPerInvoice.Name = "radAvgItemsPerInvoice";
            this.radAvgItemsPerInvoice.Size = new System.Drawing.Size(176, 17);
            this.radAvgItemsPerInvoice.TabIndex = 4;
            this.radAvgItemsPerInvoice.TabStop = true;
            this.radAvgItemsPerInvoice.Text = "Avg number of items per invoice";
            this.radAvgItemsPerInvoice.UseVisualStyleBackColor = true;
            // 
            // radUniqueCustomers
            // 
            this.radUniqueCustomers.AutoSize = true;
            this.radUniqueCustomers.Location = new System.Drawing.Point(121, 44);
            this.radUniqueCustomers.Name = "radUniqueCustomers";
            this.radUniqueCustomers.Size = new System.Drawing.Size(111, 17);
            this.radUniqueCustomers.TabIndex = 3;
            this.radUniqueCustomers.Text = "Unique Customers";
            this.radUniqueCustomers.UseVisualStyleBackColor = true;
            this.radUniqueCustomers.CheckedChanged += new System.EventHandler(this.radTotalQuantity_CheckedChanged);
            // 
            // radInvoicesGenerated
            // 
            this.radInvoicesGenerated.AutoSize = true;
            this.radInvoicesGenerated.Checked = true;
            this.radInvoicesGenerated.Location = new System.Drawing.Point(121, 17);
            this.radInvoicesGenerated.Name = "radInvoicesGenerated";
            this.radInvoicesGenerated.Size = new System.Drawing.Size(118, 17);
            this.radInvoicesGenerated.TabIndex = 2;
            this.radInvoicesGenerated.TabStop = true;
            this.radInvoicesGenerated.Text = "Invoices Generated";
            this.radInvoicesGenerated.UseVisualStyleBackColor = true;
            this.radInvoicesGenerated.CheckedChanged += new System.EventHandler(this.radTotalQuantity_CheckedChanged);
            // 
            // radTotalValue
            // 
            this.radTotalValue.AutoSize = true;
            this.radTotalValue.Location = new System.Drawing.Point(6, 43);
            this.radTotalValue.Name = "radTotalValue";
            this.radTotalValue.Size = new System.Drawing.Size(107, 17);
            this.radTotalValue.TabIndex = 1;
            this.radTotalValue.Text = "Value Per Month ";
            this.radTotalValue.UseVisualStyleBackColor = true;
            this.radTotalValue.CheckedChanged += new System.EventHandler(this.radTotalQuantity_CheckedChanged);
            // 
            // radTotalQuantity
            // 
            this.radTotalQuantity.AutoSize = true;
            this.radTotalQuantity.Location = new System.Drawing.Point(6, 19);
            this.radTotalQuantity.Name = "radTotalQuantity";
            this.radTotalQuantity.Size = new System.Drawing.Size(74, 17);
            this.radTotalQuantity.TabIndex = 0;
            this.radTotalQuantity.Text = "Items Sold";
            this.radTotalQuantity.UseVisualStyleBackColor = true;
            this.radTotalQuantity.CheckedChanged += new System.EventHandler(this.radTotalQuantity_CheckedChanged);
            // 
            // txtSearchRecords
            // 
            this.txtSearchRecords.Location = new System.Drawing.Point(6, 40);
            this.txtSearchRecords.Name = "txtSearchRecords";
            this.txtSearchRecords.Size = new System.Drawing.Size(259, 20);
            this.txtSearchRecords.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(271, 38);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupInterrogate
            // 
            this.groupInterrogate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupInterrogate.Controls.Add(this.radInvoice);
            this.groupInterrogate.Controls.Add(this.radCustomer);
            this.groupInterrogate.Controls.Add(this.txtSearchRecords);
            this.groupInterrogate.Controls.Add(this.btnSearch);
            this.groupInterrogate.Location = new System.Drawing.Point(912, 13);
            this.groupInterrogate.Name = "groupInterrogate";
            this.groupInterrogate.Size = new System.Drawing.Size(352, 67);
            this.groupInterrogate.TabIndex = 13;
            this.groupInterrogate.TabStop = false;
            this.groupInterrogate.Text = "Interrogate Data";
            // 
            // radInvoice
            // 
            this.radInvoice.AutoSize = true;
            this.radInvoice.Location = new System.Drawing.Point(92, 19);
            this.radInvoice.Name = "radInvoice";
            this.radInvoice.Size = new System.Drawing.Size(71, 17);
            this.radInvoice.TabIndex = 14;
            this.radInvoice.Text = "InvoiceID";
            this.radInvoice.UseVisualStyleBackColor = true;
            // 
            // radCustomer
            // 
            this.radCustomer.AutoSize = true;
            this.radCustomer.Checked = true;
            this.radCustomer.Location = new System.Drawing.Point(6, 19);
            this.radCustomer.Name = "radCustomer";
            this.radCustomer.Size = new System.Drawing.Size(80, 17);
            this.radCustomer.TabIndex = 13;
            this.radCustomer.TabStop = true;
            this.radCustomer.Text = "CustomerID";
            this.radCustomer.UseVisualStyleBackColor = true;
            // 
            // DataMinerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 675);
            this.Controls.Add(this.groupInterrogate);
            this.Controls.Add(this.rtbMain);
            this.Controls.Add(this.gbChartChange);
            this.Controls.Add(this.panelGraph);
            this.Controls.Add(this.lblTotalEntries);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenFile);
            this.Name = "DataMinerForm";
            this.Text = ".CSV Data Miner";
            this.gbChartChange.ResumeLayout(false);
            this.gbChartChange.PerformLayout();
            this.groupInterrogate.ResumeLayout(false);
            this.groupInterrogate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.RichTextBox rtbMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalEntries;
        private System.Windows.Forms.Panel panelGraph;
        private System.Windows.Forms.GroupBox gbChartChange;
        private System.Windows.Forms.RadioButton radUniqueCustomers;
        private System.Windows.Forms.RadioButton radInvoicesGenerated;
        private System.Windows.Forms.RadioButton radTotalValue;
        private System.Windows.Forms.RadioButton radTotalQuantity;
        private System.Windows.Forms.TextBox txtSearchRecords;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton radAvgItemsPerInvoice;
        private System.Windows.Forms.GroupBox groupInterrogate;
        private System.Windows.Forms.RadioButton radInvoice;
        private System.Windows.Forms.RadioButton radCustomer;
    }
}

