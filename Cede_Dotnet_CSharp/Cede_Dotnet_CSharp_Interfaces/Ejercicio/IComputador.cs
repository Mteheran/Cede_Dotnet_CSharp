using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cede_Dotnet_CSharp_Interfaces.Ejercicio
{
    interface IComputador
    {
        double Ram { get; set; }
        double Procesador_Capacidad { get; set; }
        string Procesador_Referencia { get; set; }        
        double Disco_Capacidad { get; set; }        
        void Encender();
        void Apagar();
    }
}
