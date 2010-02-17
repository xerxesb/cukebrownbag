using System;

namespace Notepad.Services
{
    public class SpellCheckerService : ISpellCheckerService
    {
        private readonly INetspellSpellChecker _netspellSpellChecker;

        public SpellCheckerService(INetspellSpellChecker netspellSpellChecker)
        {
        }

        public bool CheckSpelling(string content)
        {
            throw new NotImplementedException("SpellCheckerService");
        }
    }
}