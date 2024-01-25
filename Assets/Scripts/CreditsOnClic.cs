using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsOnClic : MonoBehaviour
{
    [SerializeField] GameObject gameObjectSelected;
    public void OnClic()
    {
    gameObjectSelected .SetActive(true);
    }

    public void Deactivate()
    {
        gameObjectSelected.SetActive(false);
    }
}
