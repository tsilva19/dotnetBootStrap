using System.Collections.Generic;

namespace PortifolioMVC.Models
{
    public class ListaAula
    {
        private static List<Aula> Lista = new List<Aula>();
        
        public static void adicionar(Aula aula){
            Lista.Add(aula);

        }
        public static List<Aula> Listar(){
            return Lista;
        }
    }
}