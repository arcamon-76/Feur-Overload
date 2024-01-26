using DG.Tweening;
using UnityEngine;

public class TextConveyorBelt : MonoBehaviour
{
    enum TextDirection
    {
        TimerBased,
        ToTheLeft,
        ToTheRight,
        ToTheTop,
        ToTheBottom,
    }

    [SerializeField] GameManager gameManager;
    [SerializeField] RectTransform textblock;
    [SerializeField, Range(0, 2)] float TextFieldSpeed;
    [Header("End Trigger")]
    [SerializeField] TextDirection textDirection;
    [SerializeField] float maxValueForEndTrigger;

    private void Start()
    {
        if (textblock == null)
        {
            textblock = this.GetComponent<RectTransform>();
        }
    }

    public void UpdateSpeedTo(float temp_newSpeed)
    {
        DOTween.To(() => TextFieldSpeed, x => TextFieldSpeed = x, temp_newSpeed, 1);
    }

    private void Update()
    {
        switch (textDirection)
        {
            case TextDirection.ToTheLeft:
                textblock.transform.Translate(new Vector3(-TextFieldSpeed, 0));
                if (textblock.localPosition.x < maxValueForEndTrigger)
                    gameManager.EndGame();
                break;

            case TextDirection.ToTheRight:
                textblock.transform.Translate(new Vector3(TextFieldSpeed, 0));
                if (textblock.localPosition.x > maxValueForEndTrigger)
                    gameManager.EndGame();
                break;

            case TextDirection.ToTheTop:
                textblock.transform.Translate(new Vector3(0, TextFieldSpeed));
                if (textblock.localPosition.y > maxValueForEndTrigger)
                    gameManager.EndGame();
                break;

            case TextDirection.ToTheBottom:
                textblock.transform.Translate(new Vector3(0, -TextFieldSpeed));
                if (textblock.localPosition.y < maxValueForEndTrigger)
                    gameManager.EndGame();

                break;
            case TextDirection.TimerBased:
                maxValueForEndTrigger = maxValueForEndTrigger - (1 / Time.deltaTime);
                if (maxValueForEndTrigger < 0)
                    gameManager.EndGame();
                break;
            default:
                break;
        }
    }
}