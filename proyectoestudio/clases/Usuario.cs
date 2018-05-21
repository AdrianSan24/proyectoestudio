using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoestudio.clases
{
    public class Usuario
    {
        private bool administrador;
        private Bitmap imagenPerfil;
        private string nombre;
        private string apellidos;
        private string codigo;
        private string contraseña;

        //getters and setters
        public Bitmap ImagenPefil { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Codigo { get; set; }
        public string Contraseña { get; set; }
    }
}
