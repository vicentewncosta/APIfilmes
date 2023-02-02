using APIfilmes.Models;
using Microsoft.AspNetCore.Mvc; 

namespace APIfilmes.Controllers;

[ApiController]
[Route("[controller]")]

    public class FilmesController : ControllerBase
    {

        private static List<Filme> filme = new List<Filme>();
        private static int id = 0;

        [HttpPost] 
        public void AdicionaFilme([FromBody] Filme filme)
        {

            filme.Id = id++;
            FilmesController.filme.Add(filme);
            Console.WriteLine(filme.Titulo);
            Console.WriteLine(filme.Genero);
            Console.WriteLine(filme.Duracao);
        }

        [HttpGet]
        public IEnumerable<Filme> RecuperaFilmes()
        {
            return filme;
        }

        [HttpGet("{id}")]
        public Filme? RecuperaFilmePorId(int id)
        {
            return filme.FirstOrDefault(filme => filme.Id == id);
        }
    }
