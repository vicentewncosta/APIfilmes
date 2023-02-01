﻿using APIfilmes.Models;
using Microsoft.AspNetCore.Mvc; 

namespace APIfilmes.Controllers;

[ApiController]
[Route("[controller]")]

    public class FilmesController : ControllerBase
    {

        private static List<Filme> filmes = new List<Filme>();

        [HttpPost] 
        public void AdicionaFilme([FromBody] Filme filme)
        {
            filmes.Add(filme);
            Console.WriteLine(filme.Titulo);
            Console.WriteLine(filme.Duracao);
        }
    }