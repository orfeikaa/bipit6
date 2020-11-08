using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Клиент
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client s = new ServiceReference1.Service1Client("NetTcpBinding_IService1");
            DataSet ds = s.GetData();
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Update();

            DataSet ds1 = s.FillFIO();
            comboBox1.DataSource = ds1.Tables[0];
            comboBox1.DisplayMember = "FIO";
            comboBox1.ValueMember = "ID_FIO";

            DataSet ds2 = s.FillAvto();
            comboBox2.DataSource = ds2.Tables[0];
            comboBox2.DisplayMember = "Model_avto";
            comboBox2.ValueMember = "ID_AVTO";

        }

        private void Button_add_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client s = new ServiceReference1.Service1Client("NetTcpBinding_IService1");
            string ID_FIO = comboBox1.SelectedValue.ToString();
            string ID_AVTO = comboBox2.SelectedValue.ToString();
            string Data_vzitia = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string Data_zdachi = dateTimePicker2.Value.ToString("yyyy-MM-dd");

            s.NewRec(ID_FIO, ID_AVTO, Data_vzitia, Data_zdachi);
            Form1_Load(sender, e);
        }
    }
}
