using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] ParticleSystem finishEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            finishEffect.Play();
            Invoke("ReloadScene", 1.0f);
            GetComponent<AudioSource>().Play();
        }
    }

    void ReloadScene() { SceneManager.LoadScene(0); }
}
