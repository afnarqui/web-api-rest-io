using System;
using System.ServiceModel;
namespace web.Facade
{
    [ServiceContract]
    interface IDatosFachada
    {
        [OperationContract]
        System.Collections.Generic.List<web.Module.copia> BuscarDatosCopia(long cedula);
    }
}
