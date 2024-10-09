﻿using CrudInstrumento.Core.Entidades;
using CrudInstrumento.Infra.Repositorio;

namespace CrudInstrumento.Servicos
{
    internal class InstrumentoService
    {
        private InstrumentoRepositorio _instrumentoRepositorio;

        public void Add(Instrumento instrumento)
        {
            _instrumentoRepositorio = new InstrumentoRepositorio(); // Corrigido o nome da classe
            _instrumentoRepositorio.Add(instrumento);
            Console.WriteLine("Instrumento inserido no sistema"); // Corrigido o texto
        }
    }
}