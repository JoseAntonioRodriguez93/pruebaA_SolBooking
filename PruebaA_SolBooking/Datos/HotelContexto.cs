using Microsoft.EntityFrameworkCore;
using PruebaA_SolBooking.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaA_SolBooking.Datos
{
    public class HotelContexto : DbContext
    {
        public HotelContexto(DbContextOptions<HotelContexto> options) : base(options)
        {

        }

        public DbSet<Hotel> CabeceraHotelItems { get; set; }
        public DbSet<DetalleHotel> DetalleHotelItems { get; set; }
    }
}
