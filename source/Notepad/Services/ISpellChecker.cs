namespace Notepad.Services
{
    public interface ISpellChecker
    {
        bool CheckSpelling(string content);
    }
}