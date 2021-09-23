using System;
using System.Windows.Input;

namespace Delegates.Patterns.Command
{
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
}