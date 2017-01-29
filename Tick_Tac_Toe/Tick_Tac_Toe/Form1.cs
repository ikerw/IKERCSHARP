using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tick_Tac_Toe
{
    public partial class Form1 : Form
    {
        public int[,] matrix =
        {
            {11, 12, 13 },
            {14, 15, 16 },
            {17, 18, 19 }
        };

        public bool[] ifClicked =
        {
            false,
            false,
            false,
            false,
            false,
            false,
            false,
            false,
            false
        };
            
        public int count = 0;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void po1_Click(object sender, EventArgs e)
        {
            if (ifClicked[0] == false)
            {
                ifClicked[0] = true;
                count += 1;

                if (count % 2 == 1)
                {
                    matrix[0, 0] = 1;
                    po1.Text = "X";
                }
                else if (count % 2 == 0)
                {
                    matrix[0, 0] = 2;
                    po1.Text = "O";
                } 
            }

            bool result = evaluateGameResult(matrix);
            if (result)
            {
                textBox1.Text = "Game Over";
            }

        }

        private void po2_Click(object sender, EventArgs e)
        {
            if (ifClicked[1] == false)
            {
                ifClicked[1] = true;
                count += 1;

                if (count % 2 == 1)
                {
                    matrix[0, 1] = 1;
                    po2.Text = "X";
                }
                else if (count % 2 == 0)
                {
                    matrix[0, 1] = 2;
                    po2.Text = "O";
                } 
            }

            bool result = evaluateGameResult(matrix);
            if (result)
            {
                textBox1.Text = "Game Over";
            }
        }

        private void po3_Click(object sender, EventArgs e)
        {
            if (ifClicked[2] == false)
            {
                ifClicked[2] = true;
                count += 1;

                if (count % 2 == 1)
                {
                    matrix[0, 2] = 1;
                    po3.Text = "X";
                }
                else if (count % 2 == 0)
                {
                    matrix[0, 2] = 2;
                    po3.Text = "O";
                } 
            }

            bool result = evaluateGameResult(matrix);
            if (result)
            {
                textBox1.Text = "Game Over";
            }
        }

        private void po4_Click(object sender, EventArgs e)
        {
            if (ifClicked[3] == false)
            {
                ifClicked[3] = true;
                count += 1;

                if (count % 2 == 1)
                {
                    matrix[1, 0] = 1;
                    po4.Text = "X";
                }
                else if (count % 2 == 0)
                {
                    matrix[1, 0] = 2;
                    po4.Text = "O";
                } 
            }

            bool result = evaluateGameResult(matrix);
            if (result)
            {
                textBox1.Text = "Game Over";
            }
        }

        private void po5_Click(object sender, EventArgs e)
        {
            if (ifClicked[4] == false)
            {
                ifClicked[4] = true;
                count += 1;

                if (count % 2 == 1)
                {
                    matrix[1, 1] = 1;
                    po5.Text = "X";
                }
                else if (count % 2 == 0)
                {
                    matrix[1, 1] = 2;
                    po5.Text = "O";
                } 
            }

            bool result = evaluateGameResult(matrix);
            if (result)
            {
                textBox1.Text = "Game Over";
            }
        }

        private void po6_Click(object sender, EventArgs e)
        {
            if (ifClicked[5] == false)
            {
                ifClicked[5] = true;
                count += 1;

                if (count % 2 == 1)
                {
                    matrix[1, 2] = 1;
                    po6.Text = "X";
                }
                else if (count % 2 == 0)
                {
                    matrix[1, 2] = 2;
                    po6.Text = "O";
                } 
            }

            bool result = evaluateGameResult(matrix);
            if (result)
            {
                textBox1.Text = "Game Over";
            }
        }

        private void po7_Click(object sender, EventArgs e)
        {
            if (ifClicked[6] == false)
            {
                ifClicked[6] = true;
                count += 1;

                if (count % 2 == 1)
                {
                    matrix[2, 0] = 1;
                    po7.Text = "X";
                }
                else if (count % 2 == 0)
                {
                    matrix[2, 0] = 2;
                    po7.Text = "O";
                } 
            }

            bool result = evaluateGameResult(matrix);
            if (result)
            {
                textBox1.Text = "Game Over";
            }
        }

        private void po8_Click(object sender, EventArgs e)
        {
            if (ifClicked[7] == false)
            {
                ifClicked[7] = true;
                count += 1;

                if (count % 2 == 1)
                {
                    matrix[2, 1] = 1;
                    po8.Text = "X";
                }
                else if (count % 2 == 0)
                {
                    matrix[2, 1] = 2;
                    po8.Text = "O";
                } 
            }

            bool result = evaluateGameResult(matrix);
            if (result)
            {
                textBox1.Text = "Game Over";
            }
        }

        private void po9_Click(object sender, EventArgs e)
        {
            if (ifClicked[8] == false)
            {
                ifClicked[8] = true;
                count += 1;

                if (count % 2 == 1)
                {
                    matrix[2, 2] = 1;
                    po9.Text = "X";
                }
                else if (count % 2 == 0)
                {
                    matrix[2, 2] = 2;
                    po9.Text = "O";
                } 
            }

            bool result = evaluateGameResult(matrix);
            if (result)
            {
                textBox1.Text = "Game Over";
            }
        }

        static bool evaluateGameResult(int [,] matrix)
        {
            
            bool[] cond = new bool[5];

            // evaluate each row and each column, if any one of them has
            // the same value, save true
            for(int i = 0; i < 3; i++ )
            {
                bool cond1 = matrix[i, 0] == matrix[i, 1] && matrix[i, 1] == matrix[i, 2];
                bool cond2 = matrix[0, i] == matrix[1, i] && matrix[1, i] == matrix[2, i];
                cond[i] = cond1 || cond2;
            }

            // evaluate the diagonal entries
            bool cond3 = matrix[0, 0] == matrix[1, 1] && matrix[1, 1] == matrix[2, 2];
            bool cond4 = matrix[0, 2] == matrix[1, 1] && matrix[1, 1] == matrix[2, 0];

            cond[3] = cond3;
            cond[4] = cond4;

            if(cond[0] || cond[1] || cond[2] || cond[3] || cond[4])
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
