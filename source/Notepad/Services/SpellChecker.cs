using System;
using NetSpell.SpellChecker;

namespace Notepad.Services
{
    public class SpellChecker : ISpellChecker
    {
        public bool CheckSpelling(string content)
        {
            var spelling = new Spelling();
            spelling.ShowDialog = false;

            return spelling.SpellCheck(content);
        }
    }
}