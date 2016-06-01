using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace UDP_klient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string host = textBox1.Text; //dopisuejmy
            int port = System.Convert.ToInt16(numericUpDown1.Value); //dopisuejmy


            try
            {
                UdpClient klient = new UdpClient(host, port); //dopisuejmy
                Byte[] dane = Encoding.ASCII.GetBytes(textBox3.Text); //dopisuejmy
                klient.Send(dane, dane.Length); //dopisuejmy
                listBox1.Items.Add("Wysłanie wiadomości do hosta" + host + ":" + port); //dopisuejmy
                klient.Close(); //dopisuejmy

            }

            catch (Exception ex) //dopisuejmy
            {
                listBox1.Items.Add("Błąd: Nie udało się wysłać wiadmości!");
                MessageBox.Show(ex.ToString(), "Błąd");

            }

        }
    }
}
