using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperLottery
{
    public partial class Form4choose : Form
    {

        public List<Button> listbutton = new List<Button>();
        public List<int> num = new List<int>();
        public List<int> sp = new List<int>();
        int x, y = 0;

        public Form4choose()
        {
            InitializeComponent();
        }

        private void Form4choose_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            Choose_6_1();
            MessageBox.Show("選取6組號碼及1組特別號");
        }

        public void button_Click(object sender, EventArgs e)
        {

            Button mybtn = (Button)sender;
            if (mybtn.BackColor == Color.Olive)
            {
                mybtn.BackColor = Color.YellowGreen;
                mybtn.ForeColor = Color.White;
                x--;
            }

            else
            {
                mybtn.BackColor = Color.Olive;
                mybtn.ForeColor = Color.White;

                num.Add(Convert.ToInt32(mybtn.Text));
                x++;
            }

        }
        public void sp_Click(object sender, EventArgs e)
        {

            Button mybtn = (Button)sender;
            if (mybtn.BackColor == Color.Red)
            {
                mybtn.BackColor = Color.White;
                mybtn.ForeColor = Color.Black;
                y--;
            }

            else
            {
                mybtn.BackColor = Color.Red;
                mybtn.ForeColor = Color.White;

                sp.Add(Convert.ToInt32(mybtn.Text));
                y++;
            }

        }

        void Choose_6_1()
        {
            int aa = 0;
            int b = 10;
            for (int i = 0; i < 4; i += 1)
            {
                if (i == 3)
                {
                    b = 8;
                }

                for (int j = 0; j < b; j += 1)
                {
                    aa += 1;
                    Button button = new Button();
                    button.BackColor = Color.YellowGreen;
                    button.ForeColor = Color.White;
                    button.Font = new Font("MV Boli", 14);
                    button.Text = aa.ToString();
                    button.Location = new Point(80 + 65 * j, 30 + 70 * i);
                    button.Size = new Size(55, 55);
                    button.Click += new EventHandler(button_Click);

                    listbutton.Add(button);
                    Controls.Add(button);
                }

            }
            aa = 0;
            for (int i = 0; i < 8; i++)
            {
                aa += 1;
                Button button = new Button();
                button.BackColor = Color.White;
                button.ForeColor = Color.Black;
                button.Font = new Font("MV Boli", 14);
                button.Text = aa.ToString();
                button.Location = new Point(80 + 65 * i, 55 + 70 * 4);
                button.Size = new Size(55, 55);
                button.Click += new EventHandler(sp_Click);

                listbutton.Add(button);
                Controls.Add(button);
            } 
        }

        private void btn_sent_Click(object sender, EventArgs e)
        {
            if (x != 6 || y != 1)
            {
                MessageBox.Show("請選取6組號碼及1組特別號");
                Form Form1 = (Form1)this.Owner;
            }
            else
            {
                Form Form1 = (Form1)this.Owner;
                Form1.Controls["lbl隨機數_1"].Text = String.Format("{0:D2}", num[0]);
                Form1.Controls["lbl隨機數_2"].Text = String.Format("{0:D2}", num[1]);
                Form1.Controls["lbl隨機數_3"].Text = String.Format("{0:D2}", num[2]);
                Form1.Controls["lbl隨機數_4"].Text = String.Format("{0:D2}", num[3]);
                Form1.Controls["lbl隨機數_5"].Text = String.Format("{0:D2}", num[4]);
                Form1.Controls["lbl隨機數_6"].Text = String.Format("{0:D2}", num[5]);
                Form1.Controls["lbl隨機數_special"].Text = String.Format("{0:D2}", sp[0]);
                MessageBox.Show("已儲存您的選號");
                Close();
            }
        }
    }
}
