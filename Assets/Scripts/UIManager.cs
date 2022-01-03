using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{
    public GameObject Menu;
    public GameObject NewGameMenu;
    public GameObject OptionsMenu;
    public GameObject HighscoreMenu;
    public GameObject ExitMenu;

    private GameObject prevMenu;
    private GameObject currMenu;

    public List<GameObject> prevMenus = new List<GameObject>();

    private void Start()
    {
        currMenu = Menu;
    }

    public void OnChangeMenu(GameObject menu)
    {
        prevMenus.Add(currMenu);
    }
    public void OnNewGame()
    {
        OnChangeMenu(NewGameMenu);

        Menu.SetActive(false);
        NewGameMenu.SetActive(true);

    }
    public void OnOptions()
    {
        OnChangeMenu(OptionsMenu);

        Menu.SetActive(false);
    }
    public void OnHighscore()
    {
        OnChangeMenu(HighscoreMenu);

        Menu.SetActive(false);
    }
    public void OnExit()
    {

        ExitMenu.SetActive(true);
    }

    public void OnBack()
    {
        if (prevMenus.Count == 0)
            return;

        Menu.SetActive(false);
        NewGameMenu.SetActive(false);
        OptionsMenu.SetActive(false);
        HighscoreMenu.SetActive(false);
        ExitMenu.SetActive(false);

        prevMenus[prevMenus.Count-1].SetActive(true);
        prevMenus.RemoveAt(prevMenus.Count-1);

    }
}
