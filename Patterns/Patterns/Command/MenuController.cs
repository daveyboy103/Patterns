using System.Windows.Input;

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
}