

namespace MeuApp.Classes
{
    public class MinhaExcecao : Exception
    {
        public MinhaExcecao(DateTime date)
        {
            QuandoAconteceu = date;
        }
        public DateTime QuandoAconteceu { get; set; }
    }
}