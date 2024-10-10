using CrudInstrumento.Core.Entidades;
using CrudInstrumento.Infra.Repositorio;

namespace CrudInstrumento.Servicos
{
    internal class InstrumentoService
    {
        private InstrumentoRepositorio _instrumentoRepositorio;

        public void Add(Instrumento instrumento)
        {
            _instrumentoRepositorio = new InstrumentoRepositorio(); 
            _instrumentoRepositorio.Add(instrumento);
            Console.WriteLine("Instrumento inserido no sistema"); 
        }
        public List <Instrumento> GetAll()
        {
            return _instrumentoRepositorio.GetAll();
        }
        public void EditarInstrumento(int id, string novoNome)
        {
            _instrumentoRepositorio = new InstrumentoRepositorio();
            var instrumento = _instrumentoRepositorio.GetAll().FirstOrDefault(i => i.Id == id);
            instrumento.Nome = novoNome;
            _instrumentoRepositorio.Update(instrumento);
            Console.WriteLine("Item atualizado");
        }
    }
}
