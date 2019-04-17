using System;
namespace FlashcardsListDb.Model
{
    public class Card
    {
            public int ID { get; set; }
            public string Question { get; set; }
            public Boolean Answer { get; set; }
            public Boolean IsCorrect { get; set; }
            public string ImageName { get; set; }
    }
}
