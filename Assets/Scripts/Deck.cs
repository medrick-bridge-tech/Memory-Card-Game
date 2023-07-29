using System.Collections.Generic;

namespace DefaultNamespace
{
    public class Deck
    {
        private List<Card> cards;

        public Deck(List<Card> cards)
        {
            this.cards = cards;
        }

        public void GenerateCardPairs()
        {
            
        }

        public void Shuffle()
        {
            // TODO:
        }

        public void ShowCard(int index)
        {
            // TODO:
        }
        
        public void HideCard(int index)
        {
            // TODO:
        }

        public void HideAllCards()
        {
            // TODO:
        }

        public bool IsEqual(int i, int j)
        {
            // TODO:
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
            // TODO:
        }

    }
}