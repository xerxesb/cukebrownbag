namespace Notepad.Services
{
    public interface INetspellSpellChecker
    {
        bool CheckSpelling(string content);
        bool ShowDialog { get; set; }
    }
}