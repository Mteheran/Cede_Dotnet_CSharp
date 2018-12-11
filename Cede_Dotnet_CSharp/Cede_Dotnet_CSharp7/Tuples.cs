namespace Cede_Dotnet_CSharp7
{
    public static class Tuples
    {
        public static (bool Result, int IntValue) TryParse(string stringValue)
        {
            bool IsInt = int.TryParse(stringValue, out int valueInt);

            return (IsInt, valueInt);
        }
    }
}
