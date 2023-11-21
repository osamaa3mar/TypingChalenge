using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypingChalenge
{
    public partial class Form1 : Form
    {
        int Timer = 0;
        double Wpm=0;
        Random rand = new Random();
        bool capsLocked = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            if (capsLocked)
            {
                textBox2.Text += "Q";
            }
            else
                textBox2.Text += "q";
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (groupBox1.Enabled && progressBar1.Value<progressBar1.Maximum)
            {
                if (!capsLocked)
                {
                    if (e.KeyCode == Keys.A)
                    {
                        btnA.BackColor = Color.Aqua;
                        textBox2.Text += "a";
                        CheckGame();
                    }
                    if (e.KeyCode == Keys.B)
                    {
                        btnB.BackColor = Color.Aqua;
                        textBox2.Text += "b";
                        CheckGame();
                    }
                    if (e.KeyCode == Keys.C)
                    {
                        btnC.BackColor = Color.Aqua;
                        textBox2.Text += "c";
                        CheckGame();
                    }
                    if (e.KeyCode == Keys.D)
                    {
                        btnD.BackColor = Color.Aqua;
                        textBox2.Text += "d";
                        CheckGame();
                    }
                    if (e.KeyCode == Keys.E)
                    {
                        btnE.BackColor = Color.Aqua;
                        textBox2.Text += "e";
                        CheckGame();
                    }
                    if (e.KeyCode == Keys.F)
                    {
                        btnF.BackColor = Color.Aqua;

                        textBox2.Text += "f";
                        CheckGame();
                    }
                    if (e.KeyCode == Keys.G)
                    {
                        btnG.BackColor = Color.Aqua;
                        textBox2.Text += "g";
                        CheckGame();
                    }
                    if (e.KeyCode == Keys.H)
                    {
                        btnH.BackColor = Color.Aqua;
                        textBox2.Text += "h";
                        CheckGame();
                    }
                    if (e.KeyCode == Keys.I)
                    {

                        btnI.BackColor = Color.Aqua;
                        textBox2.Text += "i";
                        CheckGame();
                    }
                    if (e.KeyCode == Keys.J)
                    {
                        btnJ.BackColor = Color.Aqua;
                        textBox2.Text += "j";
                        CheckGame();
                    }
                    if (e.KeyCode == Keys.K)
                    {
                        btnK.BackColor = Color.Aqua;
                        textBox2.Text += "k";
                        CheckGame();
                    }
                    if (e.KeyCode == Keys.L)
                    {
                        btnL.BackColor = Color.Aqua;
                        textBox2.Text += "l";
                        CheckGame();
                    }
                    if (e.KeyCode == Keys.M)
                    {
                        btnM.BackColor = Color.Aqua;
                        textBox2.Text += "m";
                        CheckGame();
                    }
                    if (e.KeyCode == Keys.N)
                    {
                        btnN.BackColor = Color.Aqua;
                        textBox2.Text += "n";
                        CheckGame();
                    }
                    if (e.KeyCode == Keys.O)
                    {
                        btnO.BackColor = Color.Aqua;
                        textBox2.Text += "o";
                        CheckGame();
                    }
                    if (e.KeyCode == Keys.P)
                    {
                        btnP.BackColor = Color.Aqua;
                        textBox2.Text += "p";
                        CheckGame();
                    }
                    if (e.KeyCode == Keys.Q)
                    {
                        btnQ.BackColor = Color.Aqua;
                        textBox2.Text += "q";
                        CheckGame();
                    }
                    if (e.KeyCode == Keys.R)
                    {
                        btnR.BackColor = Color.Aqua;
                        textBox2.Text += "r";
                        CheckGame();
                    }
                    if (e.KeyCode == Keys.S)
                    {
                        btnS.BackColor = Color.Aqua;
                        textBox2.Text += "s";
                        CheckGame();
                    }
                    if (e.KeyCode == Keys.T)
                    {
                        btnT.BackColor = Color.Aqua;
                        textBox2.Text += "t";
                        CheckGame();
                    }
                    if (e.KeyCode == Keys.U)
                    {
                        btnU.BackColor = Color.Aqua;
                        textBox2.Text += "u";
                        CheckGame();
                    }
                    if (e.KeyCode == Keys.V)
                    {
                        btnV.BackColor = Color.Aqua;
                        textBox2.Text += "v";
                        CheckGame();
                    }
                    if (e.KeyCode == Keys.W)
                    {
                        btnW.BackColor = Color.Aqua;
                        textBox2.Text += "w";
                        CheckGame();
                    }
                    if (e.KeyCode == Keys.X)
                    {
                        btnX.BackColor = Color.Aqua;
                        textBox2.Text += "x";
                        CheckGame();
                    }
                    if (e.KeyCode == Keys.Y)
                    {
                        btnY.BackColor = Color.Aqua;
                        textBox2.Text += "y";
                        CheckGame();
                    }
                    if (e.KeyCode == Keys.Z)
                    {
                        btnZ.BackColor = Color.Aqua;
                        textBox2.Text += "z";
                        CheckGame();
                    }

                }

                if (capsLocked)
                {
                    if (e.KeyCode == Keys.A)
                    {
                        btnA.BackColor = Color.Aqua;
                        textBox2.Text += "A";
                        CheckGame();
                    }
                    if (e.KeyCode == Keys.B)
                    {
                        btnB.BackColor = Color.Aqua;
                        textBox2.Text += "B";
                        CheckGame();
                    }
                    if (e.KeyCode == Keys.C)
                    {
                        btnC.BackColor = Color.Aqua;
                        textBox2.Text += "C";
                        CheckGame();
                    }
                    if (e.KeyCode == Keys.D)
                    {
                        btnD.BackColor = Color.Aqua;
                        textBox2.Text += "D";
                        CheckGame();
                    }
                    if (e.KeyCode == Keys.E)
                    {
                        btnE.BackColor = Color.Aqua;
                        textBox2.Text += "E";
                        CheckGame();
                    }
                    if (e.KeyCode == Keys.F)
                    {
                        btnF.BackColor = Color.Aqua;

                        textBox2.Text += "F";
                        CheckGame();
                    }
                    if (e.KeyCode == Keys.G)
                    {
                        btnG.BackColor = Color.Aqua;
                        textBox2.Text += "G";
                        CheckGame();
                    }
                    if (e.KeyCode == Keys.H)
                    {
                        btnH.BackColor = Color.Aqua;
                        textBox2.Text += "H";
                        CheckGame();
                    }
                    if (e.KeyCode == Keys.I)
                    {

                        btnI.BackColor = Color.Aqua;
                        textBox2.Text += "I";
                        CheckGame();
                    }
                    if (e.KeyCode == Keys.J)
                    {
                        btnJ.BackColor = Color.Aqua;
                        textBox2.Text += "J";
                        CheckGame();
                    }
                    if (e.KeyCode == Keys.K)
                    {
                        btnK.BackColor = Color.Aqua;
                        textBox2.Text += "K";
                        CheckGame();
                    }
                    if (e.KeyCode == Keys.L)
                    {
                        btnL.BackColor = Color.Aqua;
                        textBox2.Text += "L";
                        CheckGame();
                    }
                    if (e.KeyCode == Keys.M)
                    {
                        btnM.BackColor = Color.Aqua;
                        textBox2.Text += "M";
                        CheckGame();
                    }
                    if (e.KeyCode == Keys.N)
                    {
                        btnN.BackColor = Color.Aqua;
                        textBox2.Text += "N";
                        CheckGame();
                    }
                    if (e.KeyCode == Keys.O)
                    {
                        btnO.BackColor = Color.Aqua;
                        textBox2.Text += "O";
                        CheckGame();
                    }
                    if (e.KeyCode == Keys.P)
                    {
                        btnP.BackColor = Color.Aqua;
                        textBox2.Text += "P";
                        CheckGame();
                    }
                    if (e.KeyCode == Keys.Q)
                    {
                        btnQ.BackColor = Color.Aqua;
                        textBox2.Text += "Q";
                        CheckGame();
                    }
                    if (e.KeyCode == Keys.R)
                    {
                        btnR.BackColor = Color.Aqua;
                        textBox2.Text += "R";
                        CheckGame();
                    }
                    if (e.KeyCode == Keys.S)
                    {
                        btnS.BackColor = Color.Aqua;
                        textBox2.Text += "S";
                        CheckGame();
                    }
                    if (e.KeyCode == Keys.T)
                    {
                        btnT.BackColor = Color.Aqua;
                        textBox2.Text += "T";
                        CheckGame();
                    }
                    if (e.KeyCode == Keys.U)
                    {
                        btnU.BackColor = Color.Aqua;
                        textBox2.Text += "U";
                        CheckGame();
                    }
                    if (e.KeyCode == Keys.V)
                    {
                        btnV.BackColor = Color.Aqua;
                        textBox2.Text += "V";
                        CheckGame();
                    }
                    if (e.KeyCode == Keys.W)
                    {
                        btnW.BackColor = Color.Aqua;
                        textBox2.Text += "W";
                        CheckGame();
                    }
                    if (e.KeyCode == Keys.X)
                    {
                        btnX.BackColor = Color.Aqua;
                        textBox2.Text += "X";
                        CheckGame();
                    }
                    if (e.KeyCode == Keys.Y)
                    {
                        btnY.BackColor = Color.Aqua;
                        textBox2.Text += "Y";
                        CheckGame();
                    }
                    if (e.KeyCode == Keys.Z)
                    {
                        btnZ.BackColor = Color.Aqua;
                        textBox2.Text += "Z";
                        CheckGame();
                    }
                }

                if (e.KeyCode == Keys.Space)
                {
                    btnSpace.BackColor = Color.Aqua;
                    textBox2.Text += " ";
                    WordCountInXSeconds(60);
                    CheckGame();
                }

                if (e.KeyCode == Keys.Back)
                {
                    btnBackSpace.BackColor = Color.Aqua;
                    if (textBox2.Text != "")
                        textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);

                    CheckGame();
                }

                if (e.KeyCode == Keys.CapsLock)
                {
                    if (!capsLocked)
                    {
                        CapitalKeys();
                        btnCapsLock.BackColor = Color.Green;
                        capsLocked = true;
                    }
                    else if (capsLocked)
                    {
                        
                        SmallKeys();
                        btnCapsLock.BackColor = Color.Black;
                        capsLocked = false;
                    }
                }

                if (e.KeyCode == Keys.ShiftKey)
                {
                    capsLocked = true;
                    btnShift.BackColor = Color.Aqua;
                }
            }
            if (Timer == 60)
            {
                MessageBox.Show("Time is over!");
                btnRestart_Click(sender, new EventArgs());
            }            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            btnA.BackColor = Color.Black;
            btnB.BackColor = Color.Black;
            btnC.BackColor = Color.Black;
            btnD.BackColor = Color.Black;
            btnE.BackColor = Color.Black;
            btnF.BackColor = Color.Black;
            btnG.BackColor = Color.Black;
            btnH.BackColor = Color.Black;
            btnI.BackColor = Color.Black;
            btnJ.BackColor = Color.Black;
            btnK.BackColor = Color.Black;
            btnL.BackColor = Color.Black;
            btnM.BackColor = Color.Black;
            btnN.BackColor = Color.Black;
            btnO.BackColor = Color.Black;
            btnP.BackColor = Color.Black;
            btnQ.BackColor = Color.Black;
            btnR.BackColor = Color.Black;
            btnS.BackColor = Color.Black;
            btnT.BackColor = Color.Black;
            btnU.BackColor = Color.Black;
            btnV.BackColor = Color.Black;
            btnW.BackColor = Color.Black;
            btnX.BackColor = Color.Black;
            btnY.BackColor = Color.Black;
            btnZ.BackColor = Color.Black;
            btnBackSpace.BackColor = Color.Black;
            btnSpace.BackColor = Color.Black;
            btnShift.BackColor = Color.Black;
            if (e.KeyCode == Keys.ShiftKey)
            {
                capsLocked = false;
            }

        }

        private void btnAutoFill_Click(object sender, EventArgs e)
        {
            textBox1.Text = RandomSentence(rand.Next(0, 4));
        }
        string RandomSentence(int count) 
        {
            switch (count) 
            {
                case 0: { return "hello its osama"; break; }
                case 1: return "programming advices";break;
                case 2: return "sad and fat";break;
                case 3: return "dark side";break;
                default: return "";break;
            }
        }

        private void btnSrartChalenge_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            timer1.Enabled = true;


        }
        void CheckGame() 
        {
            for (int i = 0; i < textBox2.Text.Length; i++)
            {
                if(textBox2.Text.Length > textBox1.Text.Length)
                {
                    return;
                }
                if (textBox1.Text[i] != textBox2.Text[i] )
                {
                    Form1.ActiveForm.BackColor = Color.Red;
                }
                else if(textBox1.Text[i] == textBox2.Text[i] )
                {
                    Form1.ActiveForm.BackColor = Color.Black;
                }
            }
            if(textBox1.Text == textBox2.Text && textBox1.Text!="")
            {
                Form1.ActiveForm.BackColor = Color.Green;
                MessageBox.Show("Game Over ");
                btnRestart_Click(new object(), new EventArgs());
            }
            
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox1.Text = "";
            groupBox1.Enabled = false;
            Form1.ActiveForm.BackColor = Color.Black;
            progressBar1.Value = 0;
            timer1.Enabled = false;
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            if (capsLocked)
            {
                textBox2.Text += "W";
            }
            else
            textBox2.Text += "w";
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            if (capsLocked)
            {
                textBox2.Text += "E";
            }
            else
                textBox2.Text += "e";
        }

        private void btnCapsLock_Click(object sender, EventArgs e)
        {
            
            if (btnCapsLock.BackColor == Color.Green)
            {
                SmallKeys();
                
                btnCapsLock.BackColor = Color.Black;
                capsLocked = false;
            }
            else if (btnCapsLock.BackColor == Color.Black)
            {

                CapitalKeys();
                btnCapsLock.BackColor = Color.Green;
                capsLocked = true;
            }
            
        }
        void CapitalKeys()
        {
            btnA.Text = "A";
            btnB.Text = "B";
            btnC.Text = "C";
            btnD.Text= "D";
            btnE.Text= "E";
            btnF.Text= "F";
            btnG.Text = "G";
            btnH.Text= "H";
            btnI.Text= "I";
            btnJ.Text = "J";
            btnK.Text = "K";
            btnL.Text = "L";
            btnM.Text = "M";
            btnN.Text = "N";
            btnO.Text= "O";
            btnP.Text = "P";
            btnQ.Text = "Q";
            btnR.Text = "R";
            btnS.Text = "S";
            btnT.Text = "T";
            btnU.Text = "U";
            btnV.Text = "V";
            btnW.Text = "W";
            btnX.Text = "X";
            btnY.Text = "Y";
            btnZ.Text = "Z";
        }
        void SmallKeys()
        {
            btnA.Text = "a";
            btnB.Text = "b";
            btnC.Text = "c";
            btnD.Text = "d";
            btnE.Text = "e";
            btnF.Text = "f";
            btnG.Text = "g";
            btnH.Text = "h";
            btnI.Text = "i";
            btnJ.Text = "j";
            btnK.Text = "k";
            btnL.Text = "l";
            btnM.Text = "m";
            btnN.Text = "n";
            btnO.Text = "o";
            btnP.Text = "p";
            btnQ.Text = "q";
            btnR.Text = "r";
            btnS.Text = "s";
            btnT.Text = "t";
            btnU.Text = "u";
            btnV.Text = "v";
            btnW.Text = "w";
            btnX.Text = "x";
            btnY.Text = "y";
            btnZ.Text = "z";
        }

        private void btnShift_KeyPress(object sender, KeyPressEventArgs e)
        {
            capsLocked = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Timer < 60)
            {
                Timer++;
                label1.Text = Timer.ToString();
            }

            if (progressBar1.Value<progressBar1.Maximum)
            {
                progressBar1.Value += 1;
            }
           
        }

        void WordCountInXSeconds(int Seconds)
        {
            string []num2 = NumberOfWordsInString(textBox2.Text);
            string [] num1 = NumberOfWordsInString(textBox1.Text);

                if (num1[num2.Length-2] == num2[num2.Length-2] && num2[num2.Length-2]!="")
                {
                    Wpm += 1;
                    label2.Text = Wpm.ToString();
                }           
        }
        string [] NumberOfWordsInString(string s)
        {
            string[] MainBox = s.Split(' ');
            return MainBox;
        }
    }
}
