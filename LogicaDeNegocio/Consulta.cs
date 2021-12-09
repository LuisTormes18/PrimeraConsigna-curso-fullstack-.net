using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio
{
    public  class Consulta
    {
        public string id{ get; set; }
        public Medico medico { get; set; }
        public Paciente paciente { get; set; }
        public string state { get; set; }
        public DateTime init { get; set; }
        public string motivo { get; set; }
        public string resultado { get; set; }

        public Consulta(Medico medico, Paciente paciente,string motivo)
        {
            Random r = new Random();
            this.medico = medico;
            this.paciente = paciente;
            this.state = "Activa";
            this.id = $"{medico.firstname}{r.Next().ToString()}{paciente.firstname}";
            this.init = new DateTime().ToLocalTime();
            this.motivo = motivo;
            this.resultado = "";
        } 
    }
}
