using TMPro;
using UnityEngine;

public class ResultsComparer : MonoBehaviour
{
    [Header("References")]
    [SerializeField] GameManager gameManager;
    [SerializeField] ScoreBar scoreBar;
    [SerializeField] InputFieldMover inputFieldMover;
    [SerializeField] TMP_InputField inputField;
    [SerializeField] KaraokeCursor karaokeCursor;
    [Header("Debug")]
    [SerializeField] string answerNeeded;
    [SerializeField] string answerSubmited;
    [SerializeField] float PointsByRightAnswer;
    [Header("Gameplay")]
    [SerializeField] bool cursorBasedGameplay;

    public void UpdateAnswerNeeded(string temp_word)
    {
        answerNeeded = temp_word;
    }

    void Update()
    {
        if (!cursorBasedGameplay)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                SubmitAnswer();
            }
        }

        if (cursorBasedGameplay)
        {


            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (karaokeCursor.isOnWord)
                    gameManager.SlowTime();
                else
                    scoreBar.RemovePoints();
            }

            if (Input.GetKeyDown(KeyCode.Return))
            {
                if (karaokeCursor.isOnWord)
                    SubmitAnswer();
            }
        }
    }

    public void SubmitAnswer()
    {
        print("starting submition");
        if (inputField.text.ToLower() == "") return;

        if (answerNeeded.ToLower() == inputField.text.ToLower())
        {
            scoreBar.AddPoints(PointsByRightAnswer);
            print("true");
        }

        else if (answerSubmited == "coubeh")
        {
            Application.Quit();
        }

        else if ((answerNeeded.ToLower() != inputField.text.ToLower()))
        {
            print("false");
            scoreBar.RemovePoints();
        }
        gameManager.ResumeTime();
    }
}