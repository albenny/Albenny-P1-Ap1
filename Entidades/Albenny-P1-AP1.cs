using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Albenny_P1_AP1.Entidades
{
    public class Ciudades
    {
        [Key]
        public int CiudadId { get; set; }
        public string Nombre { get; set; }
    }
}
