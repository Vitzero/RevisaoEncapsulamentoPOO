using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoPooEncapsulamento.Models.Ex5
{
    internal class SegurancaConta
    {
        public bool ValidarSaque(decimal valor)
        {
            if(valor >=0 && valor <= 1000)
            {
                return true;
            }
            
            return false;
        }
    }
}
