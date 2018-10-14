using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitapcsharptrenlop
{
    public partial class Form2 : Form
    {
        
        public event EventHandler DataAvailable;
        public Form2()
        {
            InitializeComponent();
        }

        protected virtual void OnDataAvaialbe(EventArgs e)
        {
            EventHandler eh = DataAvailable;
            if (eh != null)
            {
                eh(this, e);
            }
        }

        public string Data
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataAvailable(this, e);
            textBox1.Text = "";
        }
    }
}
