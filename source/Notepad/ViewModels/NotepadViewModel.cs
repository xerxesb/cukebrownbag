using System;
using Notepad.Services;

namespace Notepad.ViewModels
{
    public class NotepadViewModel : INotepadViewModel
    {
        public NotepadViewModel(ISpellChecker spellChecker)
        {
        }
    }
}