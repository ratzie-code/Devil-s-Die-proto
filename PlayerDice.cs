using UnityEngine;

public class PlayerDice: MonoBehaviour
{
   public int CurrentRoll { get; private set; }

    public int Roll()
    {
        CurrentRoll = Random.Range(1, 7);
    Debug.Log("Player rolled: " + CurrentRoll);
        return CurrentRoll;
    }
}

