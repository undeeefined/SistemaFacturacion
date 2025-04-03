using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFacturacion
{
    public partial class Home : Form
    {
        // Variable para llevar el conteo
        private int formsAbiertos = 0;

        // Metodo para manejar apertura
        private void AbrirFormularioSecundario(Form formulario)
        {
            formulario.FormClosed += (s, args) => FormularioCerrado();
            formsAbiertos++;
            this.Enabled = false; // deshabilita formulario principal
            formulario.Show(); // muestra el form secundario
        }

        // Metodo para manejar cierre de formulario
        private void FormularioCerrado()
        {
            formsAbiertos--; // Reduce en 1 el conteo de formularios abiertos.

            if (formsAbiertos == 0)
            {
                this.Enabled = true; // habilita formulario principal
            }
        }

        public Home()
        {
            InitializeComponent();
        }

        private void HOME_Load(object sender, EventArgs e)
        {

        }

        //Concierto 1
        private void opcion1_Click(object sender, EventArgs e)
        {
            AbrirFormularioSecundario(new Concierto1());

        }

        //Concierto 2
        private void opcion2_Click(object sender, EventArgs e)
        {
            AbrirFormularioSecundario(new Concierto1());
        }

        //Concierto 3
        private void opcion3_Click(object sender, EventArgs e)
        {
            AbrirFormularioSecundario(new Concierto1());
        }

        //Concierto 4
        private void opcion4_Click(object sender, EventArgs e)
        {
            AbrirFormularioSecundario(new Concierto1());
        }
    }
}
