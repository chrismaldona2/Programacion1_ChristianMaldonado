using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer_con_Lista
{
    class Cliente
    {
        public int cod { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string correo { get; set; }
        public List<float> Facturas { get; set; }
        public List<float> Pagos { get; set; }

        public void agregarFactura(float monto)
        {
            Facturas.Add(monto);
        }

        public void agregarPago(float monto)
        {
            Pagos.Add(monto);
        }

        public float calcularDeuda()
        {
            float totalMontoPagar = Facturas.Sum();
            float totalMontoPagado = Pagos.Sum();
            return totalMontoPagar - totalMontoPagado;
        }
    }
}
