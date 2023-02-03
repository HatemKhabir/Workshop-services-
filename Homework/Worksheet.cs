using System.Text.RegularExpressions;
using AQXBY9.Classes;

namespace Homework
{
    public partial class Worksheet : Form
    {
        private List<Work> workType;
        private int materialPrice;
        private int timeCostPrice;
        private int totalCostPrice;
        private int worksheetsCreated;
        public int WorksheetsCreated { get { return worksheetsCreated; } set { worksheetsCreated = value; } }
        public int MaterialPrice { get { return materialPrice; }  set { materialPrice = value; } }
        public int TimeCostPrice { get { return timeCostPrice; }  set { timeCostPrice = value; } }
        public int TotalCostPrice { get { return totalCostPrice; }  set { totalCostPrice = value; } }
        
        public List<Work> works()
        {
            return workType;
        }

        private totalPayment totalpayment = new totalPayment()
        {            
            totalMaterialPrice = 0,
            totalTimePrice = 0,
            totalWorksheetPrices = 0,
        };
        public totalPayment totallpayment()
        {
            return totalpayment;
        }
        
        public static int timeCost(string timeData)
        {   int cost = 0;
            String hr = "";
            String min = "";
            int minNumb = 0;
            min = timeData.Substring((timeData.IndexOf('r')) + 1, timeData.IndexOf('m') - (timeData.IndexOf('r') + 1));
            Int32.TryParse(min, out minNumb);
            if (minNumb < 30)
                min = "30";
            if (timeData.Contains('h'))
            {
                hr = timeData.Substring(0, (timeData.IndexOf('h')));
            }
            else return ((Int32.Parse(min)) * 250);
             
            int totaltime = (Int32.Parse(hr)) * 60 + (Int32.Parse(min));
            cost = 250 * totaltime;
            return cost;
        }

       private String convertTime(String timeData)
        {
           
           int mins= int.Parse(Regex.Match(timeData, @"\d+").Value);
            if (mins > 60)
            {
                return (mins / 60 + " hr" + mins % 60);
            }
            else return mins.ToString();


        }
        private void addCustomControl(List <Work> text,FlowLayoutPanel flp)
        {
            flp.Controls.Clear();
            for (int i = 0; i < text.Count - 1; i++)
            {
                CustomControl1 serviceDescription = new CustomControl1(this);
                serviceDescription.Name = "service" + i;
                serviceDescription.servicename = text.ElementAt(i).serviceName();
                serviceDescription.expectedtime = convertTime(text.ElementAt(i).timeInMinutes());
                serviceDescription.materialcost = text.ElementAt(i).materialcost();
                flp.Controls.Add(serviceDescription);

            }
        }

        public Worksheet(List<Work> workType)
        {
            InitializeComponent();
            this.workType = workType;
        }
       

        private void Form2_Load(object sender, EventArgs e)
        {
          materialPrice = 0;
          timeCostPrice = 0;
          totalCostPrice = 0;
            materialCostLabel.Text = "";
            timeCostLabel.Text = "";
            totalCostLabel.Text = "";
        addCustomControl(workType, flowLayoutPanel1);
        }

        
        

        private void button2_Click(object sender, EventArgs e)
        {
            worksheetsCreated++;
            totalpayment.totalMaterialPrice += materialPrice;
            totalpayment.totalTimePrice += timeCostPrice;
            totalpayment.totalWorksheetPrices += totalCostPrice;
            Form2_Load(sender,e);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to exit.", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Payment payment = new Payment(this);
                totalpayment.totalMaterialPrice += materialPrice;
                totalpayment.totalTimePrice += timeCostPrice;
                totalpayment.totalWorksheetPrices += totalCostPrice;
                this.Hide();
                payment.Payment_Load(sender, e);
            }else { button2_Click(sender, e); }
        
        }

        private void Worksheet_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you Want To Leave Registration ? .", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else e.Cancel = true;

        }
    }
}
