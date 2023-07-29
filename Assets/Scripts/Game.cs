using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class Game : MonoBehaviour
{
    private int firstInput = -1;
    private int secondInput = -1;
    private Deck cardsDeck;

    private int InputCount
    {
        get
        {
            if (firstInput != -1 && secondInput != -1)
                return 2;
            else if (firstInput != -1 || secondInput != -1)
                return 1;
            else
                return 0;
        }
    }
    
    void Start()
    {
        cardsDeck = new Deck(new List<Card>());
        cardsDeck.GenerateCardPairs();
        cardsDeck.Shuffle();
        cardsDeck.HideAllCards();
        cardsDeck.UpdateDisplay();
    }

    // Update is called once per frame
    void Update()
    {
        if (InputCount == 0)
        {
            GetInputs();
        } else if (InputCount == 1)
        {
            cardsDeck.UpdateDisplay();
            GetInputs();
        }
        else
        {
            cardsDeck.ShowCard(firstInput);
            cardsDeck.ShowCard(secondInput);
            cardsDeck.UpdateDisplay();
            if (cardsDeck.IsEqual(firstInput, secondInput))
            {
                if (cardsDeck.IsAllCardsShown())
                {
                    Debug.Log("YOU ARE TOO SMART BRO!");
                }
                else
                {
                    ResetInputs();
                }
            }
            else
            {
                cardsDeck.HideCard(firstInput);
                cardsDeck.HideCard(secondInput);
                ResetInputs();
            }
        }
    }

    private void ResetInputs()
    {
        firstInput = -1;
        secondInput = -1;
    }

    private void GetInputs()
    {
        // TODO:
    }
}
