namespace baseer4
{        /// <summary>
         /// formChart is the form used for displaying the quality control charts.
         /// </summary>
    partial class formChart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
       // public class CustomLabel : System.Windows.Forms.DataVisualization.Charting.ChartNamedElement;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formChart));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonOpenSrcData = new System.Windows.Forms.Button();
            this.txbSourceFilePath = new System.Windows.Forms.TextBox();
            this.ChartScreenHeader = new System.Windows.Forms.Label();
            this.LeftHomePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTipBox = new System.Windows.Forms.Panel();
            this.textBoxQCTips = new System.Windows.Forms.TextBox();
            this.labelTipsQuality = new System.Windows.Forms.Label();
            this.panelExistingProj = new System.Windows.Forms.Panel();
            this.txbFileStatus = new System.Windows.Forms.TextBox();
            this.btnQCClose = new System.Windows.Forms.Button();
            this.btnQCReset = new System.Windows.Forms.Button();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.groupBoxQCOutput = new System.Windows.Forms.GroupBox();
            this.radio4ExportRaw = new System.Windows.Forms.RadioButton();
            this.radio3Export = new System.Windows.Forms.RadioButton();
            this.radio2Plot = new System.Windows.Forms.RadioButton();
            this.radio1DataTable = new System.Windows.Forms.RadioButton();
            this.txbLowerControlLimit = new System.Windows.Forms.TextBox();
            this.txbUpperControlLimit = new System.Windows.Forms.TextBox();
            this.labelLCL = new System.Windows.Forms.Label();
            this.labelUCL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.txbFooter = new System.Windows.Forms.TextBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.FlowLayoutPanel();
            this.flowPanQCChart = new System.Windows.Forms.FlowLayoutPanel();
            this.chartQC = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LeftHomePanel.SuspendLayout();
            this.panelTipBox.SuspendLayout();
            this.panelExistingProj.SuspendLayout();
            this.groupBoxQCOutput.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.flowPanQCChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartQC)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenSrcData
            // 
            this.buttonOpenSrcData.Location = new System.Drawing.Point(144, 20);
            this.buttonOpenSrcData.Name = "buttonOpenSrcData";
            this.buttonOpenSrcData.Size = new System.Drawing.Size(84, 23);
            this.buttonOpenSrcData.TabIndex = 5;
            this.buttonOpenSrcData.Text = "Open";
            this.buttonOpenSrcData.UseVisualStyleBackColor = true;
            this.buttonOpenSrcData.Click += new System.EventHandler(this.buttonOpenSrcData_Click);
            // 
            // txbSourceFilePath
            // 
            this.txbSourceFilePath.Location = new System.Drawing.Point(12, 20);
            this.txbSourceFilePath.Name = "txbSourceFilePath";
            this.txbSourceFilePath.Size = new System.Drawing.Size(129, 20);
            this.txbSourceFilePath.TabIndex = 4;
            this.txbSourceFilePath.Enter += new System.EventHandler(this.buttonOpenSrcData_Click);
            // 
            // ChartScreenHeader
            // 
            this.ChartScreenHeader.AutoSize = true;
            this.ChartScreenHeader.Location = new System.Drawing.Point(10, 9);
            this.ChartScreenHeader.Name = "ChartScreenHeader";
            this.ChartScreenHeader.Size = new System.Drawing.Size(425, 31);
            this.ChartScreenHeader.TabIndex = 0;
            this.ChartScreenHeader.Text = "BASEER - Quality Control Plots";
            // 
            // LeftHomePanel
            // 
            this.LeftHomePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LeftHomePanel.Controls.Add(this.panelTipBox);
            this.LeftHomePanel.Controls.Add(this.panelExistingProj);
            this.LeftHomePanel.Location = new System.Drawing.Point(-4, 50);
            this.LeftHomePanel.Name = "LeftHomePanel";
            this.LeftHomePanel.Size = new System.Drawing.Size(243, 379);
            this.LeftHomePanel.TabIndex = 7;
            // 
            // panelTipBox
            // 
            this.panelTipBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelTipBox.CausesValidation = false;
            this.panelTipBox.Controls.Add(this.textBoxQCTips);
            this.panelTipBox.Controls.Add(this.labelTipsQuality);
            this.panelTipBox.Location = new System.Drawing.Point(3, 3);
            this.panelTipBox.Name = "panelTipBox";
            this.panelTipBox.Size = new System.Drawing.Size(239, 136);
            this.panelTipBox.TabIndex = 1;
            // 
            // textBoxQCTips
            // 
            this.textBoxQCTips.Location = new System.Drawing.Point(1, 19);
            this.textBoxQCTips.MaxLength = 2048;
            this.textBoxQCTips.Multiline = true;
            this.textBoxQCTips.Name = "textBoxQCTips";
            this.textBoxQCTips.Size = new System.Drawing.Size(236, 114);
            this.textBoxQCTips.TabIndex = 3;
            this.textBoxQCTips.Text = "Software Quality Control (QC) charts can be \r\nused to show trends in software def" +
    "ects over \r\ntime. Data is plotted contrasted with Upper \r\nControl Limits and Low" +
    "er Control Limits.";
            // 
            // labelTipsQuality
            // 
            this.labelTipsQuality.AutoSize = true;
            this.labelTipsQuality.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipsQuality.Location = new System.Drawing.Point(3, 3);
            this.labelTipsQuality.Name = "labelTipsQuality";
            this.labelTipsQuality.Size = new System.Drawing.Size(31, 13);
            this.labelTipsQuality.TabIndex = 2;
            this.labelTipsQuality.Text = "Tips";
            // 
            // panelExistingProj
            // 
            this.panelExistingProj.Controls.Add(this.txbFileStatus);
            this.panelExistingProj.Controls.Add(this.btnQCClose);
            this.panelExistingProj.Controls.Add(this.btnQCReset);
            this.panelExistingProj.Controls.Add(this.buttonExecute);
            this.panelExistingProj.Controls.Add(this.groupBoxQCOutput);
            this.panelExistingProj.Controls.Add(this.txbLowerControlLimit);
            this.panelExistingProj.Controls.Add(this.txbUpperControlLimit);
            this.panelExistingProj.Controls.Add(this.labelLCL);
            this.panelExistingProj.Controls.Add(this.labelUCL);
            this.panelExistingProj.Controls.Add(this.buttonOpenSrcData);
            this.panelExistingProj.Controls.Add(this.txbSourceFilePath);
            this.panelExistingProj.Controls.Add(this.label2);
            this.panelExistingProj.Location = new System.Drawing.Point(3, 145);
            this.panelExistingProj.Name = "panelExistingProj";
            this.panelExistingProj.Size = new System.Drawing.Size(239, 233);
            this.panelExistingProj.TabIndex = 0;
            // 
            // txbFileStatus
            // 
            this.txbFileStatus.BackColor = this.BackColor;
            this.txbFileStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbFileStatus.ForeColor = System.Drawing.SystemColors.Info;
            this.txbFileStatus.Location = new System.Drawing.Point(12, 44);
            this.txbFileStatus.MaxLength = 200;
            this.txbFileStatus.Name = "txbFileStatus";
            this.txbFileStatus.ReadOnly = true;
            this.txbFileStatus.Size = new System.Drawing.Size(216, 13);
            this.txbFileStatus.TabIndex = 16;
            this.txbFileStatus.TabStop = false;
            // 
            // btnQCClose
            // 
            this.btnQCClose.Location = new System.Drawing.Point(158, 200);
            this.btnQCClose.Name = "btnQCClose";
            this.btnQCClose.Size = new System.Drawing.Size(65, 23);
            this.btnQCClose.TabIndex = 15;
            this.btnQCClose.Text = "Close";
            this.btnQCClose.UseVisualStyleBackColor = true;
            this.btnQCClose.Click += new System.EventHandler(this.btnQCClose_Click);
            // 
            // btnQCReset
            // 
            this.btnQCReset.Location = new System.Drawing.Point(85, 200);
            this.btnQCReset.Name = "btnQCReset";
            this.btnQCReset.Size = new System.Drawing.Size(65, 23);
            this.btnQCReset.TabIndex = 13;
            this.btnQCReset.Text = "Reset";
            this.btnQCReset.UseVisualStyleBackColor = true;
            this.btnQCReset.Click += new System.EventHandler(this.btnQCReset_Click);
            // 
            // buttonExecute
            // 
            this.buttonExecute.Location = new System.Drawing.Point(12, 200);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(65, 23);
            this.buttonExecute.TabIndex = 12;
            this.buttonExecute.Text = "Execute";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // groupBoxQCOutput
            // 
            this.groupBoxQCOutput.Controls.Add(this.radio4ExportRaw);
            this.groupBoxQCOutput.Controls.Add(this.radio3Export);
            this.groupBoxQCOutput.Controls.Add(this.radio2Plot);
            this.groupBoxQCOutput.Controls.Add(this.radio1DataTable);
            this.groupBoxQCOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxQCOutput.Location = new System.Drawing.Point(12, 109);
            this.groupBoxQCOutput.Name = "groupBoxQCOutput";
            this.groupBoxQCOutput.Size = new System.Drawing.Size(222, 85);
            this.groupBoxQCOutput.TabIndex = 11;
            this.groupBoxQCOutput.TabStop = false;
            this.groupBoxQCOutput.Text = "Output";
            // 
            // radio4ExportRaw
            // 
            this.radio4ExportRaw.AutoSize = true;
            this.radio4ExportRaw.Location = new System.Drawing.Point(118, 54);
            this.radio4ExportRaw.Name = "radio4ExportRaw";
            this.radio4ExportRaw.Size = new System.Drawing.Size(106, 17);
            this.radio4ExportRaw.TabIndex = 13;
            this.radio4ExportRaw.TabStop = true;
            this.radio4ExportRaw.Text = "Export Raw Data";
            this.radio4ExportRaw.UseVisualStyleBackColor = true;
            // 
            // radio3Export
            // 
            this.radio3Export.AutoSize = true;
            this.radio3Export.Location = new System.Drawing.Point(1, 54);
            this.radio3Export.Name = "radio3Export";
            this.radio3Export.Size = new System.Drawing.Size(55, 17);
            this.radio3Export.TabIndex = 12;
            this.radio3Export.TabStop = true;
            this.radio3Export.Text = "Export";
            this.radio3Export.UseVisualStyleBackColor = true;
            // 
            // radio2Plot
            // 
            this.radio2Plot.AutoSize = true;
            this.radio2Plot.Location = new System.Drawing.Point(118, 31);
            this.radio2Plot.Name = "radio2Plot";
            this.radio2Plot.Size = new System.Drawing.Size(75, 17);
            this.radio2Plot.TabIndex = 11;
            this.radio2Plot.TabStop = true;
            this.radio2Plot.Text = "Plot Graph";
            this.radio2Plot.UseVisualStyleBackColor = true;
            this.radio2Plot.CheckedChanged += new System.EventHandler(this.radio2Plot_CheckedChanged);
            // 
            // radio1DataTable
            // 
            this.radio1DataTable.AutoSize = true;
            this.radio1DataTable.Location = new System.Drawing.Point(1, 31);
            this.radio1DataTable.Name = "radio1DataTable";
            this.radio1DataTable.Size = new System.Drawing.Size(108, 17);
            this.radio1DataTable.TabIndex = 10;
            this.radio1DataTable.TabStop = true;
            this.radio1DataTable.Text = "Show Data Table";
            this.radio1DataTable.UseVisualStyleBackColor = true;
            // 
            // txbLowerControlLimit
            // 
            this.txbLowerControlLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLowerControlLimit.Location = new System.Drawing.Point(149, 86);
            this.txbLowerControlLimit.Name = "txbLowerControlLimit";
            this.txbLowerControlLimit.Size = new System.Drawing.Size(76, 22);
            this.txbLowerControlLimit.TabIndex = 9;
            // 
            // txbUpperControlLimit
            // 
            this.txbUpperControlLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUpperControlLimit.Location = new System.Drawing.Point(149, 60);
            this.txbUpperControlLimit.Name = "txbUpperControlLimit";
            this.txbUpperControlLimit.Size = new System.Drawing.Size(76, 22);
            this.txbUpperControlLimit.TabIndex = 8;
            // 
            // labelLCL
            // 
            this.labelLCL.AutoSize = true;
            this.labelLCL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLCL.Location = new System.Drawing.Point(12, 86);
            this.labelLCL.Name = "labelLCL";
            this.labelLCL.Size = new System.Drawing.Size(119, 16);
            this.labelLCL.TabIndex = 7;
            this.labelLCL.Text = "Lower Control Limit";
            // 
            // labelUCL
            // 
            this.labelUCL.AutoSize = true;
            this.labelUCL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUCL.Location = new System.Drawing.Point(12, 60);
            this.labelUCL.Name = "labelUCL";
            this.labelUCL.Size = new System.Drawing.Size(121, 16);
            this.labelUCL.TabIndex = 6;
            this.labelUCL.Text = "Upper Control Limit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data Controls";
            // 
            // panelFooter
            // 
            this.panelFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFooter.Controls.Add(this.txbFooter);
            this.panelFooter.Location = new System.Drawing.Point(0, 435);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(800, 20);
            this.panelFooter.TabIndex = 6;
            // 
            // txbFooter
            // 
            this.txbFooter.BackColor = this.BackColor;
            this.txbFooter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txbFooter.ForeColor = System.Drawing.SystemColors.Info;
            this.txbFooter.Location = new System.Drawing.Point(0, 5);
            this.txbFooter.MaxLength = 200;
            this.txbFooter.Name = "txbFooter";
            this.txbFooter.ReadOnly = true;
            this.txbFooter.Size = new System.Drawing.Size(798, 13);
            this.txbFooter.TabIndex = 17;
            this.txbFooter.TabStop = false;
            // 
            // panelHeader
            // 
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeader.Controls.Add(this.ChartScreenHeader);
            this.panelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelHeader.Location = new System.Drawing.Point(-4, -4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(804, 48);
            this.panelHeader.TabIndex = 5;
            // 
            // panelContent
            // 
            this.panelContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContent.AutoSize = true;
            this.panelContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContent.Controls.Add(this.flowPanQCChart);
            this.panelContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelContent.Location = new System.Drawing.Point(245, 50);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(559, 384);
            this.panelContent.TabIndex = 8;
            // 
            // flowPanQCChart
            // 
            this.flowPanQCChart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowPanQCChart.BackgroundImage")));
            this.flowPanQCChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.flowPanQCChart.Controls.Add(this.chartQC);
            this.flowPanQCChart.Location = new System.Drawing.Point(3, 3);
            this.flowPanQCChart.Name = "flowPanQCChart";
            this.flowPanQCChart.Size = new System.Drawing.Size(551, 375);
            this.flowPanQCChart.TabIndex = 0;
            // 
            // chartQC
            // 
            this.chartQC.AccessibleDescription = "Quality Control Chart";
            this.chartQC.AccessibleName = "chartQCAccessible";
            this.chartQC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.chartQC.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            chartArea1.Name = "QC Chart";
            this.chartQC.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartQC.Legends.Add(legend1);
            this.chartQC.Location = new System.Drawing.Point(3, 3);
            this.chartQC.Name = "chartQC";
            this.chartQC.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "QC Chart";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            this.chartQC.Series.Add(series1);
            this.chartQC.Size = new System.Drawing.Size(548, 372);
            this.chartQC.TabIndex = 0;
            this.chartQC.Text = "chartQC";
            // 
            // formChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 455);
            this.Controls.Add(this.LeftHomePanel);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelContent);
            this.Name = "formChart";
            this.Text = "BASEER - Quality Control Plots";
            this.LeftHomePanel.ResumeLayout(false);
            this.panelTipBox.ResumeLayout(false);
            this.panelTipBox.PerformLayout();
            this.panelExistingProj.ResumeLayout(false);
            this.panelExistingProj.PerformLayout();
            this.groupBoxQCOutput.ResumeLayout(false);
            this.groupBoxQCOutput.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.flowPanQCChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartQC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenSrcData;
        private System.Windows.Forms.TextBox txbSourceFilePath;
        private System.Windows.Forms.Label ChartScreenHeader;
        private System.Windows.Forms.FlowLayoutPanel LeftHomePanel;
        private System.Windows.Forms.Panel panelExistingProj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelTipBox;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.FlowLayoutPanel panelContent;
        private System.Windows.Forms.Label labelTipsQuality;
        private System.Windows.Forms.GroupBox groupBoxQCOutput;
        private System.Windows.Forms.RadioButton radio4ExportRaw;
        private System.Windows.Forms.RadioButton radio3Export;
        private System.Windows.Forms.RadioButton radio2Plot;
        private System.Windows.Forms.RadioButton radio1DataTable;
        private System.Windows.Forms.TextBox txbLowerControlLimit;
        private System.Windows.Forms.TextBox txbUpperControlLimit;
        private System.Windows.Forms.Label labelLCL;
        private System.Windows.Forms.Label labelUCL;
        private System.Windows.Forms.Button btnQCReset;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.Button btnQCClose;
        private System.Windows.Forms.FlowLayoutPanel flowPanQCChart;
        private System.Windows.Forms.TextBox textBoxQCTips;
        private System.Windows.Forms.TextBox txbFileStatus;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartQC;
        private System.Windows.Forms.TextBox txbFooter;
    }
}