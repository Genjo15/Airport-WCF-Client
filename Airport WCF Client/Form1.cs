using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airport_WCF_Client
{
    public partial class Form1 : Form
    {
        DataGridView grid = new DataGridView();
        //DataGridView grid2 = new DataGridView();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton.Checked)
            {
                Airport_WCF_Client.AirportService.Vol vol = new Airport_WCF_Client.AirportService.Vol();
                AirportService.Service1Client client = new AirportService.Service1Client();
                vol = client.GetVol(int.Parse(textBox.Text));

                //richTextBox.Text = "ID Vol : " + vol.idVol + "\n" +
                //                   "Compagnie : " + vol.company + "\n" +
                //                   "Ligne n° : " + vol.lineNumber + "\n" +
                //                   "Dernier Enr. : " + vol.lastTime + "\n" +
                //                   "Parking : " + vol.parking + "\n" +
                //                   "Status : " + vol.status + "\n";

                List<Airport_WCF_Client.AirportService.Vol> list = new List<Airport_WCF_Client.AirportService.Vol>();
                list.Add(vol);

                grid.DataSource = list;
                splitContainer.Panel2.Controls.Add(grid);
                grid.Dock = System.Windows.Forms.DockStyle.Fill;
            }

            else if (radioButton2.Checked)
            {
                Airport_WCF_Client.AirportService.Bagage bagage = new AirportService.Bagage();
                AirportService.Service1Client client = new AirportService.Service1Client();
                bagage = client.GetBagage(int.Parse(textBox.Text));

                List<Airport_WCF_Client.AirportService.Bagage> list = new List<AirportService.Bagage>();
                list.Add(bagage);

                grid.DataSource = list;
                splitContainer.Panel2.Controls.Add(grid);
                grid.Dock = System.Windows.Forms.DockStyle.Fill;


            }

            else if (radioButton3.Checked)
            {
                Airport_WCF_Client.AirportService.Bagage[] bagagesList;
                AirportService.Service1Client client = new AirportService.Service1Client();
                bagagesList = client.GetBagagesFromVol(int.Parse(textBox.Text));


                grid.DataSource = bagagesList;
                splitContainer.Panel2.Controls.Add(grid);
                grid.Dock = System.Windows.Forms.DockStyle.Fill;

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label.Text = "Entrer ID du Bagage :";
        }
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            label.Text = "Entrer ID du Vol :";
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label.Text = "Entrer ID du Vol :";
        }
    }
}
