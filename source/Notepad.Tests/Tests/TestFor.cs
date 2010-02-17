using NUnit.Framework;

namespace Notepad.Tests.Tests
{
    public abstract class TestFor<T>
    {
        protected T _sut;

        [SetUp]
        public void SetUp()
        {
            Context();

            _sut = CreateSubject();

            Because();
        }

        protected abstract void Because();
        protected abstract void Context();
        protected abstract T CreateSubject();
    }
}