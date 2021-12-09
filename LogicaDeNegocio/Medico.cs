using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio
{
    public class Medico : Persona
    {
        public string fullname { get; set; }
        public string speciality { get; set; }
        public string state{ get; set; }

        public Medico(string firstname, string lastname,int age, string speciality, string state)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.fullname = $"{firstname} {lastname}";
            this.age = age;
            this.speciality = speciality;
            this.state = state;
            this.id = $"{firstname}{randomID.ToString()}{age.ToString()}";
        }
        public Medico()
        {

        }

    }
}
