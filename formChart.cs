using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.VisualBasic;
using Csv;
//using CsvHelper;


namespace baseer4
{

    public partial class formChart : Form
    {
        /// <summary>
        /// Required. formChart() is the main chart form.
        /// </summary>
        public formChart()
        {// this is the form that holds the chart

            InitializeComponent();
            const string qcChartBackgroundPath = "C:\\Users\\Hassa\\OneDrive\\Thesis\\research\\software_reliability\\ComparisonTool\\Baseer_wire";
            const string qcChartBackground = "sample_QualityControlChart.png";
            this.chartQC.BackgroundImage = Image.FromFile(Path.Combine(qcChartBackgroundPath, qcChartBackground));

        }

        private string filePath = string.Empty;
        private string fileContent = string.Empty;

        private void GetSourceFileName()
        {   // This is called to get the source file name
            // https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.filedialog?view=netframework-4.7.2
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); //  "c:\\";
                openFileDialog.Filter = "csv files (*.csv)|*.csv|INP files (*.INP)|*.INP|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    txbSourceFilePath.Text = filePath;
                }
                else
                {
                    if (txbSourceFilePath.Text.Length == 0)
                    {
                        this.txbFileStatus.Text = "Click 'Open' to load source file";
                    }
                    else
                    {
                        this.txbFileStatus.Text = "ERROR! Unable to read file: " + filePath;
                    }
                }
                this.txbFileStatus.Visible = true;


            }
        }

        private void ConsumeSourceFile()
        { // this is called to actuall process the data once we know the file name
          //attempt to open the file
            FileStream fileStream = new FileStream(
                filePath, FileMode.Open,
                FileAccess.Read, FileShare.Read
            );


            using (StreamReader reader = new StreamReader(fileStream))
            {
                // TO DO: 1. Add something to restrict content size.... or properly handle it.
                //           Recall how it hung when trying to read in some sample data 1.2GB
                // TO DO: 2. Confirm content is in an acceptable format, not just file extension
                fileContent = reader.ReadToEnd();
            }
            this.txbFileStatus.Text = "File: " + filePath;
            this.txbFileStatus.ForeColor = Color.DarkBlue;
            this.labelTipsQuality.Text = "Raw file sample (1st 2048 bytes)";
            if (fileContent.Length == 0)
            {
                this.txbFileStatus.Text = "ERROR! " + filePath + " is empty!";
            }
            else if (fileContent.Length < 2048)
            {
                this.textBoxQCTips.Text = fileContent;

            }
            else
            {
                this.textBoxQCTips.Text = fileContent.Substring(0, 2048);
            }
            this.textBoxQCTips.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;

        }
        private void buttonOpenSrcData_Click(object sender, EventArgs e)
        {
            txbFileStatus.Visible = false;

            if (txbSourceFilePath.Text == string.Empty)
            {
                GetSourceFileName();
                ConsumeSourceFile();
            }
            else
            {
                filePath = txbSourceFilePath.Text;
                ConsumeSourceFile();
            }
            // TO DO:
        }

        private void btnQCReset_Click(object sender, EventArgs e)
        {

            //reset all QC data and events
            //besure to clear memory. That openFileDialogue used 20MB and didn't let it go!
            // this.chartQC.BackgroundImage.Dispose();

            txbFileStatus.Text = string.Empty;
            fileContent = string.Empty;
            this.txbFileStatus.BackColor = this.BackColor;
            txbSourceFilePath.Text = string.Empty;
            this.labelTipsQuality.Text = "Tips";
            this.textBoxQCTips.Text = "Software Quality Control (QC) charts can be " +
                "used to show trends in software defects over " +
                "time.Data is plotted contrasted with Upper " +
                "Control Limits and Lower Control Limits.";
            this.textBoxQCTips.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.chartQC.ResetAutoValues();
            this.chartQC.ResetText();
            this.chartQC.Series.Clear();
            this.chartQC.Titles.Clear();
            this.txbUpperControlLimit.Text = string.Empty;
            this.txbLowerControlLimit.Text = string.Empty;


        }

        private void btnQCClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //ACTION_TYPES:
        int actionType = 0;
        private void radio2Plot_CheckedChanged(object sender, EventArgs e)
        {
            // 1. Plot
            actionType = 1;
        }
        private void radio1DataTable_CheckedChanged(object sender, EventArgs e)
        {
            // 2. Show Data Table
            actionType = 2;
        }
        private void radio3ExportResults_CheckedChanged(object sender, EventArgs e)
        {
            // 3. Export Results
            actionType = 3;

        }
        private void radio4ExportRaw_CheckedChanged(object sender, EventArgs e)
        {
            // 4. Export Raw
            actionType = 4;
        }

        private void PlotQCChart()
        {
            // 1. First Make sure that the chart and titles are clear
            this.chartQC.Series.Clear();
            if (this.chartQC.Titles.Any() == false)
            {
                this.chartQC.Titles.Add("Software Quality Control Chart");
            }

            // from https://github.com/stevehansen/csv .... but not working!

            // 2. Setup visualization characterics of a new data series 
            Series srsDefects = this.chartQC.Series.Add("Defects");
            srsDefects.IsVisibleInLegend = true;
            srsDefects.ChartType = SeriesChartType.Line;
            srsDefects.MarkerStyle = MarkerStyle.Circle;
            srsDefects.MarkerColor = Color.Black;

            // 3. Setup visualization characterics of the upper control limit series
            Series srsUpperLimit = chartQC.Series.Add("Upper Control Limit (UCL)");
            //srsUpperLimit.ChartType = SeriesChartType.SplineArea;
            srsUpperLimit.ChartArea = "QC Chart";
            srsUpperLimit.ChartType = SeriesChartType.Line;
            srsUpperLimit.MarkerColor = Color.Navy;
            srsUpperLimit.BorderWidth = 4;
            srsUpperLimit.AxisLabel = "UCL";
            
            //this.labelUCL.Location = System.Drawing.PointF(0, txbUpperControlLimit.Text);
            //labelUCL.Location = srsUpperLimit.Y
            // Set spline line tension 
            srsUpperLimit["LineTension"] = "0.2";

            // Enable data points labels
            srsUpperLimit.IsValueShownAsLabel = true;
            
            // Enable data points markers
            srsUpperLimit.MarkerStyle = MarkerStyle.Circle;
            srsUpperLimit.MarkerColor = Color.Magenta;


            chartQC.ChartAreas[0].AxisY.CustomLabels.Add(0, 5, "UCL");
            chartQC.ChartAreas[0].AxisY.CustomLabels.Add(0, 1, "LCL");
            /*
             
             int element = chartQC.AxisY.CustomLabels.Add(0, 30, "Low");
            element = chartQC.ChartAreas["Default"].AxisY.CustomLabels.Add(30, 70, "Medium");
            element = chartQC.ChartAreas["Default"].AxisY.CustomLabels.Add(70, 100, "High");
            */
            Series srsLowerLimit = chartQC.Series.Add("Lower Control Limit (LCL)");
            srsLowerLimit.ChartType = SeriesChartType.Line;
            srsLowerLimit.MarkerColor = Color.Black;
            srsLowerLimit.BorderWidth = 4;
            srsLowerLimit.AxisLabel = "LCL";
            //double maxX, maxY = 0;

            foreach (var line in CsvReader.ReadFromText(fileContent))
            {
                // Header is handled, each line will contain the actual row data
                // var firstCell = line[0];
                // var byName = line["Column name"];
                srsDefects.Points.AddXY(line[0], line[1]);
                srsUpperLimit.Points.AddXY(0, txbUpperControlLimit.Text);
                srsLowerLimit.Points.AddXY(0, txbLowerControlLimit.Text);

                // Set axis labels
                // srsUpperLimit.Points[0].AxisLabel = "UPPER";
                //srsLowerLimit.Points[0].AxisLabel = "UPPER";
                
            }
            //chartQC.ChartAreas[0].AxisY.CustomLabels.Add(0, txbUpperControlLimit.Text);
            //limits.Points.AddXY(X, LOWER, UPPER);

        }
        private void ShowDataTable()
        {
            //DynamicChartCreation_Load();

            txbFooter.Text = "Not yet implemented";

            // TO DO: Add code to showDataTable a function to display the data in a table in panelContent
            /*
            using (var reader = new StreamReader(fileContent))
            using (var csvFileContent = new CsvReader(reader))
            {
                // Do any configuration to `CsvReader` before creating CsvDataReader.
                using (var csvReader = new CsvDataReader(csvFileContent))
                {
                    var dt = new DataTable();
                    dt.Load(csvReader);
                }
            }
            */
        }
        private void ExportResults()
        {
            // TO DO: Add code to showDataTable a function to exportResults() which exports the resulting plot, 
            //          and table-ized data
            //          Maybe make this output a .BER files
            //          .BER files will be able to be read in... and added to word/pdf reports
            var savedir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var chartOutFile = savedir + "QCchart.png";
            var tableOutFile = savedir + "QCdata.png";
            var msgChartSaveSuccess = string.Empty;
            var msgChartSaveFailed = string.Empty;
            var msgTableSaveSuccess = string.Empty;
            var msgTableSaveFailed = string.Empty;

            this.chartQC.SaveImage(chartOutFile, ChartImageFormat.Png);
            if (File.Exists(chartOutFile))
            {
                msgChartSaveSuccess = "Chart image successfully saved to " + chartOutFile;
                txbFooter.Text = msgChartSaveSuccess;
            }
            else
            {
                msgChartSaveFailed = "Error saving chart to " + chartOutFile;
                txbFooter.Text = msgChartSaveFailed;
            }
            /*
             * // Data Table Save section
            this.tableQC.SaveImage(tableOutFile, ChartImageFormat.Png);
            currentFooterText = txbFooter.Text;
            if (File.Exists(tableOutFile))
            {   
                msgTableSaveSuccess = "Data table image successfully saved to " + tableOutFile;
                txbFooter.Text = currentFooterText + msgTableSaveSuccess;
            }
            else
            {
                msgTableSaveFailed = "Error saving data table to " + tableOutFile;
                txbFooter.Text = currentFooterText + msgTableSaveFailed;

            }
            */
        }
        private void ExportRawData()
        {
            // TO DO: Write a function to export RawData... as slurpped up.
            txbFooter.Text = "Not yet implemented";
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            // TO DO: finish making this thing work!
            switch (actionType)
            {
                // 1. Plot
                // 2. Show Data Table
                // 3. Export Results
                // 4. Export Raw
                case 1:
                    PlotQCChart();
                    break;
                case 2:
                    ShowDataTable();
                    break;
                case 3:
                    ExportResults();
                    break;
                default:
                    ExportRawData();
                    break;
            }
        }


private System.Windows.Forms.DataVisualization.Charting.Chart chartDynamic;

private void DynamicChartCreation_Load(object sender, System.EventArgs e)
{
    // Create a Chart
    chartDynamic = new Chart();

    // Create Chart Area
    ChartArea chtAreaDynamic = new ChartArea();

    // Add Chart Area to the Chart
    //chartDynamic.ChartAreas.Add(chtAreaDynamic);
    this.chartQC.ChartAreas.Add(chtAreaDynamic);
    // Create a data series
    Series series1 = new Series();
    Series series2 = new Series();

    // Add data points to the first series
    series1.Points.Add(34);
    series1.Points.Add(24);
    series1.Points.Add(32);
    series1.Points.Add(28);
    series1.Points.Add(44);

    // Add data points to the second series
    series2.Points.Add(14);
    series2.Points.Add(44);
    series2.Points.Add(24);
    series2.Points.Add(32);
    series2.Points.Add(28);

    // Add series to the chart
    chartDynamic.Series.Add(series1);
    chartDynamic.Series.Add(series2);

    // Set chart control location
    chartDynamic.Location = new System.Drawing.Point(16, 48);

    // Set Chart control size
    chartDynamic.Size = new System.Drawing.Size(360, 260);

    // Add chart control to the form
    this.Controls.AddRange(new System.Windows.Forms.Control[] { this.chartDynamic });
            
}


    }
}
