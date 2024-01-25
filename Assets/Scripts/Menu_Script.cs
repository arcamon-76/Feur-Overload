using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Script : MonoBehaviour
{
    public void Mariage ()
    {
        SceneManager.LoadScene("Mariage");
    }
    public void Credits ()
    {
        SceneManager.LoadScene("Credits");
    }
    public void Interview_TV ()
    {
        SceneManager.LoadScene("Interview_TV");
    }
    public void SampleScene ()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Quitter ()
    {
        Application.Quit();
    }
}
