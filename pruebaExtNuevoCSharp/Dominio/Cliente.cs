using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pruebaExtNuevoCSharp.Dominio
{
    public class Cliente
    {
        private string nombre;
        private string apellido;
        private string telefono;
        private string direccion;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
    }
}