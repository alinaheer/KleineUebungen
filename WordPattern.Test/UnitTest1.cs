using NUnit.Framework;
using WordPattern;

namespace WordPattern.Test
{
    public class Tests
    {
        [Test]
        public void TestPass()
        {
            Assert.Pass();
        }

        [Test]
        public void TestFail()
        {
            Assert.Fail();
        }

        [Test]
        public void Match_OneWordTextMatchesPattern()
        {
            var text = "buch";
            var pattern = "5";
            Assert.IsTrue(WordPattern.TextMatchesPattern(text, pattern));
        }

        [Test]
        public void Match_TwoWordsTextMatchesPattern()
        {
            var text = "buch katze";
            var pattern = "23";
            Assert.IsTrue(WordPattern.TextMatchesPattern(text, pattern));
        }

        [Test]
        public void DoesntMatch_TwoWordsTextMatchesPattern()
        {
            var text = "buch hund";
            var pattern = "22";
            Assert.IsFalse(WordPattern.TextMatchesPattern(text, pattern));
        }

        [Test]
        public void DoesntMatch_TextLongerThenPattern()
        {
            var text = "buch hund Katze";
            var pattern = "12";
            Assert.IsFalse(WordPattern.TextMatchesPattern(text, pattern));
        }

        [Test]
        public void DoesntMatch_PatternLongerThenText()
        {
            var text = "buch hund";
            var pattern = "123";
            Assert.IsFalse(WordPattern.TextMatchesPattern(text, pattern));
        }
    }
}