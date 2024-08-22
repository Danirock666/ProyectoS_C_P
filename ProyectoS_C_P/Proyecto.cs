using System;

namespace ProyectoS_C_P
{
    internal class Proyecto
    {
        public string Nombre { get; set; }
        public int Descripcion { get; set; }
        public bool Estado { get; set; }
        public int HorasTrabajadas { get; set; }
        public int HorasTotales { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
