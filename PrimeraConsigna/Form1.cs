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
	public partial class Form1 : Form
	{


		public Form1()
		{
			InitializeComponent();

			// mostrando lista de medicos disponible

			showMedicos("Disponible");

			// Mostarndo la lista de espera

			showListaDeEspera();

			//mostrabdo la lista de consultas del día

			showListaDeConsultas();

		}

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        #region Funciones para mostar datos
        //Funcion para mosrtar a lista de Medicos
        public void showMedicos(string state)
		{
			dgvMedicos.DataSource = DataAccess.getMedicos(state).ToList();
			dgvMedicos.Columns["state"].Visible = false;
			dgvMedicos.Columns["id"].Visible = false;

		}

		//Funcion para mosrtar a lista de espera
		public void showListaDeEspera()
		{
			
			 
			DataTable dat2 = new DataTable();

			dat2.Columns.Add("id");
			dat2.Columns.Add("Paciente");
			dat2.Columns.Add("Edad");
			dat2.Columns.Add("DNI");
			dat2.Columns.Add("Obra Social");

			var pacientes = DataAccess.getListaDeEspera().ToList();

			pacientes.ForEach(paciente => {

				DataRow row = dat2.NewRow();

				row["id"] = paciente.id;
				row["Paciente"] = $"{paciente.firstname} {paciente.lastname}";
				row["Edad"] = paciente.age;
				row["DNI"] = paciente.dni;
				row["Obra Social"] = paciente.obra_social;

                try
                {
					dat2.Rows.Add(row);
				}
				catch(Exception ex)
                {
					Console.WriteLine(ex);
                }

			});

			dgvListaDeEspera.DataSource = dat2;
			dgvListaDeEspera.Columns["id"].Visible = false;
			 
			 

		}

		//Funcion para mosrtar a lista de consultas
		public void showListaDeConsultas()
		{
			DataTable dat = new DataTable();

			dat.Columns.Add("id");
			dat.Columns.Add("Medico");
			dat.Columns.Add("Especialidad");
			dat.Columns.Add("Paciente");
			dat.Columns.Add("Hora de Entrada");


			var consultas = DataAccess.getListaDeConsultas().ToList();

			consultas.ForEach(consulta => {

				DataRow fila = dat.NewRow();

				fila["id"] = consulta.id;
				fila["Medico"] = $"{consulta.medico.firstname} {consulta.medico.lastname}";
				fila["Especialidad"] = consulta.medico.speciality;
				fila["Paciente"] = $"{consulta.paciente.firstname} {consulta.paciente.lastname} ";
				fila["Hora de Entrada"] = consulta.init.ToString();
				dat.Rows.Add(fila);

			});

			dgvListaDeConsultas.DataSource = dat;
			dgvListaDeConsultas.Columns["id"].Visible = false;

		}
		#endregion


	
		



		// funcion para abrir un formulario cn la lista de todos ls medicos
		private void buttonVerTodosLosMedicos_Click(object sender, EventArgs e)
        {

			Form form = new FormMedicos(DataAccess.getMedicos());

			form.ShowDialog();


        }

		// funcion para guardar la nueva consulta
		public void PasarAConsulta(Medico medico, Paciente paciente)
		{
			DataAccess.setNewConsulta(medico, paciente);
		}
		// funcion para crear una nueva consulta

		private void dgvListaDeEspera_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
			try
			{
				if (dgvListaDeEspera.Columns[e.ColumnIndex].Name == "iniciarConsulta")
				{


					int id = Int32.Parse(dgvListaDeEspera.CurrentRow.Cells[1].Value.ToString());
					string name = dgvListaDeEspera.CurrentRow.Cells[2].Value.ToString();
					int age = Int32.Parse(dgvListaDeEspera.CurrentRow.Cells[3].Value.ToString());
					double dni = Double.Parse(dgvListaDeEspera.CurrentRow.Cells[4].Value.ToString());
					string obra_social = dgvListaDeEspera.CurrentRow.Cells[5].Value.ToString();

					Form form = new FormCrearNuevaConsulta(id,name,age,dni,obra_social);

					form.ShowDialog();

				}

			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
		}
    }
}
