using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaJaita
{
    public class Punto
    {
        #region "Atributos"
        public double X { get; set; }
        public double Y { get; set; }
        #endregion
        #region "Constructores"
        public Punto()
        {// Constructor sin atributos 
            this.X = 1;
            this.Y = 1;
        }
        #endregion
        #region "Constructores"
        public Punto(double cx, double cy)
        {// Constructor con atributos 
            this.X = cx;
            this.Y = cy;
        }
        #endregion
        #region "Metodos"
        public bool Iguales()
        {
            return (this.X == this.Y);
        }
        public bool SobreEje()
        {
            return ((this.X == 0) || (this.Y == 0));
        }
        public bool Iguales (Punto elemento)
        {
            return ((this.X == elemento.X) && (this.Y == elemento.Y));
        }
        #endregion
    }

}
