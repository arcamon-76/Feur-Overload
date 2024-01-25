using System.Collections;
using TMPro;
using UnityEngine;

public class InputFieldClearer : MonoBehaviour
{
    [SerializeField] ResultsComparer resultsComparer;
    public TMP_InputField inputField;

    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            StartCoroutine(ClearInputField());
        }
    }
    IEnumerator ClearInputField()
    {
        yield return new WaitForSeconds(0.2f);
        inputField.text = "";
    }
}
