using AutoFixture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cede_Dotnet_CSharp_UnitTest_Demo.Data
{
    public static class PersonaData
    {
        public static List<Persona> GetPersonas()
        {
            List<Persona> personas = new List<Persona>();
            Fixture autoFixture = new Fixture();

            var persona = autoFixture.Build<Persona>()
                          .With(p => p.Edad, 1)
                          .Without(p => p.Apellido)
                          .Create();

            personas.Add(persona);
            personas.Add(autoFixture.Create<Persona>());
            personas.Add(autoFixture.Create<Persona>());
            personas.Add(autoFixture.Create<Persona>());
            personas.Add(autoFixture.Create<Persona>());

            return personas;

        }
    }
}
