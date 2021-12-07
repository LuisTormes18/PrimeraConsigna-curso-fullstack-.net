using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaDeNegocio;

namespace PrimeraConsigna
{
    public partial class FormCrearNuevaConsulta : Form
    {
        public FormCrearNuevaConsulta(int id, string name, int age, double dni, string obra_social)
        {
            InitializeComponent();

            //mostrar los datos del paciente
            showPaciente(id, name, age, dni, obra_social);

        }


        public void  showPaciente(int id, string name, int age, double dni, string obra_social)
        {
            namePaciente.Text = name;
        }
    }
}
