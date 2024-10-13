using BibliotecaDigital.Dto.Vinculo;
using BibliotecaDigital.Models;

namespace BibliotecaDigital.Dto.LivroDto
{
    public class LivroCriacaoDto
    {
        public string Titulo { get; set; }
        public AutorVinculoDto Autor { get; set; }
    }
}
