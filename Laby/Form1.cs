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

namespace Laby
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Connect_Click(object sender, EventArgs e)
        {
            string host = Adress.Text;
            int p = Convert.ToInt16(port.Value);
            try
            {
                TcpClient client = new TcpClient(host, p);
                info_feed.Items.Add("Connection has been established with " + host + " on a port " + p);
                client.Close();
            }catch (Exception ex)
            {
                info_feed.Items.Add("Couldn't connect. Error: " + ex.ToString()); 
            }
           
        }
    }
}
