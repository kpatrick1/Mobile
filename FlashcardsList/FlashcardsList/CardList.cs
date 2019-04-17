using System;
using System.Collections.Generic;

namespace FlashcardsList
{
    public class CardList
    {
        public static List<Card> lst = new List<Card>();

        public CardList()
        {
            Init();
        }

        public void ResetCardList()
        {
            lst.Clear();
            Init();
        }

        private void Init()
        {
            CardList.lst.Add(new Card
            {
                Question = "The President Rules the world",
                Answer = true,
                IsCorrect = false,
                ImageName = "dice"
            });
            CardList.lst.Add(new Card
            {
                Question = "Xaml is Amazing",
                Answer = true,
                IsCorrect = false,
                ImageName = "dice"
            });
            CardList.lst.Add(new Card
            {
                Question = "Xamarin is Easy",
                Answer = false,
                IsCorrect = false,
                ImageName = "dice"
            });
            CardList.lst.Add(new Card
            {
                Question = "School is time consuming",
                Answer = false,
                IsCorrect = false,
                ImageName = "dice"
            });
        }

    }
}
