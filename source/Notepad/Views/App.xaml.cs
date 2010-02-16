using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
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
            var notepadViewModel = new NotepadViewModel();
            var notepadView = new NotepadView(notepadViewModel);

            notepadView.Show();
        }
    }
}
