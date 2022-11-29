using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//not sure if that's needed or something already exists, will check later
[Serializable]
public class ProtectedData
{
    [SerializeField]
    List<byte> poolOfCards = new List<byte>();
    [SerializeField]
    List<byte> player1Cards = new List<byte>();
    [SerializeField]
    List<byte> player2Cards = new List<byte>();
    [SerializeField]
    List<byte> booksForPlayer1 = new List<byte>();
    [SerializeField]
    List<byte> booksForPlayer2 = new List<byte>();
    [SerializeField]
    string player1Id;
    [SerializeField]
    string player2Id;
    [SerializeField]
    string currentTurnPlayerId;
    [SerializeField]
    int currentGameState;
    [SerializeField]
    int selectedRank;

    byte[] encryptionKey;
    byte[] safeData;

    public void SetPoolOfCards(List<byte> cardValues)
    {
        Decrypt();
        poolOfCards = cardValues;
        Encrypt();
    }

    void Encrypt()
    {
        
    }

    void Decrypt()
    {
        
    }
}
