namespace baseer4
{
    partial class formMainScreen
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.FlowLayoutPanel();
            this.panelEDAT = new System.Windows.Forms.Panel();
            this.panChart3 = new System.Windows.Forms.Panel();
            this.checkChart3 = new System.Windows.Forms.CheckBox();
            this.panChart2Laplace = new System.Windows.Forms.Panel();
            this.checkChart2 = new System.Windows.Forms.CheckBox();
            this.panChart1QC = new System.Windows.Forms.Panel();
            this.checkChart1 = new System.Windows.Forms.CheckBox();
            this.panelNewProj = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonSoftTrack = new System.Windows.Forms.Button();
            this.buttonEDAT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LeftHomePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panelHeader.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelEDAT.SuspendLayout();
            this.panChart3.SuspendLayout();
            this.panChart2Laplace.SuspendLayout();
            this.panChart1QC.SuspendLayout();
            this.panelNewProj.SuspendLayout();
            this.LeftHomePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeader.Controls.Add(this.labelHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(807, 36);
            this.panelHeader.TabIndex = 0;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.Location = new System.Drawing.Point(0, 0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(803, 29);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "BASEER - Basic Analysis Software Engineering  Evidence Renderer";
            // 
            // panelFooter
            // 
            this.panelFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 168);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(807, 20);
            this.panelFooter.TabIndex = 1;
            // 
            // panelContent
            // 
            this.panelContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContent.Controls.Add(this.panelEDAT);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelContent.Location = new System.Drawing.Point(243, 36);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(564, 132);
            this.panelContent.TabIndex = 4;
            // 
            // panelEDAT
            // 
            this.panelEDAT.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelEDAT.CausesValidation = false;
            this.panelEDAT.Controls.Add(this.panChart3);
            this.panelEDAT.Controls.Add(this.panChart2Laplace);
            this.panelEDAT.Controls.Add(this.panChart1QC);
            this.panelEDAT.Location = new System.Drawing.Point(3, 3);
            this.panelEDAT.Name = "panelEDAT";
            this.panelEDAT.Size = new System.Drawing.Size(547, 118);
            this.panelEDAT.TabIndex = 2;
            // 
            // panChart3
            // 
            this.panChart3.AccessibleDescription = "Sample Stacked Bar Chart";
            this.panChart3.AccessibleName = "sampleChartStackedBar";
            this.panChart3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panChart3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panChart3.BackgroundImage = global::baseer4.Properties.Resources.patch_Distribution_byYear;
            this.panChart3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panChart3.CausesValidation = false;
            this.panChart3.Controls.Add(this.checkChart3);
            this.panChart3.Location = new System.Drawing.Point(365, 3);
            this.panChart3.Name = "panChart3";
            this.panChart3.Size = new System.Drawing.Size(169, 108);
            this.panChart3.TabIndex = 6;
            // 
            // checkChart3
            // 
            this.checkChart3.AutoSize = true;
            this.checkChart3.Location = new System.Drawing.Point(154, 0);
            this.checkChart3.Name = "checkChart3";
            this.checkChart3.Size = new System.Drawing.Size(15, 14);
            this.checkChart3.TabIndex = 2;
            this.checkChart3.UseVisualStyleBackColor = true;
            // 
            // panChart2Laplace
            // 
            this.panChart2Laplace.AccessibleDescription = "Sample LaPlace Trend Chart";
            this.panChart2Laplace.AccessibleName = "sampleChartLaplace";
            this.panChart2Laplace.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panChart2Laplace.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panChart2Laplace.BackgroundImage = global::baseer4.Properties.Resources.Laplace_trend_test;
            this.panChart2Laplace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panChart2Laplace.CausesValidation = false;
            this.panChart2Laplace.Controls.Add(this.checkChart2);
            this.panChart2Laplace.Location = new System.Drawing.Point(190, 3);
            this.panChart2Laplace.Name = "panChart2Laplace";
            this.panChart2Laplace.Size = new System.Drawing.Size(169, 108);
            this.panChart2Laplace.TabIndex = 6;
            // 
            // checkChart2
            // 
            this.checkChart2.AutoSize = true;
            this.checkChart2.Location = new System.Drawing.Point(154, 3);
            this.checkChart2.Name = "checkChart2";
            this.checkChart2.Size = new System.Drawing.Size(15, 14);
            this.checkChart2.TabIndex = 1;
            this.checkChart2.UseVisualStyleBackColor = true;
            // 
            // panChart1QC
            // 
            this.panChart1QC.AccessibleDescription = "Quality Control Chart Sample";
            this.panChart1QC.AccessibleName = "sampleChartQC";
            this.panChart1QC.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panChart1QC.BackgroundImage = global::baseer4.Properties.Resources.sample_QualityControlChart;
            this.panChart1QC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panChart1QC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panChart1QC.CausesValidation = false;
            this.panChart1QC.Controls.Add(this.checkChart1);
            this.panChart1QC.Location = new System.Drawing.Point(15, 3);
            this.panChart1QC.Name = "panChart1QC";
            this.panChart1QC.Size = new System.Drawing.Size(169, 108);
            this.panChart1QC.TabIndex = 4;
            // 
            // checkChart1
            // 
            this.checkChart1.AutoSize = true;
            this.checkChart1.Location = new System.Drawing.Point(154, 0);
            this.checkChart1.Name = "checkChart1";
            this.checkChart1.Size = new System.Drawing.Size(15, 14);
            this.checkChart1.TabIndex = 0;
            this.checkChart1.UseVisualStyleBackColor = true;
            // 
            // panelNewProj
            // 
            this.panelNewProj.Controls.Add(this.button2);
            this.panelNewProj.Controls.Add(this.buttonSoftTrack);
            this.panelNewProj.Controls.Add(this.buttonEDAT);
            this.panelNewProj.Controls.Add(this.label1);
            this.panelNewProj.Location = new System.Drawing.Point(3, 3);
            this.panelNewProj.Name = "panelNewProj";
            this.panelNewProj.Size = new System.Drawing.Size(239, 108);
            this.panelNewProj.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.AccessibleDescription = "Button - Data Analysis";
            this.button2.AccessibleName = "buttonEDAT";
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(6, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(222, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Security Analysis";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonSoftTrack
            // 
            this.buttonSoftTrack.AccessibleDescription = "Button - Software Maitenance";
            this.buttonSoftTrack.AccessibleName = "buttonSoftTrack";
            this.buttonSoftTrack.Enabled = false;
            this.buttonSoftTrack.Location = new System.Drawing.Point(6, 48);
            this.buttonSoftTrack.Name = "buttonSoftTrack";
            this.buttonSoftTrack.Size = new System.Drawing.Size(222, 23);
            this.buttonSoftTrack.TabIndex = 2;
            this.buttonSoftTrack.Text = "Software Maintenance";
            this.buttonSoftTrack.UseVisualStyleBackColor = true;
            // 
            // buttonEDAT
            // 
            this.buttonEDAT.AccessibleDescription = "Button - Data Analysis";
            this.buttonEDAT.AccessibleName = "buttonEDAT";
            this.buttonEDAT.Location = new System.Drawing.Point(7, 19);
            this.buttonEDAT.Name = "buttonEDAT";
            this.buttonEDAT.Size = new System.Drawing.Size(221, 23);
            this.buttonEDAT.TabIndex = 1;
            this.buttonEDAT.Text = "Data Analysis";
            this.buttonEDAT.UseVisualStyleBackColor = true;
            this.buttonEDAT.Click += new System.EventHandler(this.buttonEDAT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Projects";
            // 
            // LeftHomePanel
            // 
            this.LeftHomePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LeftHomePanel.Controls.Add(this.panelNewProj);
            this.LeftHomePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftHomePanel.Location = new System.Drawing.Point(0, 36);
            this.LeftHomePanel.Name = "LeftHomePanel";
            this.LeftHomePanel.Size = new System.Drawing.Size(243, 132);
            this.LeftHomePanel.TabIndex = 2;
            // 
            // formMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 188);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.LeftHomePanel);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHeader);
            this.Name = "formMainScreen";
            this.Text = "BASEER - A Data Visualization Tool";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelEDAT.ResumeLayout(false);
            this.panChart3.ResumeLayout(false);
            this.panChart3.PerformLayout();
            this.panChart2Laplace.ResumeLayout(false);
            this.panChart2Laplace.PerformLayout();
            this.panChart1QC.ResumeLayout(false);
            this.panChart1QC.PerformLayout();
            this.panelNewProj.ResumeLayout(false);
            this.panelNewProj.PerformLayout();
            this.LeftHomePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.FlowLayoutPanel panelContent;
        private System.Windows.Forms.Panel panelEDAT;
        private System.Windows.Forms.Panel panChart3;
        private System.Windows.Forms.Panel panChart2Laplace;
        private System.Windows.Forms.Panel panChart1QC;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.CheckBox checkChart3;
        private System.Windows.Forms.CheckBox checkChart2;
        private System.Windows.Forms.CheckBox checkChart1;
        private System.Windows.Forms.Panel panelNewProj;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonSoftTrack;
        private System.Windows.Forms.Button buttonEDAT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel LeftHomePanel;
    }
}

