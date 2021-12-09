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
        List<Medico> medicos = DataAccess.getMedicos("Disponible");
        Paciente paciente = new Paciente();
        Medico especialista = new Medico();

        public FormCrearNuevaConsulta(string id)
        {
            InitializeComponent();

            // obtener el paciente por el id
            paciente  = DataAccess.getPacienteById(id);

            //mostrar los datos del paciente
            showPaciente();

            //cargar los datos de los medicos al Combobox
            llenarComboboxDeEspecialistas();

            //guardar al especialista seleccionado
            saveEspecialista();
        }


        //funcion para mostrar los datos del paciente
        public void  showPaciente()
        {
            try
            {

                namePaciente.Text = $"{paciente.firstname} {paciente.lastname}";
                dniPaciente.Text = paciente.dni.ToString();
                agePaciente.Text = paciente.age.ToString();
                obra_social_paciente.Text = paciente.obra_social;

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }




        }

        public void llenarComboboxDeEspecialistas()
        {
            List<string> nombres = new List<string>();

            medicos.ForEach(m => { nombres.Add($"{m.firstname} {m.lastname} - {m.speciality}"); });
            comboBoxEspecialistas.DataSource = nombres;
        }


        // boton para crear una consulta
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                DataAccess.setNewConsulta(especialista, paciente, textBoxtMotivo.ToString());
                MessageBox.Show("Creda Correctamente");
                Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error al intentar crear la consulta");

            }

        }

        public void saveEspecialista()
        {
            string element = comboBoxEspecialistas.SelectedItem.ToString();

            string[] arg = element.Split('-');

            especialista = DataAccess.getMedicoByFullName(arg[0]);
        }
        private void comboBoxEspecialistas_SelectionChangeCommitted(object sender, EventArgs e)
        {

            saveEspecialista();

        }

        private void FormCrearNuevaConsulta_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
