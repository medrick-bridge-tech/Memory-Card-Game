using System.Collections.Generic;
using Random = UnityEngine.Random;
namespace DefaultNamespace
{
    public class Deck
    {
        private List<Card> cards;
        private Card card;
        

        public Deck(List<Card> cards)
        {
            this.cards = cards;
        }

        public void GenerateCardPairs()
        {
            for (int i = 0; i < cards.Count; i++)
            {
                
            }
            
        }

        public void Shuffle()
        {
            System.Random random = new System.Random();
            var index = cards.Count;
            while (index > 1)
            {
                index--;
                int k = random.Next(index + 1);
                (cards[k], cards[index]) = (cards[index], cards[k]);
            }
        }

        public void ShowCard(int index)
        {
            cards[index].Show();
        }
        
        public void HideCard(int index)
        {
            cards[index].Hide();
        }

        public void HideAllCards()
        {
            for (int i = 0; i < cards.Count; i++)
            {
                card.Hide();
            }
        }

        public bool IsEqual(int i, int j)
        {
            if (i == j)
            {
                ShowCard(i);
            }
            else
            {
                HideCard(i);
            }
            return true;
        }

        public void UpdateDisplay()
        {
            foreach (var card in cards)
            {
                card.UpdateDisplay();
            }
        }

        public bool IsAllCardsShown()
        {
            foreach (var card in cards)
            {
                if (card.IsHidden)
                {
                    return false;
                }
            }

            return true;
        }
       
    }
}