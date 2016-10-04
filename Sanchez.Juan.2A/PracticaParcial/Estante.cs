using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcial
{
    public class Estante
    {
        protected sbyte _capacidad;
        protected List<Producto> _productos;

        public float ValorEstanteTotal
        {
            get
            {
                return this.GetValorEstante();
            }
        }

        #region Constructores

        private Estante()
        {
            this._productos = new List<Producto>();
        }

        public Estante(sbyte capacidad)
            : this()
        {
            this._capacidad = capacidad;
        }

        #endregion 

        #region Métodos

        public List<Producto> GetProductos()
        {
            return this._productos;
        }

        public static string MostrarEstante(Estante unEstante)
        {
            StringBuilder mySb = new StringBuilder();

            mySb.AppendLine("Estante:");
            mySb.AppendLine("Capacidad: " + unEstante._capacidad);
            mySb.AppendLine("Productos:");

            foreach (Producto item in unEstante.GetProductos())
            {
                if (item is Jugo)
                {
                    mySb.AppendLine(((Jugo)item).MostrarJugo());
                }

                if (item is Galletita)
                {
                    mySb.AppendLine(Galletita.MostrarGalletita((Galletita)item));
                }
                if (item is Gaseosa)
                {
                    mySb.AppendLine(((Gaseosa)item).MostrarGaseosa());
                }
            }

            return mySb.ToString();
        }

        public float GetValorEstante(ETipoProducto tipo)
        {
            float contador = 0;

            switch (tipo)
            {
                case ETipoProducto.Galletita:
                    foreach (Producto item in this.GetProductos())
                    {
                        if (item is Galletita)
                            contador = contador + item.Precio;
                    }
                    break;

                case ETipoProducto.Gaseosa:
                    foreach (Producto item in this.GetProductos())
                    {
                        if (item is Gaseosa)
                            contador = contador + item.Precio;
                    }
                    break;

                case ETipoProducto.Jugo:
                    foreach (Producto item in this.GetProductos())
                    {
                        if (item is Jugo)
                            contador = contador + item.Precio;
                    }
                    break;

                case ETipoProducto.Todos:
                    foreach (Producto item in this.GetProductos())
                    {
                        contador = contador + item.Precio;
                    }
                    break;
            }

            return contador;
        }

        private float GetValorEstante()
        {
            return this.GetValorEstante(ETipoProducto.Todos);
        }

        #endregion

        #region Operadores

        public static bool operator ==(Estante unEstante, Producto unProducto)
        {
            foreach (Producto item in unEstante.GetProductos())
            {
                if (item == unProducto)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Estante unEstante, Producto unProducto)
        {
            foreach (Producto item in unEstante.GetProductos())
            {
                if (item == unProducto)
                    return false;
            }
            return true;
        }

        public static bool operator +(Estante unEstante, Producto unProducto)
        {
            if (unEstante._productos.Capacity < unEstante._capacidad && unEstante != unProducto)
            {
                unEstante.GetProductos().Add(unProducto);
                return true;
            }                
            return false;
        }

        public static Estante operator -(Estante unEstante, Producto unProducto)
        {
            if (unEstante == unProducto)
                unEstante.GetProductos().Remove(unProducto);

            return unEstante;
        }

        public static Estante operator -(Estante unEstante, ETipoProducto tipo)
        {
            for (int i = 0; i < unEstante._productos.Count; i++)
            {
                switch (tipo)
                {
                    case ETipoProducto.Galletita:
                        unEstante.GetProductos().Remove(unEstante.GetProductos()[i]);
                        break;

                    case ETipoProducto.Gaseosa:
                        unEstante.GetProductos().Remove(unEstante.GetProductos()[i]);
                        break;

                    case ETipoProducto.Jugo:
                        unEstante.GetProductos().Remove(unEstante.GetProductos()[i]);
                        break;
                }
            }

            return unEstante;
        }

        #endregion
    }
}
