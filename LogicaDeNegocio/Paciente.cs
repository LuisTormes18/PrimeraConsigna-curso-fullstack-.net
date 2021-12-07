using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio
{
    public class Paciente : Persona
    {
        public double dni { get; set; }
        public string obra_social { get; set; }

        public Paciente(string firstname, string lastname , int age, double dni, string obra_social)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
            this.dni = dni;
            this.obra_social = obra_social;
            this.id = 1;
        }

        public Paciente()
        {

        }
    }

}
    

