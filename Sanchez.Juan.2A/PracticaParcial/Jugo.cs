using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcial
{
    public class Jugo:Producto
    {
        protected ESaborJugo _sabor;

        #region Constructores

        public Jugo(int codigo, float precio, EMarcaProducto marca, ESaborJugo sabor)
            : base(codigo, marca, precio)
        {
            this._sabor = sabor;
        }

        #endregion

        #region Métodos

        public string MostrarJugo()
        {
            StringBuilder mySb = new StringBuilder();

            mySb.AppendLine(Producto.MostrarProducto(this));
            mySb.AppendLine("Sabor: " + this._sabor.ToString());

            return mySb.ToString();
        }

        #endregion
    }
}
