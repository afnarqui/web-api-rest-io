﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using web_api_rest_io.Module;

namespace web_api_rest_io.Dao
{
    public class CopiaDao
    {
        /// <summary>
        /// Andrés naranjo 2015-01-01 devuelve una lista de la entidad copia
        /// </summary>
        /// <returns></returns>
        public List<copia> BuscarDatosCopia()
        {


            using (DatosdesarrolloEntities bd = new DatosdesarrolloEntities())
            {
                return bd.copias.ToList();
            }

        }
    }
}