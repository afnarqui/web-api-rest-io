using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;

namespace web_api_rest_io.Facade
{
    [ServiceContract]
    interface IDatosFachada
    {
        /// <summary>
        /// Andrés naranjo 2015-01-01 devuelve una lista de la entidad copia
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        System.Collections.Generic.List<web_api_rest_io.Module.copia> BuscarDatosCopia();
    }
}