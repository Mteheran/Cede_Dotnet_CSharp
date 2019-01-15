using System;
using System.Collections.Generic;
using System.Text;

namespace Cede_Dotnet_CSharp_FileManager
{
    public class TextManager: ITextManager
    {
        private IFileManager FileManager { get; set; }

        public TextManager(IFileManager fileManager)
        {
            FileManager = fileManager;
        }

        public int CountLetters()
        {
            return FileManager.GetTextFile().Length;
        }

        public bool IsANumber()
        {
            return double.TryParse(FileManager.GetTextFile(), out var number);
        }
    }
}
