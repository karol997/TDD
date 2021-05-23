using NUnit.Framework;
using TDD;

namespace TDDtest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_max()
        {
            TDDLibrary.liczba_max_a = -5;
            TDDLibrary.liczba_max_b = 3;
            TDDLibrary.liczba_max_c = 0;
            int expected = 3;
            TDDLibrary.max(TDDLibrary.liczba_max_a, TDDLibrary.liczba_max_b, TDDLibrary.liczba_max_c);
            Assert.AreEqual(TDDLibrary.maxa, expected);
        }
    }
}