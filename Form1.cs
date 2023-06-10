using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oop_SimpleStore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("stockname", "재고명");
            dataGridView1.Columns.Add("stocknumber", "수량");
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(tb_id.Text, tb_number.Text);
        }
    }
}
