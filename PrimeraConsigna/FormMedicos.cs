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
    public partial class FormMedicos : Form
    {
        public FormMedicos(List<Medico> medicos)
        {
            InitializeComponent();

            dgvMedicos.DataSource = medicos.ToList();
        }

        private void FormMedicos_Load(object sender, EventArgs e)
        {

        }
    }
}
