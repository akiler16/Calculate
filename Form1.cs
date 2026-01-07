using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double firstN;
        double secondN;
        char oper;

        bool isNewSecondNumber = false;


        private void button0_Click(object sender, EventArgs e)
        {
            if (isNewSecondNumber)
            {
                textBoxDisplay.Clear();
                isNewSecondNumber = false;
            }
            textBoxDisplay.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isNewSecondNumber)
            {
                textBoxDisplay.Clear();
                isNewSecondNumber = false;
            }
            textBoxDisplay.Text += "1";
        }


private void button2_Click(object sender, EventArgs e)
        {
            if (isNewSecondNumber)
            {
                textBoxDisplay.Clear();
                isNewSecondNumber = false;
            }
            textBoxDisplay.Text += "2";
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            if (isNewSecondNumber)
            {
                textBoxDisplay.Clear();
                isNewSecondNumber = false;
            }
            textBoxDisplay.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (isNewSecondNumber)
            {
                textBoxDisplay.Clear();
                isNewSecondNumber = false;
            }
            textBoxDisplay.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (isNewSecondNumber)
            {
                textBoxDisplay.Clear();
                isNewSecondNumber = false;
            }
            textBoxDisplay.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (isNewSecondNumber)
            {
                textBoxDisplay.Clear();
                isNewSecondNumber = false;
            }
            textBoxDisplay.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (isNewSecondNumber)
            {
                textBoxDisplay.Clear();
                isNewSecondNumber = false;
            }
            textBoxDisplay.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (isNewSecondNumber)
            {
                textBoxDisplay.Clear();
                isNewSecondNumber = false;
            }
            textBoxDisplay.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (isNewSecondNumber)
            {
                textBoxDisplay.Clear();
                isNewSecondNumber = false;
            }
            textBoxDisplay.Text += "9";
        }
        private void buttonPlus_Click_1(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text != "")
            {
                if (oper != '\0')
                {
                    secondN = double.Parse(textBoxDisplay.Text);
                    Calculate();
                }
                else
                {
                    firstN = double.Parse(textBoxDisplay.Text);
                }
            }

            oper = '+';
            textBoxDisplay.Clear();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
            {
            if (textBoxDisplay.Text != "")
            {
                if (oper != '\0')
                {
                    secondN = double.Parse(textBoxDisplay.Text);
                    Calculate();
                }
                else
                {
                    firstN = double.Parse(textBoxDisplay.Text);
                }
            }

            oper = '-';
            textBoxDisplay.Clear();
        }

            private void buttonMul_Click(object sender, EventArgs e)
            {
            if (textBoxDisplay.Text != "")
            {
                if (oper != '\0')
                {
                    secondN = double.Parse(textBoxDisplay.Text);
                    Calculate();
                }
                else
                {
                    firstN = double.Parse(textBoxDisplay.Text);
                }
            }

            oper = '*';
            textBoxDisplay.Clear();
        }

            private void buttonDiv_Click(object sender, EventArgs e)
            {
            if (textBoxDisplay.Text != "")
            {
                if (oper != '\0')
                {
                    secondN = double.Parse(textBoxDisplay.Text);
                    Calculate();
                }
                else
                {
                    firstN = double.Parse(textBoxDisplay.Text);
                }
            }

            oper = '/';
            textBoxDisplay.Clear();

        }

        private void buttonAnswer_Click(object sender, EventArgs e)
        {
        
            if (textBoxDisplay.Text == "")
                return;

            secondN = double.Parse(textBoxDisplay.Text);
            Calculate();
        }

        private void button10_Click(object sender, EventArgs e)
        {
 
            if (textBoxDisplay.Text.Contains(","))
                return;
            if (textBoxDisplay.Text == "")
                textBoxDisplay.Text = "0,";
            else
                textBoxDisplay.Text += ",";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Clear();
            firstN = 0;
            secondN = 0;
            oper = '\0';
        }

        Random rnd = new Random();

        void Start404PrankMultiple(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Start404Prank();
            }
        }


        void Calculate()
        {
            double result = 0;

            switch (oper)
            {
                case '+':
                    result = firstN + secondN;
                    break;
                case '-':
                    result = firstN - secondN;
                    break;
                case '*':
                    result = firstN * secondN;
                    break;
                case '/':
                    if (secondN == 0)
                    {
                        MessageBox.Show("На нуль ділити не можна");
                        return;
                    }
                    result = firstN / secondN;
                    break;
                default:
                    return;
            }
            firstN = result;
            textBoxDisplay.Text = result.ToString();
            isNewSecondNumber = true;

            if (result == 404)
            {
                Start404PrankMultiple(100); // ← сколько окон
            }

            firstN = result;
            textBoxDisplay.Text = result.ToString();
            isNewSecondNumber = true;
        }

        void Start404Prank()
        {
            Random rnd = new Random();

            // создаём окно
            Form f = new Form();
            f.FormBorderStyle = FormBorderStyle.None;
            f.BackColor = Color.Black;
            f.Size = new Size(200, 150);
            f.StartPosition = FormStartPosition.Manual;
            f.TopMost = true;

            int x = rnd.Next(0, Screen.PrimaryScreen.WorkingArea.Width - f.Width);
            int y = rnd.Next(0, Screen.PrimaryScreen.WorkingArea.Height - f.Height);
            f.Location = new Point(x, y);

            // надпись 404
            Label lbl = new Label();
            lbl.Text = "404";
            lbl.ForeColor = Color.Red;
            lbl.Font = new Font("Arial", 36, FontStyle.Bold);
            lbl.Dock = DockStyle.Fill;
            lbl.TextAlign = ContentAlignment.MiddleCenter;

            f.Controls.Add(lbl);
            f.Show();

            // ===== МИГАНИЕ =====
            Timer blinkTimer = new Timer();
            bool visible = true;
            blinkTimer.Interval = 1;
            blinkTimer.Tick += (s, e) =>
            {
                visible = !visible;
                lbl.Visible = visible;
            };
            blinkTimer.Start();

            // ===== ТРЯСКА =====
            Timer shakeTimer = new Timer();
            Point basePos = f.Location;
            shakeTimer.Interval = 1;
            shakeTimer.Tick += (s, e) =>
            {
                int dx = rnd.Next(-50, 51);
                int dy = rnd.Next(-50, 51);
                f.Location = new Point(basePos.X + dx, basePos.Y + dy);
            };
            shakeTimer.Start();

            // ===== ЗАКРЫТИЕ ЧЕРЕЗ 10 СЕК =====
            Timer closeTimer = new Timer();
            closeTimer.Interval = 10000;
            closeTimer.Tick += (s, e) =>
            {
                blinkTimer.Stop();
                shakeTimer.Stop();
                closeTimer.Stop();
                f.Close();
            };
            closeTimer.Start();
        }
        private void buttonPercent_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text == "" || oper == '\0')
                return;

            double percentValue = double.Parse(textBoxDisplay.Text);

            switch (oper)
            {
                case '+':
                case '-':
                    secondN = firstN * percentValue / 100;
                    break;

                case '*':
                case '/':
                    secondN = percentValue / 100;
                    break;
            }

            textBoxDisplay.Text = secondN.ToString();
            isNewSecondNumber = true;
        }
    }
}