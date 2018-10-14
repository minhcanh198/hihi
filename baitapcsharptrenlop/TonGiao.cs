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
    public partial class TonGiao : UserControl
    {
        public TonGiao()
        {
            InitializeComponent();
        }

        private void tongiao_Load(object sender, EventArgs e)
        {
            comboBox3.Items.Add("Không");
            comboBox3.Items.Add("Thiên Chúa");
            comboBox3.Items.Add("Phật");
            comboBox3.Items.Add("Hindu");
            comboBox3.Items.Add("Hồi");
            comboBox3.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 miniform = new Form2();
            miniform.Text = "Tôn Giáo";
            miniform.DataAvailable += new EventHandler(child_tg_DataAvailable);

            miniform.ShowDialog();
        }

        private void child_tg_DataAvailable(object sender, EventArgs e)
        {
            Form2 child = sender as Form2;
            if (child != null)
            {
                comboBox3.Items.Add(child.Data);
            }
        }
    }
}
