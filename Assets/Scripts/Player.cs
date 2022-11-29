using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Player : IEquatable<Player>
{
    public string PlayerId;
    public string PlayerName;
    public bool IsAI;
    public List<Card> Cards = new List<Card>();

    int numberOfCards;

    public bool Equals(Player other)
    {
        return PlayerId.Equals(other.PlayerId);
    }
}
