using CrudInstrumento.Core.Entidades;
using CrudInstrumento.Infra.Repositorio;

namespace CrudInstrumento.Servicos
{
    internal class InstrumentoService
    {
        private InstrumentoRepositorio _instrumentoRepositorio = new InstrumentoRepositorio();

        public void Add(Instrumento instrumento)
        {
            
            Validadores.ValidarNomeInstrumento(instrumento.Nome);

            _instrumentoRepositorio.Add(instrumento);
            Console.WriteLine("Instrumento inserido no sistema");
        }

        public List<Instrumento> GetAll()
        {
            return _instrumentoRepositorio.GetAll();
        }

        public void EditarInstrumento(int id, string novoNome)
        {
            
            Validadores.ValidarIdInstrumento(id);
            Validadores.ValidarNomeInstrumento(novoNome);

            var instrumento = _instrumentoRepositorio.GetAll().FirstOrDefault(i => i.Id == id);


            Validadores.ValidarInstrumentoExistente(instrumento);

            instrumento.Nome = novoNome;
            _instrumentoRepositorio.Update(instrumento);
            Console.WriteLine("Item atualizado");
        }

        public void Delete(int id)
        {
            
            Validadores.ValidarIdInstrumento(id);

            var instrumento = _instrumentoRepositorio.GetAll().FirstOrDefault(i => i.Id == id);


            Validadores.ValidarInstrumentoExistente(instrumento);

            _instrumentoRepositorio.Delete(instrumento);
            Console.WriteLine("Item removido");
        }
    }
}
