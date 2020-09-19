using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoaderScript : MonoBehaviour
{
    public Animator transition;

    public float transitionTime = 1f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            LoadNext();
        }
    }

    public void LoadNext()
    {
        LoadLevel(SceneManager.GetActiveScene().buildIndex + 1);
    }
    IEnumerable LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
    }
}
