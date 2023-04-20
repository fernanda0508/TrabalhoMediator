using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteGrupoFace
{
    public class Program
    {
        static void Main(string[] args)
        {
            GrupoMeditor grupo = new GrupoMeditor();

            IntegranteGrupo alice = new IntegranteGrupo("Alice", grupo);
            IntegranteGrupo bob = new IntegranteGrupo("Bob", grupo);
            IntegranteGrupo charlie = new IntegranteGrupo("Charlie", grupo);


            alice.EnviarMensagem("Olá pessoal");



        }
    }
}
