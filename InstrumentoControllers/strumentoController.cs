using CrudInstrumento.Servicos;
using CrudInstrumento.Core.Entidades;
using System.Runtime.CompilerServices;
namespace CrudInstrumento.InstrumentoControllers
{
    internal class strumentoController
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
