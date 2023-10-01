using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstApi.Models
{
    public class Evento
    {
        public int EventoId { get; set; }
        public string? Local { get; set; }  //A ? indica que a propriedade é opcional (pode ser nulo)
        public string? DataEvento { get; set; }
        public string? Tema { get; set; }
        public int QtdPessoas { get; set; }
        public string? Lote { get; set; }
        public string? ImagemUrl { get; set; }

    }
}