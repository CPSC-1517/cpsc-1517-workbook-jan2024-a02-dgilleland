namespace Assorted;
using System;
public class Coin
{
    private static Random Rnd = new Random();
    public enum CoinFace { HEADS, TAILS };

    public CoinFace FaceShowing { get; private set; }

    public Coin()
    {
        Toss();
    }

    public void Toss()
    {
        if (Rnd.Next(2) == 0)
            FaceShowing = CoinFace.HEADS;
        else
            FaceShowing = CoinFace.TAILS;
    }
}