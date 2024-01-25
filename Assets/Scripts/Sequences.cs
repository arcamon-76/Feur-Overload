using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sequences : MonoBehaviour
{
    SoundManager soundManager;
    [SerializeField] Image logo;
    [SerializeField] RectTransform buttonPanel;
    [SerializeField] RectTransform buttonPanel2;
    [SerializeField] GameObject startButton;
    [SerializeField] RectTransform logoRectTrans;

    public IEnumerator StartSequenceCoroutine() 
    {
        startButton.SetActive(false);
        logo.DOColor(new Color(255,255,255,255),0.3f);
        //soundManager.DoTheSound(soundManager.buttonClick);
        logoRectTrans.DOScale(new Vector3(0.964504f, 0.964504f, 0.964504f), 1); 
        yield return new WaitForSeconds(2f);
        logoRectTrans.DOScale(new Vector3(0.5382318f, 0.5382318f, 0.5382318f), 1);
        logoRectTrans.DOLocalMove(new Vector3(0, 123.2f, 0), 0.75f);
        yield return new WaitForSeconds(0.75f);
        buttonPanel.DOLocalMove(new Vector3(0, 0, 0), 0.3f);
    }
    public void StartSequenceFunction()
    {
        StartCoroutine(StartSequenceCoroutine());
    }

    public void LevelSelection()
    {
        buttonPanel.DOLocalMove(new Vector3(-777, 0, 0), 0.3f);
        buttonPanel2.DOLocalMove(new Vector3(0, 0, 0), 0.3f);
    }

    public void ReverseLevelSelection()
    {
        buttonPanel.DOLocalMove(new Vector3(0, 0, 0), 0.3f);
        buttonPanel2.DOLocalMove(new Vector3(777, 0, 0), 0.3f);
    }


}
