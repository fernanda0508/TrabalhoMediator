using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteGrupoFace
{
    public class Mensagem
    {
        public string Conteudo { get; set; }

        public IntegranteGrupo Remetente { get; set; }

        public DateTime DataEnvio { get; set; }

        public Mensagem(string conteudo, IntegranteGrupo remetente)
        {
            Conteudo = conteudo;
            Remetente = remetente;
            DataEnvio = DateTime.Now;

        }
      
    }
}
