using UnityEngine;

public class KaraokeCursor : MonoBehaviour
{
    [SerializeField] ResultsComparer resultsComparer;
    public bool isOnWord = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        resultsComparer.UpdateAnswerNeeded(collision.tag);
        isOnWord = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        isOnWord = false;
    }
}