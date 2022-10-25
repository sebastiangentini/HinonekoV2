using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneNivelPrincipal : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
    SceneManager.LoadScene(2);
    }
}

