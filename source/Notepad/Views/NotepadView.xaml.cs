using System.Windows;
using Notepad.ViewModels;

namespace Notepad
{
    /// <summary>
    /// Interaction logic for NotepadView.xaml
    /// </summary>
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
