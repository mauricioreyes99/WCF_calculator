using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Calculator
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "CalculatorWCF" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione CalculatorWCF.svc o CalculatorWCF.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class CalculatorWCF : ICalculatorWCF
    {
        public double Division(double n1, double n2)
        {
            return (n1 / n2);
        }

        public double Multiplicacion(double n1, double n2)
        {
            return(n1 * n2);
        }

        public double Resta(double n1, double n2)
        {
            return(n1-n2);
        }

        public double Suma(double n1, double n2)
        {
            return(n1 + n2);
        }
    }
}
