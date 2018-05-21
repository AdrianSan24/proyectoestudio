using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoestudio.clases
{
    public class Operario
    {
        public Image foto;
        private string nombre;
        private string apellidos;
        private string codigo;
        private List<string> horasInicio;
        private List<string> horasFin;
        private List<string> tiempoParada;
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Codigo { get; set; }
        public void set_HorasInicio(string value)
        {
            this.horasInicio.Add(value);
        }
        public void set_HorasInicio(List<string> lista)
        {
            this.horasInicio=lista;
        }
        public List<string> get_HorasInicio()
        {
            return this.horasInicio;
        }
        public string get_HorasInicio(int indice)
        {
            bool encontrado = false;
            for (int i = 0; i < horasInicio.Count; i++) {
                if (horasInicio[i] == horasInicio[indice]) {
                    encontrado = true;
                }
            }
            if (encontrado) {
                return horasInicio[indice];
            }
            else {
                return "no se ha encontrado";
            }
        }
        //setters and getters de horasFin
        public void set_HorasFin(string value)
        {
            this.horasFin.Add(value);
        }
        public void set_HorasFin(List<string> lista)
        {
            this.horasFin = lista;
        }
        public List<string> get_HorasFin()
        {
            return this.horasFin;
        }
        public string get_HorasFin(int indice)
        {
            bool encontrado = false;
            for (int i = 0; i < horasFin.Count; i++)
            {
                if (horasFin[i] == horasFin[indice])
                {
                    encontrado = true;
                }
            }
            if (encontrado)
            {
                return horasFin[indice];
            }
            else
            {
                return "no se ha encontrado";
            }
        }
        //setters and getters de tiempoParada
        public void set_TiempoParada(string value)
        {
            this.tiempoParada.Add(value);
        }
        public void set_TiempoParada(List<string> lista)
        {
            this.horasFin = lista;
        }
        public List<string> get_TiempoParada()
        {
            return this.tiempoParada;
        }
        public string get_TiempoParada(int indice)
        {
            bool encontrado = false;
            for (int i = 0; i < horasFin.Count; i++)
            {
                if (tiempoParada[i] == tiempoParada[indice])
                {
                    encontrado = true;
                }
            }
            if (encontrado)
            {
                return tiempoParada[indice];
            }
            else
            {
                return "no se ha encontrado";
            }
        }
    }
}
