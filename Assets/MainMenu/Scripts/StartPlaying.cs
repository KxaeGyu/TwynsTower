using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartPlaying : MonoBehaviour
{
    public void OnSinglePlayer()
    {
        SceneManager.LoadScene("SinglePlayer");
    }
    public void OnMultiPlayer()
    {
    }

}
