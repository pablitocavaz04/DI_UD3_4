using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_UD3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Transaccion transaccion = new Transaccion() { identificador = 71645331, fechaTransaccion = "30/06/2010" };
            PasarelaDePago pasarela = new PasarelaDePago();
            GestorDeEmail gestorEmail = new GestorDeEmail();
            pasarela.TransaccionFinalizada += gestorEmail.EnTransaccionFinalizada;
            pasarela.Pago(transaccion);

        }
    }
}
