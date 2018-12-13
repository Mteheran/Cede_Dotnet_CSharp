namespace Cede_Dotnet_CSharp_Interfaces.Interfaces
{
    public class Car : ICar
    {
        public string Mark { get; set; }
        public string Color { get; set; }
        public string Version { get; set; }

        public void Turn_On()
        {
            throw new System.NotImplementedException();
        }
    }
}
