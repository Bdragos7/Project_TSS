﻿using System.ComponentModel.DataAnnotations;

namespace Proiect_DAW_Cinemavazut.Models
{
    public class Filme_vazute
    {
        [Key]
        public int id_vazute { get; set; }
        public string? comentariu { get; set; }
        public bool favorit { get; set; }
        public int id_film { get; set; }
        public int id_utilizator { get; set; }
    }
}
