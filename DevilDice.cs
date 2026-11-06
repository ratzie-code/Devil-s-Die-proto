using UnityEngine;

public class DevilDice: MonoBehaviour
{
    public int CurrentRoll { get; private set; }
    public int Roll()
    {
        CurrentRoll = Random.Range(1, 7);
        Debug.Log("Grei rolled: " + CurrentRoll);
        return CurrentRoll;
    }
}
