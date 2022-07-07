using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float deathLoadTime = 0.2f;
    [SerializeField] ParticleSystem crassEffect;

    void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Ground") {
            crassEffect.Play();
            Invoke("ReloadScene", deathLoadTime);
        }
    }

    void ReloadScene() {
        SceneManager.LoadScene(0);
    }
}
