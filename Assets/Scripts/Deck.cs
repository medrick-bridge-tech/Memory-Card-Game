using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using Random = UnityEngine.Random;

namespace DefaultNamespace
{
    public class Deck
    {
        private List<Card> cards;

        public Deck(List<Card> cards)
        {
            this.cards = cards;
        }
        // public void Shuffle()
        // {
        //     System.Random random = new System.Random();
        //     var index = cards.Count;
        //     while (index > 1)
        //     {
        //         index--;
        //         int k = random.Next(index + 1);
        //         (cards[k], cards[index]) = (cards[index], cards[k]);
        //     }
        // }
        public void GenerateCardPairs(int pairCount)
        {
            List<int> indexes = new List<int> {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            for (int i = 0; i < pairCount; i++)
            {
                var rand = Random.Range(0, 100).ToString();
                var index1 = indexes[Random.Range(0, indexes.Count)];
                indexes.Remove(index1);
                var index2 = indexes[Random.Range(0, indexes.Count)];
                indexes.Remove(index2);
                cards[index1].Setup(rand);
                cards[index2].Setup(rand);
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
            foreach (var card in cards)
            {
                card.Hide();
            }
        }
        public bool IsEqual(int i , int j)
        {
            if (cards[i].Value == cards[j].Value )
            {
                return true;
            }
            return false;
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
        public void UpdateDisplay()
        {
            Debug.Log("Updating Dis");
            foreach (var card in cards)
            {
                card.UpdateDisplay();
            }
        }
    }
}