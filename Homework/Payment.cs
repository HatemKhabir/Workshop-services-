using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;
using AQXBY9.Classes;

namespace Homework
{
    public partial class Payment : Form
    {
        private  totalPayment? payment;
        private Worksheet worksheet=null;
        
        public Payment()
        {
            InitializeComponent();
        }
        public Payment(Form worksheet1)
        {
            this.worksheet = worksheet1 as Worksheet;
            payment = this.worksheet.totallpayment();
            InitializeComponent(); 
            
        }
        
        private String totalExpectedTime(int timeCost)
        {
            int totalminutes =0;
            String time = "";
            totalminutes = (timeCost / 250);
            time = ((totalminutes / 60).ToString()) + "Hr" + ((totalminutes % 60).ToString()) + "mins";

            return time;
        }

        public void Payment_Load(object sender, EventArgs e)
        {if (payment != null || worksheet!=null)
            {
                materialcostt.Text = payment.totalMaterialPrice.ToString();
                timecostt.Text = payment.totalTimePrice.ToString();
                totalcostt.Text = payment.totalWorksheetPrices.ToString();
                label6.Text = totalExpectedTime((int)payment.totalTimePrice);
                workcountt.Text = worksheet.WorksheetsCreated.ToString();

            }
            this.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Work> works = this.worksheet.works();
            materialcostt.Text = "";
            timecostt.Text = "";
            totalcostt.Text = "";
            workcountt.Text = "";
            payment.totalMaterialPrice = 0;
            payment.totalTimePrice = 0;
            payment.totalWorksheetPrices = 0;
            Worksheet worksheet = new Worksheet(works);
            worksheet.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void workcountt_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            List<Work> works = this.worksheet.works();
            Worksheet worksheet = new Worksheet(works);
            this.Hide();
            worksheet.ShowDialog();
            
        }
    }
}
