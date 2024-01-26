using System;
using UnityEngine;
public class GameManager : MonoBehaviour
{
    [SerializeField] TextConveyorBelt textConveyorBelt;
    [SerializeField] EffectManager effectManager;
    [SerializeField] SoundManager soundManager;
    [SerializeField] GameObject endGameObject;

    void Start()
    {
        if (textConveyorBelt == null)
        {
            textConveyorBelt = GetComponent<TextConveyorBelt>();
        }
        
        if (soundManager == null)
        {
            soundManager = GetComponent<SoundManager>();
        }
    }

    public void SlowTime()
    {
        textConveyorBelt.UpdateSpeedTo(0);
        soundManager.DoTheSound(soundManager.timeStop);
    }

    public void ResumeTime()
    {
        textConveyorBelt.UpdateSpeedTo(0.5f);
    }

    public void EndGame()
    {
        print("EndGame");
        endGameObject.SetActive(true);
    }
}