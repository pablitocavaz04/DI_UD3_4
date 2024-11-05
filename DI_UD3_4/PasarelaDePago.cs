using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DI_UD3_4
{
    public class PasarelaDePago
    {
        public event EventHandler<TransaccionEventArgs> TransaccionFinalizada;
        protected virtual void EnTransaccionFinalizada(Transaccion transaccion_)
        {
            if(TransaccionFinalizada != null)
                TransaccionFinalizada(this, new TransaccionEventArgs() { transaccion =  transaccion_ });
        }

        public void Pago(Transaccion transaccion_)
        {
            Thread.Sleep(2000);
            EnTransaccionFinalizada(transaccion_);
        }
    }
}
