using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cronometrar
{
    public partial class Cronometro : Form
    {
        public Cronometro()
        {
            InitializeComponent();
        }

        int hh, mm, ss;

        
        private void reiniciar()
        {
            hh = 0;
            mm = 0;
            ss = 0;
            pantalla.Text = "00:00:00";
            Tiempo.Stop();
        }

        

        private void Cronometro_Load(object sender, EventArgs e)
        {
            pantalla.Text = "00:00:00";
        }

        private void Iniciar_Click(object sender, EventArgs e)
        {
            Tiempo.Start();
        }

        private void Pausar_Click(object sender, EventArgs e)
        {
            Tiempo.Stop();
        }

        private void Reiniciar_Click(object sender, EventArgs e)
        {
            reiniciar();
        }

        private void Tiempo_Tick(object sender, EventArgs e)
        {
            ss += 1;

            pantalla.Text = Convert.ToString(hh + ":" + mm + ":" + ss);
            if (ss >= 59)
            {
                mm += 1;
                ss = 0;

                if (mm >= 59)
                {
                    hh += 1;
                    mm = 0;
                }
            }
        }
    }
}
