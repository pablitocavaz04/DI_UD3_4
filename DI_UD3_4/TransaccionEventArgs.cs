using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_UD3_4
{
    public class TransaccionEventArgs : EventArgs
    {
        public Transaccion transaccion {  get; set; }
    }
}
