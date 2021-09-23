using System;

namespace Delegates.Patterns.Command
{
    public class DrawingDocument : IDocumentManagement
    {
        public void Save()
        {
            Console.WriteLine("DrawingDocument file saved");
        }

        public void SaveAs()
        {
            Console.WriteLine("DrawingDocument file saved as");
        }

        public void New()
        {
            Console.WriteLine("DrawingDocument file new");
        }

        public void Delete()
        {
            Console.WriteLine("DrawingDocument file deleted");
        }
    }
}