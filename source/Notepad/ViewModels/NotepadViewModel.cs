using System;
using Notepad.Services;

namespace Notepad.ViewModels
{
    public class NotepadViewModel : INotepadViewModel
    {
        public NotepadViewModel(ISpellCheckerService netspellSpellChecker)
        {
        }
    }
}