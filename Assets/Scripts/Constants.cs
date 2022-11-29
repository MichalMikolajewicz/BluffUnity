using System.ComponentModel;


public enum Suits
{
    NoSuits = -1,
    Spades = 0,
    Clubs = 1,
    Diamonds = 2,
    Hearts = 3,
}


public enum Ranks
{
    [Description("No Ranks")]
    NoRanks = -1,
    [Description("2")]
    Two = 2,
    [Description("3")]
    Three = 3,
    [Description("4")]
    Four = 4,
    [Description("5")]
    Five = 5,
    [Description("6")]
    Six = 6,
    [Description("7")]
    Seven = 7,
    [Description("8")]
    Eight = 8,
    [Description("9")]
    Nine = 9,
    [Description("10")]
    Ten = 10,
    [Description("J")]
    Jack = 11,
    [Description("Q")]
    Queen = 12,
    [Description("K")]
    King = 13,
    [Description("A")]
    Ace = 14,
}

//Not a final form
public enum GameState
{
    Idle,
    GameStarted,
    TurnStarted,
    TurnEnded,
    GameFinished
};