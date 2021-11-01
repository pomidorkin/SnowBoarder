using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrushDetector : MonoBehaviour
{
    [SerializeField] ParticleSystem crushEffect;
    [SerializeField] AudioClip crushSFX;

    bool hasCrashed;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground" && !hasCrashed)
        {
            hasCrashed = true;
            FindObjectOfType<PlayerController>().DisableControls();
            crushEffect.Play();
            // This approach lets us playing different sound effects
            GetComponent<AudioSource>().PlayOneShot(crushSFX);
            Invoke("RelodScene", 0.5f);

        }
    }

    void RelodScene() { SceneManager.LoadScene(0); }
}
