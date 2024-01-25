using UnityEngine;
using UnityEngine.UI;
public class ButtonBehaviour: MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    [SerializeField] ResultsComparer resultsComparer;
    [SerializeField] Button button;
    [SerializeField] string wordToFind;
    private void Start()
    {
        button = button.GetComponent<Button>();
    }
    public void OnWordClicked()
    {
        print(gameObject.name);
        resultsComparer.UpdateAnswerNeeded(wordToFind);
        gameManager.SlowTime();
        button.interactable = false;
    }
    
}

