using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrushDetector : MonoBehaviour
{
    [SerializeField] ParticleSystem crushEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            crushEffect.Play();
            Invoke("RelodScene", 0.5f);

        }
    }

    void RelodScene() { SceneManager.LoadScene(0); }
}
