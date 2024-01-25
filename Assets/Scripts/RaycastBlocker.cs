using UnityEngine;

public class RaycastBlocker : MonoBehaviour
{
    [SerializeField] GameObject protectiveScreen;

    void Start()
    {
        if (protectiveScreen == null)
            protectiveScreen = gameObject;
    }

    public void ShowBlocker(bool temp_show)
    {
        if (temp_show)
            protectiveScreen.SetActive(true);
        else
            protectiveScreen.SetActive(false);

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            ShowBlocker(false);
        }
    }
}

