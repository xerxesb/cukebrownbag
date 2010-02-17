using System;

namespace Notepad.Services
{
    public class SpellCheckerService : ISpellCheckerService
    {
        private readonly INetspellSpellChecker _netspellSpellChecker;

        public SpellCheckerService(INetspellSpellChecker netspellSpellChecker)
        {
            _netspellSpellChecker = netspellSpellChecker;
            _netspellSpellChecker.ShowDialog = false;
        }

        public bool CheckSpelling(string content)
        {
            return _netspellSpellChecker.CheckSpelling(content);
        }
    }
}