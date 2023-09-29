using System;

using System.Windows.Forms;

namespace FormMultidimencional_G2_GRAJ
{
    public partial class Form1 : Form
    {
        private bool Intro= true;
        private MultiDimencional m1;
        private MultiDimencional m2;
        private MultiDimencional m3;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnIntro_Click(object sender, EventArgs e)
        {
            if (Intro)
            {
                m1 = MultiDimencional.Leer(txtDisplay.Text);
                lbMatriz1.Text=m1.ToString();
                Intro = false;
          
            }

            else
            {
                m2 = MultiDimencional.Leer(txtDisplay.Text);
                lbMatriz2.Text = m2.ToString();
                Intro = true;

            }
            txtDisplay.Clear();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            /*if (rdbDeg.Checked)
            {
                MessageBox.Show("Seleccionaste Deg");
            }
            */
            m3 = m1 + m2;
            
            lbResultado.Text = m3.ToString();
            
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            m3 = m1 - m2;

            lbResultado.Text = m3.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (m1.N != m2.M)
            {
                MessageBox.Show("No se pueden multiplicar matrices con estas dimensiones.");
            }
            m3 = m1 * m2;

            lbResultado.Text = m3.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdbDeg.Checked)
            {

            }

            if (rdbRad.Checked)
            {

            }

        }
    }
}
