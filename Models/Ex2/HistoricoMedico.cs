using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoPooEncapsulamento.Models.Ex2
{
    internal class HistoricoMedico
    {
        public string CodProntuario { get; set; }

        public void ExibirCodigo()
        {
            Console.WriteLine(CodProntuario);
        }

        public HistoricoMedico(string codprontuario)
        {
            CodProntuario = codprontuario;
        }
    }
}
