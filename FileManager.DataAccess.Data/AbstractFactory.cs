namespace FileManager.DataAcces.Data
{
    public interface IAbstractFactory
    {
        StudentDao Creator(string typo);
    }
}
