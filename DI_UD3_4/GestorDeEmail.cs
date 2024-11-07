using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_UD3_4
{
    public class GestorDeEmail
    {
        public void EnTransaccionFinalizada(object sender, TransaccionEventArgs ev)
        {
            Console.WriteLine("Estimado user@server.com, le notificamos que el pago fue procesado correctamente mediante la transacción {0{ con fecha {1}.", 
                ev.transaccion.identificador, ev.transaccion.fechaTransaccion);
        }
    }
}
