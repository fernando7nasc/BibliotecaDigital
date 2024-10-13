namespace BibliotecaDigital.Models
{
    public class ResponseModel<T>    //tipo genérico
    {
        public T? Dados { get; set; } //dados do tipo generico serve para autor e livro e pode ser nulo caso nao encontre nada no banco
        public string Mensagem { get; set; } = string.Empty;
        public bool Status { get; set; } = true;

    }
}
