﻿using System.Data;
using Capa_de_datos;
using Capa_Entidad;

namespace Capa_Negocio
{
    public  class CN_Productos
    {
        readonly CD_Productos objProductos = new CD_Productos();

        //vista productos
        #region Buscar
        public DataTable BuscarProducto(string buscar)
        {
            return objProductos.Buscar(buscar);
        }
        #endregion

        //vista crudproductos

        #region CRUD

        #region Consultar

        public CE_Productos Consulta(int IdArticulo)
        {
            return objProductos.Consulta(IdArticulo);
        }

        #endregion

        #region Insertar

        public void Insertar(CE_Productos productos)
        {
           objProductos.CD_Insertar(productos);
        }

        #endregion

        #region Eliminar

        public void Eliminar(CE_Productos cE_Productos)
        {
            objProductos.CD_ELiminar(cE_Productos);
        }

        #endregion

        #region ActualizarDatos

        public void ActualizarDatos(CE_Productos productos)
        {
            objProductos.CD_Actualizar(productos);
        }

        #endregion

        #region ActualizarIMG

        public void ActualizarIMG(CE_Productos productos)
        {
            objProductos.CD_ActualizarIMG(productos);
        }

        #endregion


        #endregion
    }
}
