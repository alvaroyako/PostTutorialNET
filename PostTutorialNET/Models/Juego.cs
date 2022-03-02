﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PostTutorialNET.Models
{
    [Table("JUEGOS")]
    public class Juego
    {
        [Key]
        [Column("ID")]
        public int IdJuego { get; set; }

        [Column("NOMBRE")]
        public string Nombre { get; set; }

        [Column("DESCRIPCION")]
        public string Descripcion { get; set; }

        [Column("CATEGORIA")]
        public string Categoria { get; set; }

        [Column("PRECIO")]
        public int Precio { get; set; }


    }
}
