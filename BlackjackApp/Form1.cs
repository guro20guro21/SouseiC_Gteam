using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackjackApp
{
    public partial class Form1 : Form
    {
        int hand_m = 0; // 手札の合計(プレイヤー)
        int dealer_m = 0; // 手札の合計(ディーラー)
        int p_draw_count = 0; // ドロー回数
        int d_draw_count = 0; // ディーラーのドロー回数
        int a_count = 0; // Aが有るか無いか
        int aplus_count = 0; // Aを11で処理した証拠
        int Wresult = 0; // 勝利回数
        int Lresult = 0; // 敗北回数
        int Dresult = 0; // 引き分け回数
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // textBox1の値を初期化
            textBox1.Text = "";

            // Hitするごとに画像を更新、保存
            if (p_draw_count == 1)
            {
                pictureBox3.ImageLocation = pictureBox1.ImageLocation;
            }
            else if(p_draw_count == 2)
            {
                pictureBox4.ImageLocation = pictureBox1.ImageLocation;
            }
            else if (p_draw_count == 3)
            {
                pictureBox5.ImageLocation = pictureBox1.ImageLocation;
            }
            else if (p_draw_count == 4)
            {
                pictureBox6.ImageLocation = pictureBox1.ImageLocation;
            }
            else if (p_draw_count == 5)
            {
                pictureBox7.ImageLocation = pictureBox1.ImageLocation;
            }
            else if (p_draw_count == 6)
            {
                pictureBox8.ImageLocation = pictureBox1.ImageLocation;
            }
            else if (p_draw_count == 7)
            {
                pictureBox9.ImageLocation = pictureBox1.ImageLocation;
            }
            else if (p_draw_count == 8)
            {
                pictureBox10.ImageLocation = pictureBox1.ImageLocation;
            }
            else if (p_draw_count == 9)
            {
                pictureBox11.ImageLocation = pictureBox1.ImageLocation;
            }
            else if (p_draw_count == 10)
            {
                pictureBox12.ImageLocation = pictureBox1.ImageLocation;
            }
            Random pRandom = new System.Random(); // 乱数の生成
            int result = pRandom.Next(1, 14); // カードの番号(1～13)
            int result_m = pRandom.Next(1, 5); // マーク(1:ス 2:ク 3:ダ 4:ハ) 
            if(button1.Text == "Hit") // Hitの処理
            {
                if (result_m == 1) // スペードカードの処理
                {
                    textBox1.Text += "スペードの" + result.ToString();
                    if (result == 1)
                    {
                        a_count++; // Aが出たことをカウント、他マークでも同処理
                        pictureBox1.ImageLocation = "https://2.bp.blogspot.com/-S-31SRfkS1o/WQBAEtCo1nI/AAAAAAABD98/fzjjCIIibhMkeoKx9NfyTo3i1TjRaONPQCLcB/s800/card_spade_01.png";
                    }
                    else if (result == 2)
                    {
                        pictureBox1.ImageLocation = "https://4.bp.blogspot.com/-HUJzhH60Cf0/WQBAFMX2JoI/AAAAAAABD-E/ApHn1B1nwtA6eg1WDh2xWyialgCcPEIRgCLcB/s800/card_spade_02.png";
                    }
                    else if (result == 3)
                    {
                        pictureBox1.ImageLocation = "https://1.bp.blogspot.com/-r6YgdswwjD4/WQBAFIyHimI/AAAAAAABD-I/_5U9DZ-tV1IEmoTgbgdSt0OCS9ujA-6IwCLcB/s800/card_spade_03.png";
                    }
                    else if (result == 4)
                    {
                        pictureBox1.ImageLocation = "https://2.bp.blogspot.com/-V0P8AZskntU/WQBAFXXQo8I/AAAAAAABD-M/hnZFQ7J6xSMTtVPvwH2AAKKSlRPEVTH7ACLcB/s800/card_spade_04.png";
                    }
                    else if (result == 5)
                    {
                        pictureBox1.ImageLocation = "https://4.bp.blogspot.com/-bvSGYORb6Xg/WQBAF61kUOI/AAAAAAABD-Q/SalVkKKYYt85TNJJsOjmgNwfT0ao3foewCLcB/s800/card_spade_05.png";
                    }
                    else if (result == 6)
                    {
                        pictureBox1.ImageLocation = "https://3.bp.blogspot.com/-c3OkNnevlIY/WQBAF8LtaAI/AAAAAAABD-U/_qIQIX6nGtYxDaAiPoR--8s0TcAcFg_GACLcB/s800/card_spade_06.png";
                    }
                    else if (result == 7)
                    {
                        pictureBox1.ImageLocation = "https://1.bp.blogspot.com/-YWPrnvvibVs/WQBAGEyzd2I/AAAAAAABD-g/6YXIUPRRJnctD-NjPzA8_Pf5z7bRLx6NgCLcB/s800/card_spade_07.png";
                    }
                    else if (result == 8)
                    {
                        pictureBox1.ImageLocation = "https://2.bp.blogspot.com/-4WjI4aJ-Y2k/WQBAGgc0XqI/AAAAAAABD-c/-yCRUYRxy-sdx5EG96teinHSwjj3L_XrACLcB/s800/card_spade_08.png";
                    }
                    else if (result == 9)
                    {
                        pictureBox1.ImageLocation = "https://1.bp.blogspot.com/-lYcdLoEoqhk/WQBAGkz_02I/AAAAAAABD-Y/BzeTL07VRhc9viqmclMywil_LqOdQGL5QCLcB/s800/card_spade_09.png";
                    }
                    else if (result == 10)
                    {
                        pictureBox1.ImageLocation = "https://4.bp.blogspot.com/-0hkv0a660xs/WQBAHQRO0BI/AAAAAAABD-k/w_vXN31wPHULAG51gb419z6Q3WTKCfmOACLcB/s800/card_spade_10.png";
                    }
                    else if (result == 11)
                    {
                        pictureBox1.ImageLocation = "https://2.bp.blogspot.com/-JwwLTPZuPMM/XD_5kfjssyI/AAAAAAABRQc/d6u2cLsQA0k99iys2LJYymXaf5TwbBhxACLcBGAs/s600/card_spade_11.png";
                    }
                    else if (result == 12)
                    {
                        pictureBox1.ImageLocation = "https://2.bp.blogspot.com/-epZe0JlVtMM/WQBAHk4rzcI/AAAAAAABD-s/jlpAWreHND8kI6ez_wMETbWg0480l2JsgCLcB/s800/card_spade_12.png";
                    }
                    else if (result == 13)
                    {
                        pictureBox1.ImageLocation = "https://1.bp.blogspot.com/-OjE8t2UIgRA/WQBAH71q1bI/AAAAAAABD-w/s7xK2t5RNHwkc0fb98FX08lUj4SxcdFrQCLcB/s800/card_spade_13.png";
                    }
                }
                else if (result_m == 2) // クラブカードの処理
                {
                    textBox1.Text = "クラブの" + result.ToString();
                    if (result == 1)
                    {
                        a_count++;
                        pictureBox1.ImageLocation = "https://4.bp.blogspot.com/-BOhNgboYmDc/WQA_27Cy-FI/AAAAAAABD7g/nAAsOxbXY2o_3e3zrP5sbP8t1YYamHuAACLcB/s800/card_club_01.png";
                    }
                    else if (result == 2)
                    {
                        pictureBox1.ImageLocation = "https://3.bp.blogspot.com/-hgsXIloqVyw/WQA_3LS3MPI/AAAAAAABD7k/cS7pXbmShe48ok5YfDPi_mDjS1qNHykFQCLcB/s800/card_club_02.png";
                    }
                    else if (result == 3)
                    {
                        pictureBox1.ImageLocation = "https://4.bp.blogspot.com/-hIKME4x_kbQ/WQA_3IHzulI/AAAAAAABD7o/Ft4JOq2ydaEHteja59Zzv_i3ieXnmONwwCLcB/s800/card_club_03.png";
                    }
                    else if (result == 4)
                    {
                        pictureBox1.ImageLocation = "https://1.bp.blogspot.com/-jK5dV2do-u4/WQA_6NL1_pI/AAAAAAABD7w/FocpXKcFQoMLuL108nfhcXh7hnNBG5XuQCLcB/s800/card_club_04.png";
                    }
                    else if (result == 5)
                    {
                        pictureBox1.ImageLocation = "https://4.bp.blogspot.com/-YS0WFXKsMVw/WQA_6BXvi5I/AAAAAAABD7s/FtPj_2pOTp0vHv-o7SM0ypu7RGbdoqdWACLcB/s800/card_club_05.png";
                    }
                    else if (result == 6)
                    {
                        pictureBox1.ImageLocation = "https://3.bp.blogspot.com/-8Badx_rITCw/WQA_6DLYUSI/AAAAAAABD70/rdTGjS1Ec8Ike1_G0foYxz6TURgQj0SAwCLcB/s800/card_club_06.png";
                    }
                    else if (result == 7)
                    {
                        pictureBox1.ImageLocation = "https://2.bp.blogspot.com/-LXJw0prlZp0/WQA_6wZyEVI/AAAAAAABD74/eFWVHzCtgLMj_C-JPzjOd7YfhiveHytlQCLcB/s800/card_club_07.png";
                    }
                    else if (result == 8)
                    {
                        pictureBox1.ImageLocation = "https://2.bp.blogspot.com/-MgspaQVG0TI/WQA_6-KkeCI/AAAAAAABD78/DpAaw1R2LM8tcD27tuYx0lYBdZQsI9qpwCLcB/s800/card_club_08.png";
                    }
                    else if (result == 9)
                    {
                        pictureBox1.ImageLocation = "https://1.bp.blogspot.com/-E0A1v2Tf3Ew/WQA_6zYEsSI/AAAAAAABD8A/dr_ytvRhUW4RjIkrX2631ltJHQyLOA6ygCLcB/s800/card_club_09.png";
                    }
                    else if (result == 10)
                    {
                        pictureBox1.ImageLocation = "https://1.bp.blogspot.com/-LzLb452BcCs/WQA_7ijljgI/AAAAAAABD8I/eti4IkCO6-0auSfwaVnOyV6nFlB29esUgCLcB/s800/card_club_10.png";
                    }
                    else if (result == 11)
                    {
                        pictureBox1.ImageLocation = "https://3.bp.blogspot.com/-Bk_-puNIPyA/WQA_7UDvnSI/AAAAAAABD8E/oG18hpYtq2w8gGWxRK-ymX36O_H4YzmPQCLcB/s800/card_club_11.png";
                    }
                    else if (result == 12)
                    {
                        pictureBox1.ImageLocation = "https://4.bp.blogspot.com/-KW4EpPTE2c8/WQA_8DZLdwI/AAAAAAABD8M/xq63m_MJ_5gNKter3MpQ-ynnfTy0JVASwCLcB/s800/card_club_12.png";
                    }
                    else if (result == 13)
                    {
                        pictureBox1.ImageLocation = "https://3.bp.blogspot.com/-bicDHxSomXw/WQA_8CngNuI/AAAAAAABD8Q/NpuWFK68hEsccHaBxQXeJUOPSEseAqVKgCLcB/s800/card_club_13.png";
                    }
                }
                else if (result_m == 3) // ダイヤカードの処理
                {
                    textBox1.Text = "ダイヤの" + result.ToString();
                    if (result == 1)
                    {
                        a_count++;
                        pictureBox1.ImageLocation = "https://3.bp.blogspot.com/-t2Uv3YfhtcY/WQA_8e3yr7I/AAAAAAABD8U/I5XTJPcgiToEOc6Qe1jAJTaXm1Sx8HtQgCLcB/s800/card_diamond_01.png";
                    }
                    else if (result == 2)
                    {
                        pictureBox1.ImageLocation = "https://1.bp.blogspot.com/-soxRK6ntcxw/WQA_9nD9WCI/AAAAAAABD8Y/e7S9nX1hwEQuO5SIRro6154hS6r7-jJJQCLcB/s800/card_diamond_02.png";
                    }
                    else if (result == 3)
                    {
                        pictureBox1.ImageLocation = "https://1.bp.blogspot.com/-Zo951HLWRlQ/WQA_9svbtTI/AAAAAAABD8c/jcJcMIfJNEgtPADX4Z_SRD7JptfX0uJdQCLcB/s800/card_diamond_03.png";
                    }
                    else if (result == 4)
                    {
                        pictureBox1.ImageLocation = "https://4.bp.blogspot.com/-WNnDDDnVkrs/WQA_9vUTTJI/AAAAAAABD8g/PSyYSizOnVkaC37L7bLn82Ex83Tvm0BKACLcB/s800/card_diamond_04.png";
                    }
                    else if (result == 5)
                    {
                        pictureBox1.ImageLocation = "https://4.bp.blogspot.com/-nRZKqqQt_vw/WQA_-vt8HiI/AAAAAAABD8s/g5mYH3Esp7AQkPavHFI74TqLB4Gl6DTBQCLcB/s800/card_diamond_05.png";
                    }
                    else if (result == 6)
                    {
                        pictureBox1.ImageLocation = "https://1.bp.blogspot.com/-_3IO3O1KAoQ/WQA_-lJ2MWI/AAAAAAABD8k/VxlQcr7UwTMsreQ9Rn3Pecu0kqqRD53MACLcB/s800/card_diamond_06.png";
                    }
                    else if (result == 7)
                    {
                        pictureBox1.ImageLocation = "https://4.bp.blogspot.com/-BqGnQr2-NqI/WQA_-s5yc7I/AAAAAAABD8o/NtZi3Dh4bNUAA5HUUxlhR1K55K32CYbbwCLcB/s800/card_diamond_07.png";
                    }
                    else if (result == 8)
                    {
                        pictureBox1.ImageLocation = "https://1.bp.blogspot.com/-FZGbdtedARU/WQA__nBH5iI/AAAAAAABD84/X9BsjJbBLZcuGBr5VT2EeisGjlp0wtJpwCLcB/s800/card_diamond_08.png";
                    }
                    else if (result == 9)
                    {
                        pictureBox1.ImageLocation = "https://3.bp.blogspot.com/-Ndl0O1jqgq8/WQA__BbskCI/AAAAAAABD8w/r7FfStH5YQUla15gVo_4fLZe1ICIMOp-ACLcB/s800/card_diamond_09.png";
                    }
                    else if (result == 10)
                    {
                        pictureBox1.ImageLocation = "https://2.bp.blogspot.com/-cHD1NPF9H_4/WQA__UMM9UI/AAAAAAABD80/vm9j-P6Mnqgg9ZnGISqKsJy4chmotPKlQCLcB/s800/card_diamond_10.png";
                    }
                    else if (result == 11)
                    {
                        pictureBox1.ImageLocation = "https://3.bp.blogspot.com/-_TRspngujsg/WQA__3On4dI/AAAAAAABD88/qBQf1hrFHdIHDoJkJgDTWpIFHWTGX1gUwCLcB/s800/card_diamond_11.png";
                    }
                    else if (result == 12)
                    {
                        pictureBox1.ImageLocation = "https://4.bp.blogspot.com/-awCU2XbepTk/WQBAAAkIYiI/AAAAAAABD9A/xVB37vHopCsDpS-UN5EbwnXGiUiO9J1ZwCLcB/s800/card_diamond_12.png";
                    }
                    else if (result == 13)
                    {
                        pictureBox1.ImageLocation = "https://2.bp.blogspot.com/-AIDRA5MtU5A/WQBAAWRMAgI/AAAAAAABD9E/iNuSUO4y_fQTDR3UQi149RwdbPx0vw4tQCLcB/s800/card_diamond_13.png";
                    }
                }
                else if (result_m == 4) // ハートカードの処理
                {
                    textBox1.Text = "ハートの" + result.ToString();
                    if (result == 1)
                    {
                        a_count++;
                        pictureBox1.ImageLocation = "https://3.bp.blogspot.com/-Gc8mOTO7D3E/WQBAARSWh8I/AAAAAAABD9I/e0T5rdD37VQ95br4klbWQbm56eFCtd3UwCLcB/s800/card_heart_01.png";
                    }
                    else if (result == 2)
                    {
                        pictureBox1.ImageLocation = "https://3.bp.blogspot.com/-x1YD4kp-X9E/WQBAA3RKDbI/AAAAAAABD9M/5K8vEH6kYSo5M9r2jzxheGlnup2k-El5gCLcB/s800/card_heart_02.png";
                    }
                    else if (result == 3)
                    {
                        pictureBox1.ImageLocation = "https://4.bp.blogspot.com/-EKVZFBVtmjQ/WQBABA_ahuI/AAAAAAABD9U/nTJtYuBS5fkpjWPMxSSnUINuFSWxTHO3gCLcB/s800/card_heart_03.png";
                    }
                    else if (result == 4)
                    {
                        pictureBox1.ImageLocation = "https://2.bp.blogspot.com/-Nf18bkno_jQ/WQBABJhQh3I/AAAAAAABD9Q/ZSy-WCf-at0qtHZdw5JeFf7miJP2RWingCLcB/s800/card_heart_04.png";
                    }
                    else if (result == 5)
                    {
                        pictureBox1.ImageLocation = "https://2.bp.blogspot.com/-CFp5e60TFQk/WQBABoeZH8I/AAAAAAABD9Y/yPc41v2h0yYoQ8m6d610Vk3QVREpnLMGQCLcB/s800/card_heart_05.png";
                    }
                    else if (result == 6)
                    {
                        pictureBox1.ImageLocation = "https://3.bp.blogspot.com/-w5tuOxBszlU/WQBABseF49I/AAAAAAABD9c/9yF8y-6012MKF5UlSz-dxORnZU_YhEuxgCLcB/s800/card_heart_06.png";
                    }
                    else if (result == 7)
                    {
                        pictureBox1.ImageLocation = "https://1.bp.blogspot.com/-Mi6_zO3nrME/WQBAB5sBPMI/AAAAAAABD9g/a73P0ORztvULMDbAMLMO31MTkHONqqOGQCLcB/s800/card_heart_07.png";
                    }
                    else if (result == 8)
                    {
                        pictureBox1.ImageLocation = "https://4.bp.blogspot.com/-9eIFe_ntyM8/WQBACKrLmjI/AAAAAAABD9k/k2Bx40mdlNsDRsb9g5EVOtJyAbBngcfXgCLcB/s800/card_heart_08.png";
                    }
                    else if (result == 9)
                    {
                        pictureBox1.ImageLocation = "https://4.bp.blogspot.com/--WdtHI89Ero/WQBACbrbQuI/AAAAAAABD9o/DTI0H5yJLR0ChinijyFaOCZuY3I4AEApACLcB/s800/card_heart_09.png";
                    }
                    else if (result == 10)
                    {
                        pictureBox1.ImageLocation = "https://4.bp.blogspot.com/-Dj2Yzi1XR-E/WQBADWUni-I/AAAAAAABD9s/2Cy3plnNZGwt9sV3vDO4eCvJSSg9DGx-wCLcB/s800/card_heart_10.png";
                    }
                    else if (result == 11)
                    {
                        pictureBox1.ImageLocation = "https://1.bp.blogspot.com/-V-d44vBp5RA/WQBADtJIdzI/AAAAAAABD9w/pLAAFAGsYMQAQJPX6kC5xDlAcjyrVAByQCLcB/s800/card_heart_11.png";
                    }
                    else if (result == 12)
                    {
                        pictureBox1.ImageLocation = "https://2.bp.blogspot.com/-bT_o-lYYQ-0/WQBAD08x5KI/AAAAAAABD90/RF8S0SR_Btk5iwlKguBB9mhSJh0WZOwVgCLcB/s800/card_heart_12.png";
                    }
                    else if (result == 13)
                    {
                        pictureBox1.ImageLocation = "https://2.bp.blogspot.com/-l4PpG6pymus/WQBAEqIEXiI/AAAAAAABD94/ET_3LcQAieMiur7nk-YZSeB6y_FkAZvyACLcB/s800/card_heart_13.png";
                    }
                }
                if (result >= 10) result = 10; // 10以上の処理
                hand_m += result; // 値の合計
                if(a_count > 0) // Aの特殊処理
                {
                    if((hand_m + 10) <= 21) // Aを11としてカウント
                    {
                        hand_m += 10;
                        aplus_count++;
                    }
                    else if(hand_m > 21 && aplus_count > 0) // Aを1としてカウント
                    {
                        hand_m -= 10;
                        a_count = 0;
                        aplus_count = 0;
                    }
                }
                p_draw_count++;
                if(hand_m < 21) // 値が21未満の処理
                {
                    textBox2.Text = hand_m.ToString();
                }
                else if(hand_m == 21) // 値が21の処理
                {
                    textBox2.Text = hand_m.ToString() + "___Blackjack!";
                }
                else if(hand_m > 21) // 値が21より大きい時の処理
                {
                    Lresult++; // 敗北回数を増加、以下同処理
                    textBox2.Text = hand_m.ToString() + "___Bust!";
                    pictureBox2.ImageLocation = "https://2.bp.blogspot.com/-o8oRuNPPmvs/U8XkejSJKdI/AAAAAAAAixY/J12ATFzCj9A/s400/money_fly_dollar.png";
                    button1.Text = "Continue?";
                    button2.Text = "Continue?";
                    textBox4.Text = "Win:" + Wresult.ToString() + " Lose:" + Lresult.ToString() + " Draw:" + Dresult.ToString();
                }
            }
            else if(button1.Text == "Continue?") // 継続処理
            {
                // 勝敗以外の全値の初期化
                hand_m = 0;
                dealer_m = 0;
                p_draw_count = 0;
                d_draw_count = 0;
                a_count = 0;
                aplus_count = 0;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                pictureBox1.ImageLocation = "";
                pictureBox2.ImageLocation = "";
                pictureBox3.ImageLocation = "";
                pictureBox4.ImageLocation = "";
                pictureBox5.ImageLocation = "";
                pictureBox6.ImageLocation = "";
                pictureBox7.ImageLocation = "";
                pictureBox8.ImageLocation = "";
                pictureBox9.ImageLocation = "";
                pictureBox10.ImageLocation = "";
                pictureBox11.ImageLocation = "";
                pictureBox12.ImageLocation = "";
                button1.Text = "Hit";
                button2.Text = "Stand";
            }


        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(button2.Text == "Stand") // Standの処理
            {
                Random dRandom = new System.Random(); // 乱数の生成
                while(dealer_m < 17) // ディーラーは17以上になるまで強制Hit
                {
                    dealer_m += dRandom.Next(1, 14);
                    d_draw_count++; // Hit回数を記憶
                }
                textBox3.Text = dealer_m.ToString();
                if (dealer_m == 21) textBox3.Text += "___Blackjack!";
                if(dealer_m <= 21) // ディーラーがbustしていない場合
                {
                    if (hand_m > dealer_m) // プレイヤーの勝利
                    {
                        Wresult++; // 勝利回数を増加、以下同処理
                        textBox2.Text += "___Win!";
                        pictureBox2.ImageLocation = "https://3.bp.blogspot.com/-nClKZyJUWt4/Vx9UvI7L1zI/AAAAAAAA6D4/IOq_ZI-TwfsrabjVQogJFPOx7t8Nr00SQCLcB/s400/money_fueru_dollar.png";
                    }
                    else if (hand_m < dealer_m) // ディーラーの勝利
                    {
                        Lresult++;
                        textBox2.Text += "___Lose...";
                        pictureBox2.ImageLocation = "https://2.bp.blogspot.com/-o8oRuNPPmvs/U8XkejSJKdI/AAAAAAAAixY/J12ATFzCj9A/s400/money_fly_dollar.png";
                    }
                    else if (hand_m == dealer_m) // 手札が同値
                    {
                        if (hand_m == 21 && p_draw_count == 2 && d_draw_count != 2) // 21かつプレイヤーがナチュラル21
                        {
                            Wresult++;
                            textBox2.Text += "___Win!";
                            textBox3.Text += "__Over 2 Hand...";
                            pictureBox2.ImageLocation = "https://3.bp.blogspot.com/-nClKZyJUWt4/Vx9UvI7L1zI/AAAAAAAA6D4/IOq_ZI-TwfsrabjVQogJFPOx7t8Nr00SQCLcB/s400/money_fueru_dollar.png";
                        }
                        else if (hand_m == 21 && p_draw_count != 2 && d_draw_count == 2) // 21かつディーラーがナチュラル21
                        {
                            Lresult++;
                            textBox2.Text += "___Lose...";
                            textBox3.Text = "___Just 2 Hand!";
                            pictureBox2.ImageLocation = "https://2.bp.blogspot.com/-o8oRuNPPmvs/U8XkejSJKdI/AAAAAAAAixY/J12ATFzCj9A/s400/money_fly_dollar.png";
                        }
                        else // ただの同値
                        {
                            Dresult++; // 引き分け回数を増加
                            textBox2.Text += "___Draw";
                            pictureBox2.ImageLocation = "https://4.bp.blogspot.com/-gU1F5gSME8w/WdyDK2KmIjI/AAAAAAABHaA/Up8EMGa0uK4yZGI6QF8TFPZmgrAJkTgRACLcBGAs/s450/baseball_shinpan_safe.png";
                        }
                    }
                }
                else if(dealer_m > 21) // ディーラーがBustした場合
                {
                    Wresult++;
                    textBox2.Text += "___Win!";
                    textBox3.Text += "___Over 21...";
                    pictureBox2.ImageLocation = "https://3.bp.blogspot.com/-nClKZyJUWt4/Vx9UvI7L1zI/AAAAAAAA6D4/IOq_ZI-TwfsrabjVQogJFPOx7t8Nr00SQCLcB/s400/money_fueru_dollar.png";
                }
                button1.Text = "Continue?";
                button2.Text = "Continue?";
                textBox4.Text = "Win:" + Wresult.ToString() + " Lose:" + Lresult.ToString() + " Draw:" + Dresult.ToString();
            }
            else if(button2.Text == "Continue?") // 継続処理
            {
                // 全値の初期化
                hand_m = 0;
                dealer_m = 0;
                p_draw_count = 0;
                d_draw_count = 0;
                a_count = 0;
                aplus_count = 0;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                pictureBox1.ImageLocation = "";
                pictureBox2.ImageLocation = "";
                pictureBox3.ImageLocation = "";
                pictureBox4.ImageLocation = "";
                pictureBox5.ImageLocation = "";
                pictureBox6.ImageLocation = "";
                pictureBox7.ImageLocation = "";
                pictureBox8.ImageLocation = "";
                pictureBox9.ImageLocation = "";
                pictureBox10.ImageLocation = "";
                pictureBox11.ImageLocation = "";
                pictureBox12.ImageLocation = "";
                button1.Text = "Hit";
                button2.Text = "Stand";

            }
        }

        private void button3_Click(object sender, EventArgs e) // やめたいとき
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
