namespace Delegates.Patterns.Command
{
    public interface IDocumentManagement
    {
        void Save();
        void SaveAs();
        void New();
        void Delete();
    }
}