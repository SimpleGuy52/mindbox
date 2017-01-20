using System.Collections.Generic;
using Cards;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace CardsTest
{
    [TestClass]
    public class CardHelperTest
    {
        [TestMethod]
        public void InCorrectParams()
        {
            Assert.AreEqual(CardHelper.Sort(null).Count, 0);
            Assert.AreEqual(CardHelper.Sort(new List<Card>()).Count, 0);
        }

        [TestMethod]
        public void CorrectParams()
        {
            var cards = new List<Card>
            {
                new Card("Moscow", "Berlin"),
                new Card("Paris", "Moscow"),
                new Card("Berlin", "Ottava")
            };

            var sortedExpected = new List<Card>
            {
                new Card("Paris", "Moscow"),
                new Card("Moscow", "Berlin"),
                new Card("Berlin", "Ottava")
            };

            var sortedJson = JsonConvert.SerializeObject(CardHelper.Sort(cards));
            var sortedExpectedJson = JsonConvert.SerializeObject(sortedExpected);

            Assert.AreEqual(CardHelper.Sort(cards).Count, 3);
            Assert.AreEqual(sortedJson, sortedExpectedJson);
        }
    }
}
