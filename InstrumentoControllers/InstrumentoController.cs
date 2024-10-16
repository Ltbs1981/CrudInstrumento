﻿using CrudInstrumento.Core.Entidades;
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
        public void ListarInstrumentos()
        {
            var instrumentos = _instrumentoService.GetAll();
            foreach (var instrumento in instrumentos)
            {
                Console.WriteLine($"Lista de Instrumentos\n\t {instrumento.Id}\t\t{instrumento.Nome}");
            }
        }
        public void EditarInstrumento(int id, string novoNome)
        {
            _instrumentoService = new InstrumentoService();
            _instrumentoService.EditarInstrumento(id, novoNome);
        }
        public void DeletarInstrumento(int id)
        {
            _instrumentoService = new InstrumentoService();
            _instrumentoService.Delete(id);
        }
    }
}