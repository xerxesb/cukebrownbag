using Notepad.Services;
using NUnit.Framework;
using Rhino.Mocks;

namespace Notepad.Tests.Tests.Services.SpellCheckerServiceTests
{
    public class WhenCheckingSpelling : TestFor<SpellCheckerService>
    {
        private INetspellSpellChecker _mockNetspellSpellChecker;

        protected override void Context()
        {
            _mockNetspellSpellChecker = MockRepository.GenerateMock<INetspellSpellChecker>();
        }

        protected override SpellCheckerService CreateSubject()
        {
            return new SpellCheckerService(_mockNetspellSpellChecker);
        }

        protected override void Because()
        {
            _sut.CheckSpelling("some content");
        }

        [Test]
        public void ShouldCheckSpellingUsingSpellChecker()
        {
            _mockNetspellSpellChecker.AssertWasCalled(x => x.CheckSpelling("some content"));
        }

        [Test]
        public void ShouldNotShowDialog()
        {
            _mockNetspellSpellChecker.AssertWasCalled(x => x.ShowDialog = false);
        }
    }
}