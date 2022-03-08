using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OtherGames : MonoBehaviour
{

    public string url="https://play.google.com/store/apps/details?id=com.WhisperGames.RollDown";

    public void URL()
    {
        Application.OpenURL(url);
    }

    public void BackButton()
    {
        SceneManager.LoadScene(0);
    }
}
