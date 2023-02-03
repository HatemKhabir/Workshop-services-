using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace Homework
{
    public partial class CustomControl1 : UserControl
    {

        private Worksheet? worksheet;

        public string servicename
        {
            get { return serviceName.Text; }
            set { serviceName.Text = value; }
        }
        public string materialcost
        {
            get { return materialCost.Text; }
            set { materialCost.Text = value + " " + "ft"; } 
        }
        
        public string expectedtime
        {
            get { return expectedTime.Text; }
            set { expectedTime.Text = value+"min"; }
        }

        public bool checkbox
        {
            get { return checkBox1.Checked; }
            set { checkBox1.Checked = value; }
        }
        public string timecost
        {
            get { return timeCost.Text; }
            set { timeCost.Text = value; }
        }
        public CustomControl1(Form panels)
        {
            InitializeComponent();
            worksheet = panels as Worksheet;

        }

     
            private void CustomControl1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            System.Collections.IList list = worksheet.panel1.Controls;
            if (this.checkBox1.Checked)
            {
                
                for (int i = 0; i < list.Count; i++)
                {
                    Control ctrl = list[i] as Control;
                    if (ctrl is Label)
                        if (ctrl.Name == "materialCostLabel")
                        {
                            worksheet.MaterialPrice+= Int32.Parse(materialCost.Text.Substring(0, (materialCost.Text.IndexOf('f') - 1)));
                            ctrl.Text = worksheet.MaterialPrice.ToString();
                        }
                    if (ctrl.Name == "timeCostLabel")
                    {
                        worksheet.TimeCostPrice += Worksheet.timeCost(expectedtime);
                        ctrl.Text = worksheet.TimeCostPrice.ToString();

                    }
                    if (ctrl.Name == "totalCostLabel")
                    {
                        worksheet.TotalCostPrice += (Int32.Parse(materialCost.Text.Substring(0, (materialCost.Text.IndexOf('f') - 1))) + Worksheet.timeCost(expectedtime));
                        ctrl.Text = worksheet.TotalCostPrice.ToString();
                    }
                }
                timeCost.Text = Worksheet.timeCost(expectedtime).ToString();
                
            }
            else if (!this.checkBox1.Checked)
            {
               
                for (int i = 0; i < list.Count; i++)
                {
                    Control ctrl = list[i] as Control;
                    if (ctrl is Label)
                        if (ctrl.Name == "materialCostLabel")
                        {
                            worksheet.MaterialPrice -= Int32.Parse(materialCost.Text.Substring(0, (materialCost.Text.IndexOf('f') - 1)));
                            ctrl.Text = worksheet.MaterialPrice.ToString();
                        }
                    if (ctrl?.Name == "timeCostLabel")
                    {
                        worksheet.TimeCostPrice -= Worksheet.timeCost(expectedtime);
                        ctrl.Text = worksheet.TimeCostPrice.ToString();

                    }
                    if (ctrl?.Name == "totalCostLabel")
                    {
                        worksheet.TotalCostPrice -= (Int32.Parse(materialCost.Text.Substring(0, (materialCost.Text.IndexOf('f') - 1))) + Worksheet.timeCost(expectedtime));
                        ctrl.Text = worksheet.TotalCostPrice.ToString();
                    }
                }
                timeCost.Text = "";

            }
        }
       

        private void timeCost_Click(object sender, EventArgs e)
        {

        }

        private void expectedTime_Click(object sender, EventArgs e)
        {

        }

        private void materialCost_Click(object sender, EventArgs e)
        {

        }

        private void serviceName_Click(object sender, EventArgs e)
        {

        }

      
    }
}
