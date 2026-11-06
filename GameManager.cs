using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private PlayerDice playerDice;
    [SerializeField] private DevilDice devilDice;

    private int playerTotal = 0;
    private int devilTotal = 0;
    private int currentRound = 0;

    public void PlayRound()
    {
        if (currentRound >= 6)
        {
            Debug.Log("The game is already finished!");
            return;
        }

        currentRound++;

        int playerRoll = playerDice.Roll();
        int devilRoll = devilDice.Roll();

        playerTotal += playerRoll;
        devilTotal += devilRoll;

        Debug.Log("Round: " + currentRound);
        Debug.Log("Player total: " + playerTotal);
        Debug.Log("Devil total: " + devilTotal);

        if (currentRound == 6)
        {
            CheckWinner();
        }
    }

    private void CheckWinner()
    {
        if (playerTotal > devilTotal)
        {
            Debug.Log("Player wins!");
        }
        else if (devilTotal > playerTotal)
        {
            Debug.Log("Devil wins!");
        }
        else
        {
            Debug.Log("It's a draw!");
        }
    }
}
