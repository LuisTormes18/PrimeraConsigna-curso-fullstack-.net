﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio
{
    public  class Consulta
    {
        public int id{ get; set; }
        public Medico medico { get; set; }
        public Paciente paciente { get; set; }
        public string state { get; set; }
        public DateTime init { get; set; }
        
        public Consulta(Medico medico, Paciente paciente)
        {
            this.medico = medico;
            this.paciente = paciente;
            this.state = "Activa";
            this.id = 1;
            this.init = new DateTime().ToLocalTime();
        } 
    }
}