using System;

namespace Delegates.Patterns.Command
{
    public class TextDocument : IDocumentManagement
    {
        public void Save()
        {
            Console.WriteLine("Text file saved");
        }

        public void SaveAs()
        {
            Console.WriteLine("Text file saved as");
        }

        public void New()
        {
            Console.WriteLine("Text file new");
        }

        public void Delete()
        {
            Console.WriteLine("Text file deleted");
        }
    }
}