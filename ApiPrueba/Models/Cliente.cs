using System;
using System.Collections.Generic;

namespace ApiPrueba.Models
{
    public partial class Cliente
    {
        public int Id { get; set; }
        public string? Rut { get; set; }
        public string? Nombres { get; set; }
        public string? Apellidos { get; set; }
    }
}
