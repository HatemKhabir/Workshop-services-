using AQXBY9.Classes;
using System.Xml.Linq;

namespace Homework
{
    public partial class Home : Form
    {
       
        private List<Work> workTypes=new List<Work>();
        public Home()
        {
            InitializeComponent();
        }

        private void loadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String filepath = "";
            Loader loader=new Loader();
           workTypes=loader.loader<Work>(filepath);
                if (filepath==null||workTypes.Count==0)
                {
                    MessageBox.Show("File is Empty Please choose another File ! ");
                }else
                {
                    worksheetsToolStripMenuItem.Enabled = true;
                    paymentToolStripMenuItem.Enabled = true;
                }

        }

    


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to exit.", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void worksheetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Worksheet worksheet = new Worksheet(workTypes);
            worksheet.ShowDialog();

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime current = DateTime.Now;
            MessageBox.Show("Neptun Code : AQXBY9 \n" + current.ToString());
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.Payment_Load(sender, e);
        }

        
    }
}