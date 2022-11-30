using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using UnityEngine;
using UnityEngine.U2D;

public class Card : MonoBehaviour
{
    public Suits Suit = Suits.NoSuits;
    public Ranks Rank = Ranks.NoRanks;
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    public SpriteAtlas Atlas;
    bool faceUp = true;
    //public GameObject myPrefab;

    public static Ranks GetRank(byte value) => (Ranks)(value / 4 + 1);
    public static Suits GetSuit(byte value) => (Suits)(value % 4);
    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        UpdateSprite();
    }
    void Update()
    {
        UpdateSprite();
    }
    void UpdateSprite()
    {
        if (faceUp)
        {
            spriteRenderer.sprite = Atlas.GetSprite(SpriteName());
        }
        else
        {
            spriteRenderer.sprite = Atlas.GetSprite("BackColor_Black");
        }
    }

    string GetRankDescription()
    {
        FieldInfo fieldInfo = Rank.GetType().GetField(Rank.ToString());
        DescriptionAttribute[] attributes = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];
        return attributes[0].Description;
    }
    string SpriteName()
    {
        string name = $"{Suit}{GetRankDescription()}";
        return name;
    }
}
