using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneIntermedio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitForChangeScene());
    }

    IEnumerator WaitForChangeScene()
    {
        yield return new WaitForSeconds(36);
        ChangeScene();
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(3);
    }
}
