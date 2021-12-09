using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio
{
	public  abstract class  Persona
	{
        public double randomID
        {
            get
            {
                Random r = new Random();
                return r.Next(0,999);
            }
   
        }

        public string id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public int age { get; set; }

    }
}
