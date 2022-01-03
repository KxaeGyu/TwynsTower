using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ExitMenu : MonoBehaviour
{

    public void OnYesBtn()
    {
        Application.Quit();
    }

    public void OnNoBtn()
    {
        this.gameObject.SetActive(false);
    }

}
