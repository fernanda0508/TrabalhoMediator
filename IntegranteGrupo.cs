using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteGrupoFace
{

    public class IntegranteGrupo
    {
        public string Nome { get; set; }
        public GrupoMeditor Grupo { get; set; }

        public IntegranteGrupo(string nome, GrupoMeditor grupo)
        {
            Nome = nome;
            Grupo = grupo;
            grupo.AdicionarUsuario(this);
        }

        public void EnviarMensagem(string conteudo)
        {
            Grupo.EnviarMensagem(new Mensagem(conteudo, this));
            

        }

        public void ReceberMensagem(Mensagem mensagem)
        {
            Console.WriteLine($"{mensagem.DataEnvio} - {Nome} recebeu uma mensagem de {mensagem.Remetente}");
        }


    }
}
