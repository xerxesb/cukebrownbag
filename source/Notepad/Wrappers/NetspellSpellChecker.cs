using System;
using NetSpell.SpellChecker;

namespace Notepad.Services
{
    public class NetspellSpellChecker : INetspellSpellChecker
    {
        public bool CheckSpelling(string content)
        {
            var spelling = new Spelling();
            spelling.ShowDialog = ShowDialog;

            return !spelling.SpellCheck(content);
        }

        public bool ShowDialog { get; set; }
    }
}