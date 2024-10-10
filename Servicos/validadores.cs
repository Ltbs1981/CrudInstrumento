using CrudInstrumento.Core.Entidades;

namespace CrudInstrumento.Servicos
{
    internal static class Validadores
    {
        // Validação para o nome do instrumento
        public static void ValidarNomeInstrumento(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                Console.WriteLine("O nome do instrumento não pode ser vazio ou nulo.");
                throw new ArgumentException("Nome inválido");
            }
            else if (nome.Length <= 4)
            {
                Console.WriteLine("O nome do instrumento deve ter mais que 4 caracteres.");
                throw new ArgumentException("Nome muito curto");
            }
        }

        // Validação para o ID do instrumento
        public static void ValidarIdInstrumento(int id)
        {
            if (id < 0)
            {
                Console.WriteLine("O ID do instrumento deve ser maior ou igual a 0.");
                throw new ArgumentException("ID inválido");
            }
        }

        // Validação se o instrumento existe
        public static void ValidarInstrumentoExistente(Instrumento instrumento)
        {
            if (instrumento == null)
            {
                Console.WriteLine("Instrumento não encontrado.");
                throw new ArgumentException("Instrumento inexistente");
            }
        }
    }
}
