using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baseer4
{
    public partial class formMainScreen : Form
    {
        // TO DO: declare an array - chart_comp[] 
        //          * chart_comp[] holds multiple (max 2, initially) charts to compare
        //          *** if the checkbox on the image is clicked, add to chart_comp
        //          * When chart_comp[] is full, prompt to launch comparison tool
        //          * Launch a MDI form to hold both forms
        //          * 
        public formMainScreen()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonEDAT_Click(object sender, EventArgs e)
        {

            if (checkChart1.Checked)
            {
                
                ShowQC();
            }
        }

        // TO DO: Add arguments to send with ShowQC:
        // i.e. Which chart was checked
        // ShowQC(int chartType);
        private void ShowQC()
        {
            int x, y;
            //panChart1.Show();
            // Create a new Form1 and set its Visible property to true.
            x = this.DesktopLocation.X;
            y = this.DesktopLocation.Y;
            formChart FormQCTool = new formChart();
            FormQCTool.Visible = true;

            // Set the new form's desktop location so it  
            // appears below and to the right of the current form.
            x += 30;
            y += 30;
            FormQCTool.SetDesktopLocation(x, y);

            // Keep the current form active by calling the Activate
            // method.
            //this.Activate();
            this.Hide();
            //this.buttonEDAT.Enabled = false;
        }
        private void EDATChartSelectorHide()
        {
            /* If the panel contains label1, bring it 
            * to the front to make sure it is visible. */
            if (panelContent.Contains(panelEDAT))
            {
                panelEDAT.SendToBack();
            }
            
        }
        private void EDATform1_FormClosed(Object sender, FormClosedEventArgs e)
        {
            //this.Activate();
            //buttonEDAT.Enabled = true;
           /* System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            messageBoxCS.AppendFormat("{0} = {1}", "CloseReason", e.CloseReason);
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} = {1}", "Cancel", e.Cancel);
            messageBoxCS.AppendLine();
            MessageBox.Show(messageBoxCS.ToString(), "FormClosing Event");
            */
        }
    }
}
