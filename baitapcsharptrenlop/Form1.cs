using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace baitapcsharptrenlop
{
    public partial class Form1 : Form
    {
        int count = 0;
        string _message;
        Random randomizer = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(string message) : this()
        {
            _message = message;
            comboBox2.Items.Add(_message);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboboxLoad();
            LoadDataGridView();
        }

        private void mahs_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void LoadDataGridView()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Tên", typeof(string));
            dt.Columns.Add("Ngày Sinh", typeof(string));
            dt.Columns.Add("Giới Tính", typeof(string));
            dt.Columns.Add("Dân Tộc", typeof(string));
            dt.Columns.Add("Tôn Giáo", typeof(string));
            dataGridView1.DataSource = dt;
        }

        //void LoadDataGridview()
        //{
        //    DataTable dt = new DataTable();
        //    dt.Columns.Add("Mã học sinh", typeof(string));
        //    dt.Columns.Add("Họ và tên", typeof(string));
        //    dt.Columns.Add("Giới tính nữ", typeof(bool));
        //    dt.Columns.Add("Ngày sinh", typeof(string));
        //    dt.Columns.Add("Nơi sinh", typeof(string));

        //    dt.Rows.Add("HS001", "Do Minh Tuan", randomizer.Next(2), "25-12-1998", "Ninh Thuan");
        //    dt.Rows.Add("HS001", "Do Minh Tuan", randomizer.Next(2), "25-12-1998", "Ninh Thuan");
        //    dt.Rows.Add("HS001", "Do Minh Tuan", randomizer.Next(2), "25-12-1998", "Ninh Thuan");
        //    dt.Rows.Add("HS001", "Do Minh Tuan", randomizer.Next(2), "25-12-1998", "Ninh Thuan");
        //    dt.Rows.Add("HS001", "Do Minh Tuan", randomizer.Next(2), "25-12-1998", "Ninh Thuan");
        //    dt.Rows.Add("HS001", "Do Minh Tuan", randomizer.Next(2), "25-12-1998", "Ninh Thuan");
        //    dt.Rows.Add("HS001", "Do Minh Tuan", randomizer.Next(2), "25-12-1998", "Ninh Thuan");
        //    dt.Rows.Add("HS001", "Do Minh Tuan", randomizer.Next(2), "25-12-1998", "Ninh Thuan");
        //    dt.Rows.Add("HS001", "Do Minh Tuan", randomizer.Next(2), "25-12-1998", "Ninh Thuan");
        //    dt.Rows.Add("HS001", "Do Minh Tuan", randomizer.Next(2), "25-12-1998", "Ninh Thuan");
        //    dataGridView1.DataSource = dt;

        //    for(int i = 0; i < dataGridView1.ColumnCount - 1; i++)
        //    {
        //        dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        //    }
        //    dataGridView1.Columns[dataGridView1.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        //}

        void comboboxLoad()
        {
            comboBox2.Items.Add("Kinh");
            comboBox2.Items.Add("Ede");
            comboBox2.Items.Add("Bana");
            comboBox2.Items.Add("Hmong");
            comboBox2.Items.Add("Dao");
            comboBox2.SelectedIndex = 0;
            comboBox3.Items.Add("Không");
            comboBox3.Items.Add("Thiên Chúa");
            comboBox3.Items.Add("Phật");
            comboBox3.Items.Add("Hindu");
            comboBox3.Items.Add("Hồi");
            comboBox3.SelectedIndex = 0;


        }


        private void button2_Click(object sender, EventArgs e)
        {

            Form2 miniform = new Form2();
            miniform.Text = "Dân Tộc";
            miniform.DataAvailable += new EventHandler(child_dt_DataAvailable);

            miniform.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 miniform = new Form2();
            miniform.Text = "Tôn Giáo";
            miniform.DataAvailable += new EventHandler(child_tg_DataAvailable);

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
        private void child_tg_DataAvailable(object sender, EventArgs e)
        {
            Form2 child = sender as Form2;
            if (child != null)
            {
                comboBox3.Items.Add(child.Data);
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Text file | *.txt";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sf.FileName);

                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    string s = dataGridView1.Rows[i].Cells["ID"].Value.ToString() + "*"
                        + dataGridView1.Rows[i].Cells["Tên"].Value.ToString() + "*"
                        + dataGridView1.Rows[i].Cells["Ngày Sinh"].Value.ToString() + "*"
                        + dataGridView1.Rows[i].Cells["Giới Tính"].Value.ToString() + "*"
                        + dataGridView1.Rows[i].Cells["Dân Tộc"].Value.ToString() + "*"
                        + dataGridView1.Rows[i].Cells["Tôn Giáo"].Value.ToString();
                    sw.WriteLine(s);
                }
                sw.Close();
            }
            MessageBox.Show("Lưu thành công!!!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (count < 10)
                textBox1.Text = "HS00" + count.ToString();
            else if (count < 100)
                textBox1.Text = "HS0" + count.ToString();
            count++;
        }
        DataTable LoadData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Tên", typeof(string));
            dt.Columns.Add("Ngày Sinh", typeof(string));
            dt.Columns.Add("Giới Tính", typeof(string));
            dt.Columns.Add("Dân Tộc", typeof(string));
            dt.Columns.Add("Tôn Giáo", typeof(string));
            StreamReader sr = new StreamReader("D:\\dslop.txt");
            string str;
            while ((str = sr.ReadLine()) != null)
            {
                string[] st = str.Split('*');
                dt.Rows.Add(st[0], st[1], st[2], st[3], "Kinh", "Không");
            }



            sr.Close();
            return dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = (DataTable)dataGridView1.DataSource;
            string s = "Nữ";
            if (radioButton1.Checked)
                s = "Nam";
            dt.Rows.Add(textBox1.Text, textBox2.Text, dateTimePicker1.Text.ToString(),
                s, comboBox2.Text, comboBox3.Text);
            dataGridView1.DataSource = dt;
        }

        private void openbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Multiselect = false;
            of.Filter = "Text file | *.txt";
            if (of.ShowDialog() == DialogResult.OK)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("ID", typeof(string));
                dt.Columns.Add("Tên", typeof(string));
                dt.Columns.Add("Ngày Sinh", typeof(string));
                dt.Columns.Add("Giới Tính", typeof(string));
                dt.Columns.Add("Dân Tộc", typeof(string));
                dt.Columns.Add("Tôn Giáo", typeof(string));
                StreamReader sr = new StreamReader(of.FileName);
                string str;
                while ((str = sr.ReadLine()) != null)
                {
                    string[] st = str.Split('*');
                    dt.Rows.Add(st[0], st[1], st[2], st[3], "Kinh", "Không");
                }
                sr.Close();
                dataGridView1.DataSource = dt;
            }
        }
        void SaveData()
        {
            StreamWriter sw = new StreamWriter("D:\\filemoighi.txt");

            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                string s = dataGridView1.Rows[i].Cells["ID"].Value.ToString() + "*"
                    + dataGridView1.Rows[i].Cells["Tên"].Value.ToString() + "*"
                    + dataGridView1.Rows[i].Cells["Ngày Sinh"].Value.ToString() + "*"
                    + dataGridView1.Rows[i].Cells["Giới Tính"].Value.ToString() + "*"
                    + dataGridView1.Rows[i].Cells["Dân Tộc"].Value.ToString() + "*"
                    + dataGridView1.Rows[i].Cells["Tôn Giáo"].Value.ToString();
                sw.WriteLine(s);
            }
            sw.Close();
        }


        private void fontbtn_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();

            if (fd.ShowDialog()== DialogResult.OK)
            {
                Font = fd.Font;
            }

        }

        private void Color_button_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog()== DialogResult.OK)
            {
                splitContainer1.BackColor = cd.Color;
                dataGridView1.BackgroundColor = cd.Color;
            }
        }
    }
}
