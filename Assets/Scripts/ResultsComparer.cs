using TMPro;
using UnityEngine;

public class ResultsComparer : MonoBehaviour
{
    [SerializeField] ScoreBar scoreBar;
    [SerializeField] TMP_InputField inputField;
    [SerializeField] string answerNeeded;
    [SerializeField] string answerSubmited;
    [SerializeField] float PointsByRightAnswer;
    [SerializeField] InputFieldMover inputFieldMover;


    public void UpdateAnswerNeeded(string temp_word)
    {
        answerNeeded = temp_word;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SubmitAnswer();
        }
    }

    public void SubmitAnswer()
    {
        print("starting submition");
        if (inputField.text.ToLower() == "") return;
        //if (inputFieldMover.isShowed == false) return;

        if (answerNeeded.ToLower() == inputField.text.ToLower())
        {
            scoreBar.AddPoints(PointsByRightAnswer);
            print("true");
        }

        else if ((answerNeeded.ToLower() != inputField.text.ToLower()))
        {
            print("false");
            scoreBar.RemovePoints();
        }
    }
}