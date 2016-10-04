using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcial
{
    public class Galletita:Producto
    {
        protected float _peso;

        #region Constructores

        public Galletita(int codigo, float precio, EMarcaProducto marca, float peso)
            : base(codigo, marca, precio)
        {
            this._peso = peso;
        }

        #endregion 

        #region Métodos

        public static string MostrarGalletita(Galletita unaGalleta)
        {
            StringBuilder mySb = new StringBuilder();

            mySb.AppendLine(Producto.MostrarProducto(unaGalleta));
            mySb.AppendLine("Peso: " + unaGalleta._peso);

            return mySb.ToString();
        }

        #endregion
    }
}
