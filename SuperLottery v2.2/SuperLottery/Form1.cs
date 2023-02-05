using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;


namespace SuperLottery
{
    public partial class Form1 : Form
    {
        int c_count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            lbl隨機數_1.Text = "財";
            lbl隨機數_2.Text = "神";
            lbl隨機數_3.Text = "來";
            lbl隨機數_4.Text = "到";
            lbl隨機數_5.Text = "我";
            lbl隨機數_6.Text = "家";
            lbl隨機數_special.Text = "門";
        }

        //----------------------------------------------------------
        private void lbl隨機數_01_Click(object sender, EventArgs e)
        {
            if (c_count > 0)
            {
                String s1 = Interaction.InputBox("請輸入號碼(1~38)", "選擇號碼", lbl隨機數_1.Text, -1, -1);
                this.lbl隨機數_1.Text = s1;

                try
                {
                    if (s1 == "")
                    {
                        MessageBox.Show("選號不能為空白");
                        lbl隨機數_1.Text = "重填";
                    }
                    else if (Regex.IsMatch(s1, @"^[0-9]+$") == false)
                    {
                        MessageBox.Show("請輸入正確數字");
                        lbl隨機數_1.Text = "重填";
                    }
                    else if (int.Parse(s1) > 38)
                    {
                        MessageBox.Show("數字請輸入1~38之間");
                        lbl隨機數_1.Text = "重填";
                    }
                    else if (int.Parse(s1) < 0)
                    {
                        MessageBox.Show("數字請輸入1~38之間");
                        lbl隨機數_1.Text = "重填";
                    }
                    else if (int.Parse(s1) == 0)
                    {
                        MessageBox.Show("數字不能為0，請填寫1~38");
                        lbl隨機數_1.Text = s1;
                    }
                    else if (int.Parse(s1) == int.Parse(lbl隨機數_2.Text) || int.Parse(s1) == int.Parse(lbl隨機數_3.Text) || int.Parse(s1) == int.Parse(lbl隨機數_4.Text) || int.Parse(s1) == int.Parse(lbl隨機數_5.Text) || int.Parse(s1) == int.Parse(lbl隨機數_6.Text))
                    {
                        MessageBox.Show("不能重複");
                        lbl隨機數_1.Text = "重填";
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("填寫錯誤");
                    lbl隨機數_1.Text = "重填";
                }
            }
            else
            {
                MessageBox.Show("此操作請先完成[隨機選號]或[自行選號]功能後方能各自進行變更。", "各別選號功能", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lbl隨機數_02_Click(object sender, EventArgs e)
        {
            if (c_count > 0)
            {
                String s2 = Interaction.InputBox("請輸入號碼(1~38)", "選擇號碼", lbl隨機數_2.Text, -1, -1);
                this.lbl隨機數_2.Text = s2;

                try
                {

                    if (s2 == "")
                    {
                        MessageBox.Show("選號不能為空白");
                        lbl隨機數_2.Text = "重填";
                    }
                    else if (Regex.IsMatch(s2, @"^[0-9]+$") == false)
                    {
                        MessageBox.Show("請輸入正確數字");
                        lbl隨機數_2.Text = "重填";
                    }
                    else if (int.Parse(s2) > 38)
                    {
                        MessageBox.Show("數字請輸入1~38之間");
                        lbl隨機數_2.Text = "重填";
                    }
                    else if (int.Parse(s2) < 0)
                    {
                        MessageBox.Show("數字請輸入1~38之間");
                        lbl隨機數_2.Text = "重填";
                    }
                    else if (int.Parse(s2) == 0)
                    {
                        MessageBox.Show("數字不能為0，請填寫1~38");
                        lbl隨機數_2.Text = s2;
                    }
                    else if (int.Parse(s2) == int.Parse(lbl隨機數_1.Text) || int.Parse(s2) == int.Parse(lbl隨機數_3.Text) || int.Parse(s2) == int.Parse(lbl隨機數_4.Text) || int.Parse(s2) == int.Parse(lbl隨機數_5.Text) || int.Parse(s2) == int.Parse(lbl隨機數_6.Text))
                    {
                        MessageBox.Show("不能重複");
                        lbl隨機數_2.Text = "重填";
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("填寫錯誤");
                    lbl隨機數_2.Text = "重填";
                }
            }
            else
            {
                MessageBox.Show("此操作請先完成[隨機選號]或[自行選號]功能後方能各自進行變更。", "各別選號功能", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lbl隨機數_03_Click(object sender, EventArgs e)
        {
            if (c_count > 0)
            {
                String s3 = Interaction.InputBox("請輸入號碼(1~38)", "選擇號碼", lbl隨機數_3.Text, -1, -1);
                this.lbl隨機數_3.Text = s3;

                try
                {
                    if (s3 == "")
                    {
                        MessageBox.Show("選號不能為空白");
                        lbl隨機數_3.Text = "重填";
                    }
                    else if (Regex.IsMatch(s3, @"^[0-9]+$") == false)
                    {
                        MessageBox.Show("請輸入正確數字");
                        lbl隨機數_3.Text = "重填";
                    }
                    else if (int.Parse(s3) > 38)
                    {
                        MessageBox.Show("數字請輸入1~38之間");
                        lbl隨機數_3.Text = "重填";
                    }
                    else if (int.Parse(s3) < 0)
                    {
                        MessageBox.Show("數字請輸入1~38之間");
                        lbl隨機數_3.Text = "重填";
                    }
                    else if (int.Parse(s3) == 0)
                    {
                        MessageBox.Show("數字不能為0，請填寫1~38");
                        lbl隨機數_3.Text = s3;
                    }
                    else if (int.Parse(s3) == int.Parse(lbl隨機數_1.Text) || int.Parse(s3) == int.Parse(lbl隨機數_2.Text) || int.Parse(s3) == int.Parse(lbl隨機數_4.Text) || int.Parse(s3) == int.Parse(lbl隨機數_5.Text) || int.Parse(s3) == int.Parse(lbl隨機數_6.Text))
                    {
                        MessageBox.Show("不能重複");
                        lbl隨機數_3.Text = "重填";
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("填寫錯誤");
                    lbl隨機數_3.Text = "重填";
                }
            }
            else
            {
                MessageBox.Show("此操作請先完成[隨機選號]或[自行選號]功能後方能各自進行變更。", "各別選號功能", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lbl隨機數_04_Click(object sender, EventArgs e)
        {
            if (c_count > 0)
            {
                String s4 = Interaction.InputBox("請輸入號碼(1~38)", "選擇號碼", lbl隨機數_4.Text, -1, -1);
                this.lbl隨機數_4.Text = s4;

                try
                {
                    if (s4 == "")
                    {
                        MessageBox.Show("選號不能為空白");
                        lbl隨機數_4.Text = "重填";
                    }
                    else if (Regex.IsMatch(s4, @"^[0-9]+$") == false)
                    {
                        MessageBox.Show("請輸入正確數字");
                        lbl隨機數_4.Text = "重填";
                    }
                    else if (int.Parse(s4) > 38)
                    {
                        MessageBox.Show("數字請輸入1~38之間");
                        lbl隨機數_4.Text = "重填";
                    }
                    else if (int.Parse(s4) < 0)
                    {
                        MessageBox.Show("數字請輸入1~38之間");
                        lbl隨機數_4.Text = "重填";
                    }
                    else if (int.Parse(s4) == 0)
                    {
                        MessageBox.Show("數字不能為0，請填寫1~38");
                        lbl隨機數_4.Text = s4;
                    }
                    else if (int.Parse(s4) == int.Parse(lbl隨機數_1.Text) || int.Parse(s4) == int.Parse(lbl隨機數_2.Text) || int.Parse(s4) == int.Parse(lbl隨機數_3.Text) || int.Parse(s4) == int.Parse(lbl隨機數_5.Text) || int.Parse(s4) == int.Parse(lbl隨機數_6.Text))
                    {
                        MessageBox.Show("不能重複");
                        lbl隨機數_4.Text = "重填";
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("填寫錯誤");
                    lbl隨機數_4.Text = "重填";
                }
            }
            else
            {
                MessageBox.Show("此操作請先完成[隨機選號]或[自行選號]功能後方能各自進行變更。", "各別選號功能", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lbl隨機數_05_Click(object sender, EventArgs e)
        {
            if (c_count >0)
            {
                String s5 = Interaction.InputBox("請輸入號碼(1~38)", "選擇號碼", lbl隨機數_5.Text, -1, -1);
                this.lbl隨機數_5.Text = s5;

                try
                {
                    if (s5 == "")
                    {
                        MessageBox.Show("選號不能為空白");
                        lbl隨機數_5.Text = "重填";
                    }
                    else if (Regex.IsMatch(s5, @"^[0-9]+$") == false)
                    {
                        MessageBox.Show("請輸入正確數字");
                        lbl隨機數_5.Text = "重填";
                    }
                    else if (int.Parse(s5) > 38)
                    {
                        MessageBox.Show("數字請輸入1~38之間");
                        lbl隨機數_5.Text = "重填";
                    }
                    else if (int.Parse(s5) < 0)
                    {
                        MessageBox.Show("數字請輸入1~38之間");
                        lbl隨機數_5.Text = "重填";
                    }
                    else if (int.Parse(s5) == 0)
                    {
                        MessageBox.Show("數字不能為0，請填寫1~38");
                        lbl隨機數_5.Text = s5;
                    }
                    else if (int.Parse(s5) == int.Parse(lbl隨機數_1.Text) || int.Parse(s5) == int.Parse(lbl隨機數_2.Text) || int.Parse(s5) == int.Parse(lbl隨機數_3.Text) || int.Parse(s5) == int.Parse(lbl隨機數_4.Text) || int.Parse(s5) == int.Parse(lbl隨機數_6.Text))
                    {
                        MessageBox.Show("不能重複");
                        lbl隨機數_5.Text = "重填";
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("填寫錯誤");
                    lbl隨機數_5.Text = "重填";
                }
            }
            else
            {
                MessageBox.Show("此操作請先完成[隨機選號]或[自行選號]功能後方能各自進行變更。", "各別選號功能", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lbl隨機數_06_Click(object sender, EventArgs e)
        {
            if (c_count >0)
            {
                String s6 = Interaction.InputBox("請輸入號碼(1~38)", "選擇號碼", lbl隨機數_6.Text, -1, -1);
                this.lbl隨機數_6.Text = s6;

                try
                {
                    if (s6 == "")
                    {
                        MessageBox.Show("選號不能為空白");
                        lbl隨機數_6.Text = "重填";
                    }
                    else if (Regex.IsMatch(s6, @"^[0-9]+$") == false)
                    {
                        MessageBox.Show("請輸入正確數字");
                        lbl隨機數_6.Text = "重填";
                    }
                    else if (int.Parse(s6) > 38)
                    {
                        MessageBox.Show("數字請輸入1~38之間");
                        lbl隨機數_6.Text = "重填";
                    }
                    else if (int.Parse(s6) < 0)
                    {
                        MessageBox.Show("數字請輸入1~38之間");
                        lbl隨機數_6.Text = "重填";
                    }
                    else if (int.Parse(s6) == 0)
                    {
                        MessageBox.Show("數字不能為0，請填寫1~38");
                        lbl隨機數_6.Text = s6;
                    }
                    else if (int.Parse(s6) == int.Parse(lbl隨機數_1.Text) || int.Parse(s6) == int.Parse(lbl隨機數_2.Text) || int.Parse(s6) == int.Parse(lbl隨機數_3.Text) || int.Parse(s6) == int.Parse(lbl隨機數_4.Text) || int.Parse(s6) == int.Parse(lbl隨機數_5.Text))
                    {
                        MessageBox.Show("不能重複");
                        lbl隨機數_6.Text = "重填";
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("填寫錯誤");
                    lbl隨機數_6.Text = "重填";
                }
            }
            else
            {
                MessageBox.Show("此操作請先完成[隨機選號]或[自行選號]功能後方能各自進行變更。", "各別選號功能", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lbl隨機數_special_Click(object sender, EventArgs e)
        {
            if (c_count > 0)
            {
                String ssp = Interaction.InputBox("請輸入特別號(1~8)", "選擇號碼", lbl隨機數_special.Text, -1, -1);
                this.lbl隨機數_special.Text = ssp;

                try
                {
                    if (ssp == "")
                    {
                        MessageBox.Show("選號不能為空白");
                        lbl隨機數_special.Text = "重填";
                    }
                    else if (Regex.IsMatch(ssp, @"^[0-9]+$") == false)
                    {
                        MessageBox.Show("請輸入正確數字");
                        lbl隨機數_special.Text = "重填";
                    }
                    else if (int.Parse(ssp) > 8)
                    {
                        MessageBox.Show("數字請輸入1~8之間");
                        lbl隨機數_special.Text = "重填";
                    }
                    else if (int.Parse(ssp) == 0)
                    {
                        MessageBox.Show("數字不能為0，請輸入1~8的數字");
                        lbl隨機數_special.Text = ssp;
                    }
                    else if (int.Parse(ssp) < 0)
                    {
                        MessageBox.Show("號碼沒有負數，請輸入1~8的數字");
                        lbl隨機數_special.Text = "重填";
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("填寫錯誤");
                    lbl隨機數_special.Text = "重填";
                }
            }
            else
            {
                MessageBox.Show("此操作請先完成[隨機選號]或[自行選號]功能後方能各自進行變更。", "各別選號功能", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //----------------------------------------------------------

        private void Notice_btn產生隨機亂數(object sender, EventArgs e)
        {
            // 建立the ToolTip 
            ToolTip toolTip1 = new ToolTip();
            // 設定顯示樣式
            toolTip1.AutoPopDelay = 5000;//提示資訊的可見時間
            toolTip1.InitialDelay = 300;//事件觸發多久後出現提示
            toolTip1.ReshowDelay = 500;//指標從一個控制元件移向另一個控制元件時，經過多久才會顯示下一個提示框
            toolTip1.ShowAlways = true;//是否顯示提示框
            //  設定伴隨的物件.
            toolTip1.SetToolTip(btn產生隨機亂數, "點擊後: 電腦選號乙張威力彩券");
        }
        private void btn產生隨機亂數_Click(object sender, EventArgs e)
        {

            if (c_count >=0)
            {
                c_count ++;
            }
            
            int[] randomBall = new int[6];
            Random myRnd = new Random();

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
                lbl隨機數_1.Text = randomBall[0].ToString();
                lbl隨機數_2.Text = randomBall[1].ToString();
                lbl隨機數_3.Text = randomBall[2].ToString();
                lbl隨機數_4.Text = randomBall[3].ToString();
                lbl隨機數_5.Text = randomBall[4].ToString();
                lbl隨機數_6.Text = randomBall[5].ToString();

            }
            lbl隨機數_special.Text = myRnd.Next(1, 9).ToString();
        }

        private void 開啟Form2_Click(object sender, EventArgs e)
        {
            Form2 myForm2 = new Form2(lbl隨機數_1.Text, lbl隨機數_2.Text, lbl隨機數_3.Text, lbl隨機數_4.Text, lbl隨機數_5.Text, lbl隨機數_6.Text, lbl隨機數_special.Text);
            //myForm2.Show();
            myForm2.ShowDialog(); //獨佔開啟

        }

        private void img_doge_Click(object sender, EventArgs e)
        {
            MessageBox.Show("向你說: 怎麼亂摸人家0/////0", "DOGE");
        }

        private void img_DGDZ_Click(object sender, EventArgs e)
        {
            MessageBox.Show("本程式讓您輕鬆發大財", "高雄發大財");
        }

        private void btnChooses_Click(object sender, EventArgs e)
        {
            Form4choose Form4 = new Form4choose();
            //myForm2.Show();
            Form4.ShowDialog(this); //獨佔開啟
        }

        private void btn_self61_Click(object sender, EventArgs e)
        {
            if (c_count >= 0)
            {
                c_count++;
            }
            Form4choose Form4 = new Form4choose();
            //myForm2.Show();
            Form4.ShowDialog(this); //獨佔開啟
        }

        private void btn_rules_Click(object sender, EventArgs e)
        {
            Form5 Form5 = new Form5();
            //myForm2.Show();
            Form5.Show();
        }

        // ctrl+shift+a 產生新的
    }
}
