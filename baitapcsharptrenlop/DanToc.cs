using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitapcsharptrenlop
{
    public partial class DanToc : UserControl
    {
        public DanToc()
        {
            InitializeComponent();
        }

        private void dantoc_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Add("Kinh");
            comboBox2.Items.Add("Ede");
            comboBox2.Items.Add("Bana");
            comboBox2.Items.Add("Hmong");
            comboBox2.Items.Add("Dao");
            comboBox2.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form2 miniform = new Form2();
            miniform.Text = "Dân Tộc";
            miniform.DataAvailable += new EventHandler(child_dt_DataAvailable);

            miniform.ShowDialog();
        }
        private void child_dt_DataAvailable(object sender, EventArgs e)
        {
            Form2 child = sender as Form2;
            if (child != null)
            {
                comboBox2.Items.Add(child.Data);
            }
        }
    }
}
