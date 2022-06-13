using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float deathLoadTime = 0.5f;

    void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Ground") {
            Invoke("ReloadScene", deathLoadTime);
        }
    }

    void ReloadScene() {
        SceneManager.LoadScene(0);
    }
}
