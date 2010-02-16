using System.Windows;
using Notepad.Services;
using Notepad.ViewModels;

namespace Notepad
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void ApplicationStartUp(object sender, StartupEventArgs e)
        {
            var spellChecker = new SpellChecker();

            var notepadViewModel = new NotepadViewModel(spellChecker);

            var notepadView = new NotepadView(notepadViewModel);

            notepadView.Show();
        }
    }
}
