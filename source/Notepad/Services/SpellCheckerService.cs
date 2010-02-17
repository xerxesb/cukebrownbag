using System;

namespace Notepad.Services
{
    public class SpellCheckerService : ISpellCheckerService
    {
        private readonly INetspellSpellChecker _netspellSpellChecker;

        public SpellCheckerService(INetspellSpellChecker netspellSpellChecker)
        {
            _netspellSpellChecker = netspellSpellChecker;
        }

        public bool CheckSpelling(string content)
        {
            throw new Exception();
        }
    }
}