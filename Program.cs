using CrudInstrumento.Core.Entidades;
using CrudInstrumento.InstrumentoControllers;
Console.WriteLine("Thykkanno's Music Store");

InstrumentoController instrumentoController = new InstrumentoController();

instrumentoController.InserirInstrumento("Guitarra");
instrumentoController.InserirInstrumento("Violão");
instrumentoController.InserirInstrumento("Piano");
Console.WriteLine("Instrumentos Inseridos");
instrumentoController.ListarInstrumentos();

instrumentoController.EditarInstrumento(1, "Teclado");

instrumentoController.ListarInstrumentos();

instrumentoController.DeletarInstrumento(2);

instrumentoController.ListarInstrumentos();