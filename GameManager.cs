using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
public class GameManager : MonoBehaviour
{
    [SerializeField] private PlayerDice playerDice;
    [SerializeField] private DevilDice devilDice;
    [SerializeField] private TMP_Text roundText;
    [SerializeField] private TMP_Text playerScoreText;
    [SerializeField] private TMP_Text devilScoreText;

    private int playerTotal = 0;
    private int devilTotal = 0;
    private int currentRound = 0;
    private void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            PlayRound();
        }
    }
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
        UpdateUI();


        Debug.Log("Round: " + currentRound);
        Debug.Log("Player total: " + playerTotal);
        Debug.Log("Devil total: " + devilTotal);

        if (currentRound == 6)
        {
            CheckWinner();
        }
    }
    private void UpdateUI()
    {
        roundText.text = "ROUND " + currentRound + " / 6";
        playerScoreText.text = "PLAYER: " + playerTotal;
        devilScoreText.text = "DEVIL: " + devilTotal;
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
    private void Start()
    {
        UpdateUI();
    }
}

