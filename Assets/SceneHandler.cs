using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
    public Animator transition;

    public float transitionTime = 1f;

    public void SceneTrigger()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            StartCoroutine(LoadLevel(1));
        }
        else
        {
            StartCoroutine(LoadLevel(0));
        }
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);

    }
}
