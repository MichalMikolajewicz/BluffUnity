using System.ComponentModel;


public enum Suits
{
    NoSuits = -1,
    Spade = 0,
    Club = 1,
    Diamond = 2,
    Heart = 3,
}


public enum Ranks
{
    [Description("No Ranks")]
    NoRanks = -1,
    [Description("09")]
    Nine = 9,
    [Description("10")]
    Ten = 10,
    [Description("11")]
    Jack = 11,
    [Description("12")]
    Queen = 12,
    [Description("13")]
    King = 13,
    [Description("14")]
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