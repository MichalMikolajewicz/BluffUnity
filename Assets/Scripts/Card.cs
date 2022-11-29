using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public Suits Suit = Suits.NoSuits;
    public Ranks Rank = Ranks.NoRanks;

    public static Ranks GetRank(byte value) => (Ranks)(value / 4 + 1);
    public static Suits GetSuit(byte value) => (Suits)(value % 4);

    void Start()
    {

    }

    void Update()
    {

    }
}
