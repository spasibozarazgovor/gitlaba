using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kursovoy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[][] A;
            A = new int[10][];
            A[0] = new int[10] { 0, 0, 1, 0, 0, 0, 0, 0, 0, 1 };
            A[1] = new int[10] { 1, 0, 1, 0, 0, 0, 0, 0, 0, 0 };
            A[2] = new int[10] { 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 };
            A[3] = new int[10] { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 };
            A[4] = new int[10] { 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 };
            A[5] = new int[10] { 0, 0, 0, 0, 0, 1, 0, 1, 0, 0 };
            A[6] = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 };
            A[7] = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 };
            A[8] = new int[10] { 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 };
            A[9] = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 };
            int[] B = new int[1000];
            found(ref A, ref B);

        }

        void found(ref int[][] A, ref int[] B)
        {

            int ver = 0;
            int rebr = 0;
            int m = 0;
            for (int i = 0; i < A.Length; i++)
                for (int k = i + 1; k < A.Length; k++)
                {
                    for (int j = 0; j < A.Length; j++)
                    {
                        if (A[i][j] == 1)
                        {
                            ver++;
                            rebr++;
                        }

                        if (A[k][j] == 1)
                        {
                            ver++;
                            rebr++;
                        }

                        if ((A[i][j] == 1) && (A[k][j] == 1))
                        {
                            ver--;
                        }                    
                        
                    //    if (A[i][k] == 1)
                    //{
                    //    ver--;
                    //}

                    //if (A[k][i] == 1)
                    //{
                    //    ver--;
                    //}
                       
                      
                    }

                    if (A[i][k] == 1)
                    {
                        ver--;
                    }

                    if (A[k][i] == 1)
                    {
                        ver--;
                    }
                    B[m] = ver + rebr;
                    ver = 0;
                    rebr = 0;
                    MessageBox.Show("i=" + i.ToString() + "k=" + k.ToString() + "B[m]=" + B[m].ToString());
                    textBox1.Text += B[m].ToString() + "   ";
                }
                            m++;
                            
                        
            
        }
    }
}

    

