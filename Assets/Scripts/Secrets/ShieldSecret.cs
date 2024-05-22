using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShieldSecret : MonoBehaviour
{
    public Text secretText;
    public float displayTime = 3f;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerController player = other.gameObject.GetComponent<PlayerController>();
            if(player != null)
            {
                player.ActivateShield();
                PlayerPrefs.SetInt("_shieldAchieved", player.shieldAchieved ? 1 : 0);
                StartCoroutine(ShowSecretMessage());
            }
        }
    }
    IEnumerator ShowSecretMessage()
    {
        secretText.enabled = true;
        secretText.text = "You've discovered a secret!\nA new ability is available: temporary invulnerability.\nTo activate, press Moue Button 2";
        yield return new WaitForSeconds(displayTime);
        secretText.enabled = false;
        Destroy(gameObject);
    }
}
