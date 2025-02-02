using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Referencia para LogicaEstudiante
using Logica;

namespace SistemaEscolar
{
    public partial class Form1 : Form
    {
        //Instanciar
        private LogicaEstudiante objLogicaEstudiante = new LogicaEstudiante();
        public Form1()
        {
            InitializeComponent();
        }

        private void PictureBox1(object sender, EventArgs e)
        {
            //Utilizar el objeto para el método
            objLogicaEstudiante.cargarImagen(pictureBox1);
        }
    }
}
