using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public bool isActive = true;
    [SerializeField] private List<Card> cards;
    private int firstInput = -1;
    private int secondInput = -1;
    private Deck cardsDeck;
    private Card card;

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
        cardsDeck = new Deck(cards);
        cardsDeck.GenerateCardPairs(5);
        // cardsDeck.Shuffle();
        cardsDeck.HideAllCards();
        cardsDeck.UpdateDisplay();
    }

    void Update()
    {
        CheckInput();
    }

    private void ResetInputs()
    {
        firstInput = -1;
        secondInput = -1;
    }

    public void ClickButton(int index)
    {
        
        if (firstInput == -1)
        {
            firstInput = index;
        }
        else if (secondInput == -1)
        {
            secondInput = index;
        }
    }

    void CheckInput()
    {
        isActive = true;
        if (InputCount == 1)
        {
            isActive = false;
            cardsDeck.UpdateDisplay();
        }
        else if (InputCount == 2)
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
}

    
