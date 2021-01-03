using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sprites : MonoBehaviour
{
    public void clothes()
    {

    }

    public void computer()
    {

    }

    public void dog()
    {

    }

    public void kermit()
    {

    }

    public void notes()
    {

    }

    public void phone()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
