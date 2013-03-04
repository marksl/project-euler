using System;
using System.IO;
using System.Linq;
using System.Reflection;
using NUnit.Framework;

namespace Problems
{
    [TestFixture]
    public class Problem022
    {
        [Test]
        public void Test()
        {
            string text = ReadNames();

            ulong total = 0;
            ulong word = 1;
            string[] names = text.Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries);
            foreach (string name in names.OrderBy(x => x))
            {
                ulong wordSum = CalculateWordSum(name);
                total += (wordSum*word);

                word++;
            }

            Assert.Inconclusive(total.ToString());
        }

        private static string ReadNames()
        {
            string text;
            using (Stream stream = Assembly.GetExecutingAssembly()
                                           .GetManifestResourceStream("Problems.Problem022names.txt"))
            using (var reader = new StreamReader(stream))
            {
                text = reader.ReadToEnd();
            }
            return text;
        }

        private static ulong CalculateWordSum(string name)
        {
            ulong wordSum = 0;
            string trimmed = name.Replace("\"", "");
            foreach (char c in trimmed)
            {
                wordSum += (ulong) (c - '@');
            }
            return wordSum;
        }
    }
}