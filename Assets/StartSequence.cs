using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartSequence : MonoBehaviour
{
    SoundManager soundManager;
    [SerializeField] Image logo;
    [SerializeField] RectTransform buttonPanel;
    [SerializeField] GameObject startButton;
    RectTransform logoRectTrans;

    private void Start()
    {
        logoRectTrans = logo.gameObject.GetComponent<RectTransform>();
    }

    public IEnumerator StartSequenceCoroutine() 
    {
        startButton.SetActive(false);
        logo.DOColor(new Color(255,255,255,255),0.3f);
        //soundManager.DoTheSound(soundManager.buttonClick);
        logoRectTrans.DOScale(new Vector3(0.964504f, 0.964504f, 0.964504f), 1); 
        yield return new WaitForSeconds(2f);
        logoRectTrans.DOScale(new Vector3(0.5382318f, 0.5382318f, 0.5382318f), 1);
        logoRectTrans.DOMove(new Vector3(0, 123.2f, 0), 0.75f);
        yield return new WaitForSeconds(0.75f);
        buttonPanel.DOMove(new Vector3(0, 0, 0), 0.3f);
    }
    public void StartSequenceFunction()
    {
        StartCoroutine(StartSequenceCoroutine());
    }
}
