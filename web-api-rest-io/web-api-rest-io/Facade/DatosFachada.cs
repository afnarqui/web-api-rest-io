using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using web.Bl;
using web.Module;

namespace web.Facade
{
    public class DatosFachada : web.Facade.IDatosFachada
    {
        /// <summary>
        /// Andrés naranjo 2015-01-01 devuelve una lista de la entidad copia
        /// </summary>
        /// <returns></returns>
        public List<copia> BuscarDatosCopia(long cedula)
        {
            return new CopiaBl().BuscarDatosCopia(cedula).ToList();
        }

        
    }
}