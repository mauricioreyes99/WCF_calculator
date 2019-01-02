using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Calculator
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ICalculatorWCF" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ICalculatorWCF
    {
        [OperationContract]
        double Suma(double n1, double n2);

        [OperationContract]
        double Resta(double n1, double n2);

        [OperationContract]
        double Multiplicacion(double n1, double n2);

        [OperationContract]
        double Division(double n1, double n2);
    }
}
