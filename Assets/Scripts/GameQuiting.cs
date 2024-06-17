using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameQuiting : MonoBehaviour
{
    // Start is called before the first frame update
    public void QuitGame()
    {
        string operatingSystem = SystemInfo.operatingSystem;
        if (operatingSystem.Contains("Android"))
        {
            AndroidJavaObject activity = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
            activity.Call<bool>("moveTaskToBack", true);
        }
        else
        {
            Application.Quit();
        }
    }
}
