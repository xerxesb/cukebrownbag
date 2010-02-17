using System;
using System.ComponentModel;
using System.Windows.Input;
using Notepad.Core;
using Notepad.Services;

namespace Notepad.ViewModels
{
    public class NotepadViewModel : INotepadViewModel, INotifyPropertyChanged
    {
        private readonly ISpellCheckerService _spellCheckService;
        private const string SpellCheckResultValid = "There were no errors";
        private const string SpellCheckResultInvalid = "There were errors found during spell-checking";

        public ICommand PerformSpellCheckCommand { get; set; }

        public NotepadViewModel(ISpellCheckerService spellCheckService)
        {
            _spellCheckService = spellCheckService;

            PerformSpellCheckCommand = new ActionCommand(PerformSpellCheck);
        }

        private void PerformSpellCheck()
        {
            SpellCheckResult = _spellCheckService.CheckSpelling(Content)
                                   ? SpellCheckResultValid
                                   : SpellCheckResultInvalid;
        }

        public string Content { get; set; }

        private string _spellCheckResult;
        public string SpellCheckResult
        {
            get { return _spellCheckResult; }
            set
            {
                _spellCheckResult = value;
                OnPropertyChanged("SpellCheckResult");
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}