using System;
using System.Windows.Input;

namespace Delegates.Patterns.Command
{
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
}