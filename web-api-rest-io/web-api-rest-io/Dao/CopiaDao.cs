using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using web.Module;

namespace web.Dao
{
    public class CopiaDao
    {
        /// <summary>
        /// Andrés naranjo 2015-01-01 devuelve una lista de la entidad copia
        /// </summary>
        /// <returns></returns>
        public List<copia> BuscarDatosCopia(long cedula)
        {


            using (DatosdesarrolloEntities bd = new DatosdesarrolloEntities())
            {
                return bd.copias.Where(afn=> cedula == 0 ? afn.cedulasociado== afn.cedulasociado : afn.cedulasociado== cedula).ToList();
            }

        }



    }
}