using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float deathLoadTime = 0.2f;
    [SerializeField] ParticleSystem crashEffect;

    void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Ground") {
            crashEffect.Play();
            Invoke("ReloadScene", deathLoadTime);
        }
    }

    void ReloadScene() {
        SceneManager.LoadScene(0);
    }
}
