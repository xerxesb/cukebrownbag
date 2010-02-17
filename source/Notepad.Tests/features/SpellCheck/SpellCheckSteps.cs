using Notepad.Services;
using Notepad.ViewModels;
using NUnit.Framework;
using Rhino.Mocks;
using TechTalk.SpecFlow;

namespace Notepad.Tests.features.SpellCheck
{
    [Binding]
    public class SpellCheckSteps
    {
        private NotepadViewModel _notepadViewModel;
        private INetspellSpellChecker _netspellSpellChecker;

        [BeforeScenario()]
        public void SetUp()
        {
            _netspellSpellChecker = MockRepository.GenerateStub<INetspellSpellChecker>();
            _notepadViewModel = new NotepadViewModel(new SpellCheckerService(_netspellSpellChecker));
        }

        [Given(@"the content is valid")]
        public void GivenTheContentIsValid()
        {
            _netspellSpellChecker.Stub(x => x.CheckSpelling(null)).IgnoreArguments().Return(true);
        }

        [Given(@"I have entered ""(\S+)""")]
        public void GivenIHaveEnteredHello(string content)
        {
            _notepadViewModel.Content = content;
        }

        [When(@"I perform a spell check")]
        public void WhenIPerformASpellCheck()
        {
            _notepadViewModel.PerformSpellCheckCommand.Execute(null);
        }

        [Then(@"the result should show there were no errors")]
        public void ThenTheResultShouldShowThereWereNoErrors()
        {
            Assert.That(_notepadViewModel.SpellCheckResult, Is.EqualTo("There were no errors"));
        }
    }
}