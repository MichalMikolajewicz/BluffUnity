using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    [SerializeField]
    ProtectedData protectedData;
    public void Shuffle()
    {
        List<byte> cardValues = new List<byte>();
        //from Nine to Ace
        for (byte value = 36; value < 56; value++)
        {
            cardValues.Add(value);
        }

        List<byte> poolOfCards = new List<byte>();

        for (int index = 36; index < 56; index++)
        {
            int valueIndexToAdd = Random.Range(0, cardValues.Count);

            byte valueToAdd = cardValues[valueIndexToAdd];
            poolOfCards.Add(valueToAdd);
            cardValues.Remove(valueToAdd);
        }

        protectedData.SetPoolOfCards(poolOfCards);
    }
}
