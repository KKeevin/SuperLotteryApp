using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;



namespace SuperLottery
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string a, string b, string c, string d, string e, string f, string g)
        {
            InitializeComponent();
            lbl隨機數_01.Text = a;
            lbl隨機數_02.Text = b;
            lbl隨機數_03.Text = c;
            lbl隨機數_04.Text = d;
            lbl隨機數_05.Text = e;
            lbl隨機數_06.Text = f;
            lbl隨機數_0special.Text = g;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }      

        private void btn關閉_Click(object sender, EventArgs e) 
        {
            DialogResult myResult = MessageBox.Show("玻璃心不敢面對嗎?", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (myResult == DialogResult.Yes)
            {
                MessageBox.Show("好棒，你承認了。你走吧!");
                Close();
            }
            else
            {
                MessageBox.Show("你就是啊= =");
            }
        }

        //---------------------------------------------------
        private void lbl隨機數_01_Click(object sender, EventArgs e)
        {

        }
        private void lbl隨機數_02_Click(object sender, EventArgs e)
        {

        }
        private void lbl隨機數_03_Click(object sender, EventArgs e)
        {
        }
        private void lbl隨機數_04_Click(object sender, EventArgs e)
        {

        }
        private void lbl隨機數_05_Click(object sender, EventArgs e)
        {

        }
        private void lbl隨機數_06_Click(object sender, EventArgs e)
        {

        }
        private void lbl隨機數_0special_Click(object sender, EventArgs e)
        {

        }
        //---------------------------------------------------


        private void btn_bingo_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(lbl隨機數_01.Text) == 0 || Convert.ToInt32(lbl隨機數_02.Text) == 0 || Convert.ToInt32(lbl隨機數_03.Text) == 0 || Convert.ToInt32(lbl隨機數_04.Text) == 0 || Convert.ToInt32(lbl隨機數_05.Text) == 0 || Convert.ToInt32(lbl隨機數_06.Text) == 0 || Convert.ToInt32(lbl隨機數_0special.Text) == 0)
                {
                    MessageBox.Show("您的選號不能為0，麻煩選擇正確", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Close();
                }
                else
                {

                    int[] randomBall = new int[6];
                    Random myRnd = new Random();
                    string answer_sp = myRnd.Next(1, 9).ToString();
                    int chosen_01 = Int32.Parse(lbl隨機數_01.Text);
                    int chosen_02 = Int32.Parse(lbl隨機數_02.Text);
                    int chosen_03 = Int32.Parse(lbl隨機數_03.Text);
                    int chosen_04 = Int32.Parse(lbl隨機數_04.Text);
                    int chosen_05 = Int32.Parse(lbl隨機數_05.Text);
                    int chosen_06 = Int32.Parse(lbl隨機數_06.Text);
                    int chosen_sp = Int32.Parse(lbl隨機數_0special.Text);

                    /*int chosen_02 = Convert.ToInt32(lbl隨機數_02);
                    int chosen_03 = Convert.ToInt32(lbl隨機數_03);
                    int chosen_04 = Convert.ToInt32(lbl隨機數_04);           (暫時不確定寫法)
                    int chosen_05 = Convert.ToInt32(lbl隨機數_05);
                    int chosen_06 = Convert.ToInt32(lbl隨機數_06);
                    int chosen_sp = Convert.ToInt32(lbl隨機數_0special);*/

                    for (int i = 0; i < 6; i++)
                    {
                        //隨機產生1~49
                        randomBall[i] = myRnd.Next(1, 39);

                        for (int j = 0; j < i; j++)
                        {
                            //檢查號碼是否重複
                            while (randomBall[j] == randomBall[i])
                            {
                                j = 0;
                                //重新產生，存回陣列，亂數產生的範圍是1~38
                                randomBall[i] = myRnd.Next(1, 39);
                            }
                        }
                        /*lbl隨機數_01.Text = randomBall[0].ToString();
                        lbl隨機數_02.Text = randomBall[1].ToString();
                        lbl隨機數_03.Text = randomBall[2].ToString();
                        lbl隨機數_04.Text = randomBall[3].ToString();
                        lbl隨機數_05.Text = randomBall[4].ToString();
                        lbl隨機數_06.Text = randomBall[5].ToString();*/

                    }

                    lbl_output.Text = randomBall[0].ToString() + "、" + randomBall[1].ToString() + "、" + randomBall[2].ToString() + "、" + randomBall[3].ToString() + "、" + randomBall[4].ToString() + "、" + randomBall[5].ToString() + "\n特別號: " + answer_sp;
                    /*MessageBox.Show("本期獎號是:\n" + randomBall[0].ToString() + "、" + randomBall[1].ToString() + "、" + randomBall[2].ToString() + "、" + randomBall[3].ToString() + "、" + randomBall[4].ToString() + "、" + randomBall[5].ToString() + "\n特別號是: \n" + answer_sp, "【中獎號碼】", MessageBoxButtons.OK, MessageBoxIcon.Information);*/


                    int count = 0;
                    Boolean count_sp = false;

                    for (int i = 0; i < 6; i++)
                    {
                        if (chosen_01 == randomBall[i])
                        {
                            MessageBox.Show("此號碼" + chosen_01.ToString() + "中囉");
                            count = count + 1;
                        }
                        if (chosen_02 == randomBall[i])
                        {
                            MessageBox.Show("此號碼" + chosen_02.ToString() + "中囉");
                            count = count + 1;
                        }
                        if (chosen_03 == randomBall[i])
                        {
                            MessageBox.Show("此號碼" + chosen_03.ToString() + "中囉");
                            count = count + 1;
                        }
                        if (chosen_04 == randomBall[i])
                        {
                            MessageBox.Show("此號碼" + chosen_04.ToString() + "中囉");
                            count = count + 1;
                        }
                        if (chosen_05 == randomBall[i])
                        {
                            MessageBox.Show("此號碼" + chosen_05.ToString() + "中囉");
                            count = count + 1;
                        }
                        if (chosen_06 == randomBall[i])
                        {
                            MessageBox.Show("此號碼" + chosen_06.ToString() + "中囉");
                            count = count + 1;
                        }
                    }
                    if (chosen_sp == Int32.Parse(answer_sp))
                    {
                        MessageBox.Show("特別號" + chosen_sp.ToString() + "中囉");
                        count_sp = true;
                    }

                    //---------------------------------------------------
                    /************** 中 獎 條 件 句 型 區 ****************/
                    //---------------------------------------------------
                    if (count == 6 && count_sp == true)
                    {
                        DialogResult msg_price = MessageBox.Show("【獲得頭獎】NT$60,000,000", "【中獎提示】", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        count_sp = false;
                        yqq = "【獲得頭獎】NT$60,000,000";
                        if (msg_price == DialogResult.Yes)
                        {
                            Form3 myForm3 = new Form3();
                            myForm3.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("獎金不要，可以給阿彬");
                        }
                    }
                    else if (count == 6 && count_sp == false)
                    {
                        DialogResult msg_price = MessageBox.Show("【獲得貳獎】NT$5,000,000", "【中獎提示】", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        count_sp = false;
                        yqq = "【獲得貳獎】NT$5,000,000";
                        if (msg_price == DialogResult.Yes)
                        {
                            Form3 myForm3 = new Form3();
                            myForm3.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("獎金不要，可以給阿彬");
                        }
                    }
                    //---------------------------------------------------
                    else if (count == 5 && count_sp == true)
                    {
                        DialogResult msg_price = MessageBox.Show("【獲得參獎】NT$150,000", "【中獎提示】", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        count_sp = false;
                        yqq = "【獲得參獎】NT$150,000";
                        if (msg_price == DialogResult.Yes)
                        {
                            Form3 myForm3 = new Form3();
                            myForm3.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("獎金不要，可以給阿彬");
                        }
                    }
                    else if (count == 5 && count_sp == false)
                    {
                        DialogResult msg_price = MessageBox.Show("【獲得肆獎】NT$20,000", "【中獎提示】", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        count_sp = false;
                        yqq = "【獲得肆獎】NT$20,000";
                        if (msg_price == DialogResult.Yes)
                        {
                            Form3 myForm3 = new Form3();
                            myForm3.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("獎金不要，可以給阿彬");
                        }
                    }
                    //---------------------------------------------------
                    else if (count == 4 && count_sp == true)
                    {
                        DialogResult msg_price = MessageBox.Show("【獲得伍獎】NT$4,000", "【中獎提示】", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        count_sp = false;
                        yqq = "【獲得伍獎】NT$4,000";
                        if (msg_price == DialogResult.Yes)
                        {
                            Form3 myForm3 = new Form3();
                            myForm3.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("獎金不要，可以給阿彬");
                        }
                    }
                    else if (count == 4 && count_sp == false)
                    {
                        DialogResult msg_price = MessageBox.Show("恭喜您中獎NT$800", "【中獎提示】", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        count_sp = false;
                        yqq = "恭喜您中獎NT$800";
                        if (msg_price == DialogResult.Yes)
                        {
                            Form3 myForm3 = new Form3();
                            myForm3.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("獎金不要，可以給阿彬");
                        }
                    }
                    //---------------------------------------------------
                    else if (count == 3 && count_sp == true)
                    {
                        DialogResult msg_price = MessageBox.Show("恭喜您中獎NT$400", "【中獎提示】", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        count_sp = false;
                        yqq = "恭喜您中獎NT$400";
                        if (msg_price == DialogResult.Yes)
                        {
                            Form3 myForm3 = new Form3();
                            myForm3.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("獎金不要，可以給阿彬");
                        }
                    }
                    else if (count == 2 && count_sp == true)
                    {
                        DialogResult msg_price = MessageBox.Show("恭喜您中獎NT$200", "【中獎提示】", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        count_sp = false;
                        yqq = "恭喜您中獎NT$200";
                        if (msg_price == DialogResult.Yes)
                        {
                            Form3 myForm3 = new Form3();
                            myForm3.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("獎金不要，可以給阿彬");
                        }
                    }
                    //---------------------------------------------------
                    else if (count == 3 && count_sp == false)
                    {
                        DialogResult msg_price = MessageBox.Show("恭喜您中獎NT$100", "【中獎提示】", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        count_sp = false;
                        yqq = "恭喜您中獎NT$100";
                        if (msg_price == DialogResult.Yes)
                        {
                            Form3 myForm3 = new Form3();
                            myForm3.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("獎金不要，可以給阿彬");
                        }
                    }
                    else if (count == 1 && count_sp == true)
                    {
                        DialogResult msg_price = MessageBox.Show("恭喜您中獎NT$100", "【中獎提示】", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        count_sp = false;
                        yqq = "恭喜您中獎NT$100";
                        if (msg_price == DialogResult.Yes)
                        {
                            Form3 myForm3 = new Form3();
                            myForm3.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("100元不要，就給阿彬");
                        }
                    }
                    //---------------------------------------------------
                    else
                    {
                        MessageBox.Show("再接再厲");
                        count_sp = false;
                        yqq = "再接再厲";
                    }
                    //---------------------------------------------------
                    /*lbl_result.Text = "本期號碼如下";
                    lbl隨機數_01.Text = randomBall[0].ToString();                
                    lbl隨機數_02.Text = randomBall[1].ToString();                
                    lbl隨機數_03.Text = randomBall[2].ToString();           //遺 跡    
                    lbl隨機數_04.Text = randomBall[3].ToString();                
                    lbl隨機數_05.Text = randomBall[4].ToString();                
                    lbl隨機數_06.Text = randomBall[5].ToString();
                    lbl隨機數_0special.Text = answer_sp;        */

                }

            }
            catch (Exception Error)
            {
                MessageBox.Show("你還沒選號喔，請出去確認選號完畢", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
        }

        string yqq = "獎號揭曉後，方可查詢中獎金額";

        private void lbl_output_click(object sender, EventArgs e)
        {
            MessageBox.Show(yqq);
        }

        private void notice_lbl_output_Click(object sender, EventArgs e)
        {
            // 建立the ToolTip 
            ToolTip toolTip1 = new ToolTip();
            // 設定顯示樣式
            toolTip1.AutoPopDelay = 5000;//提示資訊的可見時間
            toolTip1.InitialDelay = 35;//事件觸發多久後出現提示
            toolTip1.ReshowDelay = 500;//指標從一個控制元件移向另一個控制元件時，經過多久才會顯示下一個提示框
            toolTip1.ShowAlways = true;//是否顯示提示框
            //  設定伴隨的物件.
            toolTip1.SetToolTip(lbl_output, "點擊後: 查詢中獎金額");
        }

        private void lbl_result_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
