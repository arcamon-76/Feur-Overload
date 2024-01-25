using DG.Tweening;
using UnityEngine;

public class InputFieldMover : MonoBehaviour
{
    [SerializeField] Transform highPos;
    [SerializeField] Transform lowPos;
    [SerializeField] Transform movingObject;
    [SerializeField] float speed;
    public bool isShowed;
    void Start()
    {
        if (movingObject == null)
            movingObject = transform;
    }

    public void ShowInputField(bool temp_show)
    {
        if (temp_show)
        {
            movingObject.DOMove(highPos.position, speed);
            isShowed = true;
        }
        else
        {
            movingObject.DOMove(lowPos.position, speed);
            isShowed= false;
        }

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            ShowInputField(false);
        }
    }
}
