using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaClase.Clases
{
    public class ClienteBancario
    {
        private int _numeroDocumento;
        private string _nombre;
        private string _apellido;
        private DateTime _edad;

        //propiedades, getter y setter
        public int NumeroDocumento
        {
            get
            {
                return _numeroDocumento;
            }
            set
            {
                _numeroDocumento = value;
            }
        }

    }
}
