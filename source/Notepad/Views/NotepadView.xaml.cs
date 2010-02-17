using System.Windows;
using Notepad.ViewModels;

namespace Notepad.Views
{
    public partial class NotepadView : Window
    {
        public NotepadView()
        {
            InitializeComponent();
        }

        public NotepadView(INotepadViewModel notepadViewModel) : this()
        {
            DataContext = notepadViewModel;
        }
    }
}


