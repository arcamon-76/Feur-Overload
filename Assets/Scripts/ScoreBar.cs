using DG.Tweening;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBar : MonoBehaviour
{
    [SerializeField] int currentScore;
    [SerializeField] TextMeshProUGUI scoreTextGO;
    Transform scoreTextGOOrigine;
    [SerializeField] int pointsDeductedOnError;
    [SerializeField] float winChain;
    [SerializeField] float multiplier;
    //TODO==========================================
    [SerializeField] Image multiplierBarGO;
    [SerializeField] float targetState;

    private void Start()
    {
        scoreTextGOOrigine = scoreTextGO.gameObject.transform;
    }

    public void AddPoints(float temp_points)
    {
        temp_points = temp_points * multiplier;
        currentScore += (int)temp_points;
        winChain += 1;

        UpdateMultiplier();
    }


    public void RemovePoints()
    {
        currentScore -= pointsDeductedOnError;
        winChain = 0;
        UpdateMultiplier();

    }

    public void UpdateMultiplier()
    {
        Mathf.Clamp(winChain, 0, 6);
        targetState = winChain / 6;
        DOTween.To(() => multiplierBarGO.fillAmount, x => multiplierBarGO.fillAmount = x, targetState, 1);
        switch (winChain)
        {
            case > 5:
                multiplier = 4;
                break;
            case > 2:
                multiplier = 3;
                break;
            case > 0:
                multiplier = 2;
                break;
            default:
                multiplier = 1;
                break;
        }
        StartCoroutine(UpdateScoreUp());
    }
    private IEnumerator UpdateScoreUp()
    {
        scoreTextGO.text = currentScore.ToString();
        scoreTextGO.gameObject.transform.DOShakePosition(1, 20);
        yield return new WaitForSeconds(1);
        scoreTextGO.gameObject.transform.DOMove(scoreTextGOOrigine.position, 1);
    }
}