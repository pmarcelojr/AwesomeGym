namespace AwesomeGym.Core.DTOs
{
    public class ResultadoInscricaoDTO
    {
        public bool Sucesso { get; private set; }
        public string Mensagem { get; private set; }
        public ResultadoInscricaoDTO(bool sucesso, string mensagem)
        {
            Sucesso = sucesso;
            Mensagem = mensagem;
        }
    }
}