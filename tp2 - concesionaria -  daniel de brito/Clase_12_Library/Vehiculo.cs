﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_12_Library
{
    public abstract class Vehiculo
    {
        #region atributos
        protected string _patente;
        protected EMarca _marca;
        protected ConsoleColor _color;
        #endregion

        #region enumerados
        public enum EMarca
        {
            Yamaha, Chevrolet, Ford, Iveco, Scania, BMW
        }
        #endregion

        #region constructor
        public Vehiculo(string patente, EMarca marca, ConsoleColor color)
        {
            this._patente = patente;
            this._marca = marca;
            this._color = color;
        }
        #endregion

        #region metodos
        /// <summary>
        /// Retornará la cantidad de ruedas del vehículo
        /// </summary>
        protected abstract short CantidadRuedas { get; }

        /// <summary>
        /// Muestra atributos del objeto
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("PATENTE: {0}\r\n", this._patente);
            sb.AppendFormat("MARCA  : {0}\r\n", this._marca.ToString());
            sb.AppendFormat("COLOR  : {0}\r\n", this._color.ToString());
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion

        #region sobrecargas
        /// <summary>
        /// Dos vehículos son iguales si comparten la misma patente
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator == (Vehiculo v1, Vehiculo v2)
        {
            bool ret = false;

            if (v1.Equals(v2._patente))
                ret = true;
            
            return ret;
        }
        /// <summary>
        /// Dos vehículos son distintos si su patente es distinta
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator != (Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
        #endregion
    }
}
