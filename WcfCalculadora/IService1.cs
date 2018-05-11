using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfCalculadora
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        int Suma(int num1,int num2);
        [OperationContract]
        int Resta(int num1,int num2);
        [OperationContract]
        int Multiplicacion(int num1,int num2);
        [OperationContract]
        int Division(int num1,int num2);

    }
}
