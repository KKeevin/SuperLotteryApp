using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperLottery
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            
        }



        private void Form3_Load(object sender, EventArgs e)
        {
            /*this.MaximizeBox = false;
            this.MinimizeBox = true;*/
            this.ControlBox = false;            
        }


        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
