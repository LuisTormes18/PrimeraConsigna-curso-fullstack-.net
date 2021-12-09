using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio
{
    public static class DataAccess
    {
        // Lista de consultas
       private static List<Consulta> consultas = new List<Consulta>();
        
        // Lista de medicos
        private static List<Medico> medicos = new List<Medico>() {

        new Medico("Juan", "Brito", 25, "medicina general","Disponible"), 
        new Medico("Pedro", "Rivera", 58, "Cardiologo","Disponible"),
        new Medico("Jesus", "Zambrano", 58, "Cardiologo","Disponible"),
        new Medico("Miguel", "Tovar", 58, "Cardiologo","Disponible"),
        new Medico("Alberto", "Rivera", 58, "Cardiologo","Disponible"),

       };

        // Lista de pacientes

        private static List<Paciente> pacientes = new List<Paciente>() {

        new Paciente("Virgilio", "Flores", 58, 3245673,"No Tiene"),
        new Paciente("Pedro", "Josefo",29, 2745673,"No Tiene"),
        new Paciente("Willian", "Mejia", 38, 27564321,"Cobertura Basica"),
        new Paciente("Juan", "Zambrano", 38, 27564321,"Cobertura Basica"),
        new Paciente("Marclaudio", "Morales", 51, 46564321,"Cobretura Completa"),
        new Paciente("Pablo", "Perez", 51, 46564321,"Cobretura Completa"),

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
        public static void setNewConsulta(Medico medico,Paciente paciente,string motivo)
        {
            Consulta consulta = new Consulta(medico, paciente, motivo);
            consultas.Add(consulta);
        }
        public static List<Consulta> getListaDeConsultas()
        {
            return consultas;

        }
        public static Paciente getPacienteById(string id)
        {
            // pacientes.ForEach(p => { if (p.id == id) paciente = p; } ); 

            Paciente paciente = pacientes.Find(p => p.id == id);

            return paciente;

        }

        public static Medico getMedicoByFullName(string fullname)
        {
            
             Medico medico = medicos.Find(m => m.fullname == fullname.Trim() );

            return medico;

        }
    }
}
