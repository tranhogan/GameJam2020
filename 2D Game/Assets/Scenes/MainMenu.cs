using System.Collections;
using System.Collections.Generic;
/*using System.Runtime.Hosting;*/
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.Load(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
