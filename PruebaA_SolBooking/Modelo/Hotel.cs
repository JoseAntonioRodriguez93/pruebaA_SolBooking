using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaA_SolBooking.Modelo
{
    public class Hotel
    {
        [Key]
        public string Nombre { get; set; }

        public int Categoria { get; set; }

        public string Descripcion { get; set; }

        public string Foto { get; set; }

        public bool Destacado { get; set; }
    }

    public class DetalleHotel
    {
        [Key]
        public string Nombre { get; set; }

        public string Ciudad { get; set; }

        public string Descripcion { get; set; }

        public string Imagen { get; set; }

        public string Caracteristicas { get; set; }
    }
}
