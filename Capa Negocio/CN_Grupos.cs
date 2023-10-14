﻿using Capa_de_datos;
using Capa_Entidad;

namespace Capa_Negocio
{
    public class CN_Grupos
    {
        CD_Grupos cD_Grupos = new CD_Grupos();
        CE_Grupos cE_Grupos=new CE_Grupos();

        #region Listar Grupos
        public List<string> ListaGrupos()
        {
            return cD_Grupos.ListarGrupos();
        }
        #endregion

        #region Nombre Grupo
        public CE_Grupos Nombre(int IdGrupo)
        {
            return cD_Grupos.Nombre(IdGrupo);
        }
        #endregion

        #region IdGrupo
        public int IdGrupo(string nombre)
        {
            return cD_Grupos.IdGrupo(nombre);
        }
        #endregion
    }
}
