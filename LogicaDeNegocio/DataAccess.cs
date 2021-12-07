using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio
{
    public static class DataAccess
    {
        // LIsta de consultas
       private static List<Consulta> consultas = new List<Consulta>();

       private static List<Medico> medicos = new List<Medico>() {

        new Medico("Juan Sancho", "Brito", 25, "medicina general","Disponible"),
        new Medico("Pedro Sancho", "Rivera", 58, "Cardiologo","En Consulta"),

       };
       
        private static List<Paciente> pacientes = new List<Paciente>() {

        new Paciente("Virgilio", "Sambrano", 58, 3245673,"A su Suerte"),
        new Paciente("Josefo", "Zambrano", 38, 27564321,"Mantenido por el gobierno"),
        new Paciente("Marclaudio", "Morales", 51, 46564321,"Mantenido por el gobierno"),

        };

        public static List<Medico> getMedicos()
        {
            return medicos;
        }
        public static List<Medico> getMedicos(string state)
        {
            List<Medico> medicosByState = new List<Medico>();

            medicos.ForEach(medico => {

                if(medico.state == state)
                {
                    medicosByState.Add(medico);
                }
            });
            return medicosByState;
        }
        public static List<Paciente> getListaDeEspera()
        {
            return pacientes;
        }
        public static void setNewConsulta(Medico medico,Paciente paciente)
        {
            Consulta consulta = new Consulta(medico, paciente);
            consultas.Add(consulta);
        }
        public static List<Consulta> getListaDeConsultas()
        {
            return consultas;

        }
    }
}
