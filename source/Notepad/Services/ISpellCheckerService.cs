namespace Notepad.Services
{
    public interface ISpellCheckerService
    {
        bool CheckSpelling(string content);
    }
}