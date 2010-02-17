using System.Windows;
using Notepad.Services;
using Notepad.ViewModels;
using Notepad.Wrappers;

namespace Notepad.Views
{
    public partial class App : Application
    {
        private void ApplicationStartUp(object sender, StartupEventArgs e)
        {
            var spellChecker = new SpellCheckerService(new NetspellSpellChecker());

            var notepadViewModel = new NotepadViewModel(spellChecker);

            var notepadView = new NotepadView(notepadViewModel);

            notepadView.Show();
        }
    }
}


