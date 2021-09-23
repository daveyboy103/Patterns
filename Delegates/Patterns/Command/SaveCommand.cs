using System;
using System.Windows.Input;

#nullable enable
namespace Delegates.Patterns.Command
{
    public class MenuController
    {
        public MenuController(IDocumentManagement documentManagement)
        {
            IDocumentManagement documentManagement1 = documentManagement;
            SaveCommand = new SaveCommand(documentManagement1);
            DeleteCommand = new DeleteCommand(documentManagement1);
            SaveAsCommand = new SaveAsCommand(documentManagement1);
            NewCommand = new NewCommand(documentManagement1);
        }
        public ICommand SaveCommand { get; } 
        public ICommand DeleteCommand { get; } 
        public ICommand SaveAsCommand { get; } 
        public ICommand NewCommand{ get; } 
    }
    public class SaveCommand : ICommand
    {
        private readonly IDocumentManagement _documentManagement;

        public SaveCommand(IDocumentManagement documentManagement)
        {
            _documentManagement = documentManagement;
        }
        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            _documentManagement.Save();
        }

        public event EventHandler? CanExecuteChanged;
    }    
    
    public class NewCommand : ICommand
    {
        private readonly IDocumentManagement _documentManagement;

        public NewCommand(IDocumentManagement documentManagement)
        {
            _documentManagement = documentManagement;
        }
        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            _documentManagement.New();
        }

        public event EventHandler? CanExecuteChanged;
    }
    
    public class DeleteCommand : ICommand
    {
        private readonly IDocumentManagement _documentManagement;

        public DeleteCommand(IDocumentManagement documentManagement)
        {
            _documentManagement = documentManagement;
        }
        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            _documentManagement.Delete();
        }

        public event EventHandler? CanExecuteChanged;
    }
    
    public class SaveAsCommand : ICommand
    {
        private readonly IDocumentManagement _documentManagement;

        public SaveAsCommand(IDocumentManagement documentManagement)
        {
            _documentManagement = documentManagement;
        }
        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            _documentManagement.SaveAs();
        }

        public event EventHandler? CanExecuteChanged;
    }

    public interface IDocumentManagement
    {
        void Save();
        void SaveAs();
        void New();
        void Delete();
    }

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