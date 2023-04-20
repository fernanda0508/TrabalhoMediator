using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteGrupoFace
{
    public class GrupoMeditor
    {
        private List<IntegranteGrupo> usuarios = new List<IntegranteGrupo>();

        public void AdicionarUsuario(IntegranteGrupo usuario)
        {
            usuarios.Add(usuario);
        }

        public void EnviarMensagem(Mensagem mensagem)
        {
            foreach (var usuario in usuarios)
            {
                if (usuario != mensagem.Remetente)
                {
                    usuario.ReceberMensagem(mensagem);

                }
            }
           
        }


    }
}
