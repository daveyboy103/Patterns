using System;
using System.Windows.Input;

#nullable enable
namespace Delegates.Patterns.Command
{
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
}