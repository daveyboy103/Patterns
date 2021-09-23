using System;
using System.Windows.Input;

namespace Delegates.Patterns.Command
{
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
}