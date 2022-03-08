using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ScenesManager : MonoBehaviour
{

    public void MarketButton()
    {
        SceneManager.LoadScene(2);
    }
    public void MarketBackButton()
    {
        SceneManager.LoadScene(0);
    }
    public void OtherGamesButton()
    {
        SceneManager.LoadScene(3);
    }
    public void PlayButton()
    {
        SceneManager.LoadScene(1);
    }
    public void ExitButton()
    {
        Application.Quit();
    }

}
