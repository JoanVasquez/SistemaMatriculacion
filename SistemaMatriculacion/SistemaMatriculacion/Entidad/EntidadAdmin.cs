using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.SistemaMatriculacion.Entidades
{
    class EntidadAdmin
    {
        private string email, pass;
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
 

    }
}
