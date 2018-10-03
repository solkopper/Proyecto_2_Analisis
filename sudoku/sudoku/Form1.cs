using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sudoku
{
    public partial class Form1 : Form

    {
        //dimension de cada celda
        const int anchoCelda = 27;
        const int altoCelda = 27;

        //desplazamiento dese la esqina superrior de la ventana
        const int despX = -20;
        const int despY = 25;

        //color para celdas
        private Color colorFondo = Color.White;


        public Form1()
        {
           

            InitializeComponent();
        }

        public void DibujarTablero(int size)
        {
            Point posicion = new Point();
            //crear las celdas
            for(int fil=1; fil<=size;fil++)
                for(int col = 1; col<=size;col++)
                {
                    posicion.X = fil * (anchoCelda + 1) + despX;
                    posicion.Y = col * (altoCelda + 1) + despY;
                    Label lbl = new Label();
                    lbl.Name = fil.ToString() + col.ToString();
                    lbl.BorderStyle = BorderStyle.Fixed3D;
                    lbl.Location = posicion;
                    lbl.Width = anchoCelda;
                    lbl.Height = altoCelda;
                    lbl.TextAlign = ContentAlignment.MiddleCenter;
                    lbl.BackColor = colorFondo;
                    lbl.Font = new Font(lbl.Font, FontStyle.Bold);
                    lbl.Tag = "1";
                    this.Controls.Add(lbl);
                }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int size = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
            DibujarTablero(size);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
