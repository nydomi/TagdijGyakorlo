using ConsoleAppTagdij;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppBefiz
{
    public partial class Form1 : Form
    {
        static Database db = new Database();
        static List<Befiz> befiz = new List<Befiz>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            befiz = db.getBefiz();
            dbBetolt();
        }
       
        private void dbContent_Enter(object sender, EventArgs e)
        {
            //Ez itt madard mert windows forms
        }

        private void befizSubmit_Click(object sender, EventArgs e)
        {
            befizDatumText.CustomFormat = "yyyy/MM/dd HH:MM";
            addToDB();
        }

        private void dbConetents_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void dbBetolt()
        {
            dbConetents.Items.Clear();
            dbConetents.Items.Add("Azonosító | Név | Összeg");
            for (int i = 0; i < befiz.Count; i++)
            {
                string temp = $"{befiz[i].azon} | {befiz[i].datum} | {befiz[i].osszeg}";
                dbConetents.Items.Add(temp);
            }
        }
        private void addToDB()
        {
            MessageBox.Show(befizAzonText.Text);
            MessageBox.Show(befitzOsszegText.Text);
            MessageBox.Show(befizDatumText.Text);
            if (befizAzonText.Text!=null && befitzOsszegText.Text!= null)
            {
                int nev = int.Parse(befizAzonText.Text);
                int ossz = int.Parse(befitzOsszegText.Text);
                string date = befizDatumText.Text;

                db.hozzaAdDB(nev,ossz,date);
            }
            else
            {
                return;
            }
            
        }
    }
}
