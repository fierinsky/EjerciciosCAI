using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Salario
    {
        private double _bruto;
        private string _codigoTransferencia;
        private double _descuentos;
        private DateTime _fecha;

        public double Bruto { get => _bruto; }
        public string CodigoTransferencia { get => _codigoTransferencia; }
        public double Descuentos { get => _descuentos; }
        public DateTime Fecha { get => _fecha; }

        public double GetSalario()
        {
            return _bruto;
        }

        private double GetSalarioNeto()
        {
            return _bruto - _descuentos;
        }
    }
}
