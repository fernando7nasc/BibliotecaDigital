using BibliotecaDigital.Dto.Vinculo;
using BibliotecaDigital.Models;

namespace BibliotecaDigital.Dto.LivroDto
{
    public class LivroEdicaoDto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public AutorVinculoDto Autor { get; set; }
    }
}
