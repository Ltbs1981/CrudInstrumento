using CrudInstrumento.Core.Entidades;
namespace CrudInstrumento.Infra.Repositorio
{
    internal class InstrumentoRepositorio
    {
        private static List<Instrumento> instrumentos = new List<Instrumento>();
        private static int id = 0;

        public void Add(Instrumento instrumento)
        {
            instrumento.Id = id++;
            instrumentos.Add(instrumento);
        }
    }
}