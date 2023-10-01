using System.Collections;
using firstApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace firstApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FirstApiController : ControllerBase
{
    public IEnumerable<Evento> _evento = new Evento[]{
        new Evento(){
            EventoId = 1,
            Local = "João Pessoa/PB",
            Tema = "Apresentação .Net 6",
            QtdPessoas = 100,
            Lote = "1º",
            ImagemUrl = "coverJP.png",
            DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")
        },
        new Evento(){
            EventoId = 2,
            Local = "Florianópolis/SC",
            Tema = "Apresentação Angular",
            QtdPessoas = 100,
            Lote = "2º",
            ImagemUrl = "coverSC.png",
            DataEvento = DateTime.Now.AddDays(5).ToString("dd/MM/yyyy")
        }
    };
    
    [HttpGet()]
    public IEnumerable<Evento> GetEventos()
    {
        return _evento;
    }

    [HttpGet("{id}")]
    public IEnumerable<Evento> GetEventosById(int id)
    {
        return _evento.Where(el => el.EventoId == id);
    }

    [HttpPost("{id}")]
    public string IndexPost(int id)
    {
        return "Resultado API - Método POST - Parâmetro " + id;
        // return $"Resultado API - Método POST - Parâmetro {id}";
    }
}
