using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneIntro : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitForChangeScene());
    }

    IEnumerator WaitForChangeScene()
    {
        yield return new WaitForSeconds(70);
        ChangeScene();
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(1);
    }
}
