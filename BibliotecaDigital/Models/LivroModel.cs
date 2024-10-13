namespace BibliotecaDigital.Models
{
    public class LivroModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public AutorModel Autor { get; set; } //livro pode ter um autor específico
    }
}
