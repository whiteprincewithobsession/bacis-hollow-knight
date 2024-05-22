using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Victory : MonoBehaviour
{
    public Text victoryText;
    public float displayTime;
    public AudioSource audioVictory;
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if(EnemyCount() == 0) {
                AudioSource[] audio = FindObjectsOfType<AudioSource>();
                foreach (AudioSource audioSource in audio)
                {
                    audioSource.Stop();
                }
                StartCoroutine(EndGame());

            }
        }
            
    }
    IEnumerator EndGame()
    {

        victoryText.enabled = true;
        victoryText.text = "Congratulations. You've completed the game!\nI hope you've found my secret related to the Shield ability.\nStay tuned for more updates!\nLink: github.com/whiteprincewithobsession";
        audioVictory.Play();
        yield return new WaitForSeconds(displayTime);
        victoryText.enabled = false;
        SceneManager.LoadScene("Menu");
    }

    int EnemyCount()
    {
        GunnerController[] range = FindObjectsOfType<GunnerController>();
        PatrolController[] melee = FindObjectsOfType<PatrolController>();
        return range.Length + melee.Length;
    }
}
