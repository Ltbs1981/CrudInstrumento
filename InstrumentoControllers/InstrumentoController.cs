using CrudInstrumento.Core.Entidades;
using CrudInstrumento.Servicos;
namespace CrudInstrumento.InstrumentoControllers
{
    internal class InstrumentoController
    {
        private InstrumentoService _instrumentoService;
        public void InserirInstrumento(string nome)
        {
            Instrumento instrumento = new Instrumento()
            {
                Nome = nome
            };
            _instrumentoService = new InstrumentoService();
            _instrumentoService.Add(instrumento);
        }
    }
}
