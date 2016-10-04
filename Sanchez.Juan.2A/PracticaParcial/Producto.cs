using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcial
{
    public class Producto
    {
        protected int _codDeBarra;
        protected EMarcaProducto _marca;
        protected float _precio;

        #region Propiedades

        public EMarcaProducto Marca
        {
            get
            {
                return this._marca;
            }
        }

        public float Precio
        {
            get 
            {
                return this._precio;
            }
        }
        #endregion

        #region Constructores

        public Producto(int codigo, EMarcaProducto marca, float precio)
        {
            this._codDeBarra = codigo;
            this._marca = marca;
            this._precio = precio;
        }

        #endregion

        #region Métodos

        protected static string MostrarProducto(Producto prod)
        {
            StringBuilder mySb = new StringBuilder();

            mySb.AppendLine("Cod. de barra: " + prod._codDeBarra);
            mySb.AppendLine("Marca: " + prod._marca.ToString());
            mySb.AppendLine("Precio: " + prod._precio);

            return mySb.ToString();
        }

        #endregion

        #region Operadores

        public static bool operator ==(Producto unProducto, Producto otroProducto)
        {
            if (unProducto.Marca == otroProducto.Marca && unProducto._codDeBarra == otroProducto._codDeBarra)
                return true;
            return false;
        }

        public static bool operator !=(Producto unProducto, Producto otroProducto)
        {
            if (unProducto.Marca == otroProducto.Marca && unProducto._codDeBarra == otroProducto._codDeBarra)
                return false;
            return true;
        }

        public static bool operator ==(Producto unProducto, EMarcaProducto marca)
        {
            if (unProducto.Marca == marca)
                return true;
            return false;
        }

        public static bool operator !=(Producto unProducto, EMarcaProducto marca)
        {
            if (unProducto.Marca == marca)
                return false;
            return true;
        }

        public static explicit operator int(Producto unProducto)
        {
            return unProducto._codDeBarra;
        }

        #endregion
    }
}
