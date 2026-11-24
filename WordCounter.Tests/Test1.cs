
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;

namespace WordCounter.Tests
{
    [TestClass]
    public class UnitTest1
    {
        // Тест 1. Проверка двух слов
        [TestMethod]
        public void TestTwoWords()
        {
            int result = Program.CountWords("Hello world");

            Assert.AreEqual(2, result);
        }

        // Тест 2. Проверка одного слова
        [TestMethod]
        public void TestOneWord()
        {
            int result = Program.CountWords("Hello");

            Assert.AreEqual(1, result);
        }

        // Тест 3. Проверка нескольких пробелов
        [TestMethod]
        public void TestMultipleSpaces()
        {
            int result = Program.CountWords("Hello   world");

            Assert.AreEqual(2, result);
        }

        // Тест 4. Проверка пробелов в начале и конце
        [TestMethod]
        public void TestSpacesAtBeginningAndEnd()
        {
            int result = Program.CountWords("  Hello world  ");

            Assert.AreEqual(2, result);
        }

        // Тест 5. Проверка пустой строки
        [TestMethod]
        public void TestEmptyString()
        {
            int result = Program.CountWords("");

            Assert.AreEqual(0, result);
        }

        // Тест 6. Проверка строки только из пробелов
        [TestMethod]
        public void TestOnlySpaces()
        {
            int result = Program.CountWords("     ");

            Assert.AreEqual(0, result);
        }

        // Тест 7. Проверка нескольких слов
        [TestMethod]
        public void TestManyWords()
        {
            int result = Program.CountWords(
                "Python is a programming language"
            );

            Assert.AreEqual(5, result);
        }
    }
}
