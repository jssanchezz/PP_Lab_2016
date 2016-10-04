using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcial
{
    public class Gaseosa:Producto
    {
        protected float _litros;

        #region Constructores

        public Gaseosa(int codigo, float precio, EMarcaProducto marca, float litros)
            : base(codigo, marca, precio)
        {
            this._litros = litros;
        }

        public Gaseosa(Producto producto, float litros)
            : this((int)producto, producto.Precio, producto.Marca, litros)
        { }

        #endregion

        #region Métodos

        public string MostrarGaseosa()
        {
            StringBuilder mySb = new StringBuilder();

            mySb.AppendLine(Producto.MostrarProducto(this));
            mySb.AppendLine("Litros: " + this._litros);

            return mySb.ToString();
        }

        #endregion
    }
}
