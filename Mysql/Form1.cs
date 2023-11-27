using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mysql.iptclass;

namespace Mysql
{
    public partial class Form1 : Form
    {
        mysqlconnect con = new mysqlconnect();
        public Form1()
        {
            InitializeComponent();
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                con.connectdb.Open();
                label1.Text = "You are Connected to MySql Database!";
                label1.ForeColor = Color.Green;
                con.connectdb.Close();
            }
            catch (Exception)
            {

                label1.Text = "Failed to Connect to MySql Database!";
                label1.ForeColor = Color.Red;
            }
        }
    }
}
