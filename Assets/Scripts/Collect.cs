using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collect : MonoBehaviour
{
    int coins = 0;

    [SerializeField] Text coinsText;
    [SerializeField] AudioSource coinSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            coinSound.Play();
            Destroy(other.gameObject);
            coins++;
            coinsText.text = "Coins:" + coins; 

            coinSound.Play();


        }

    }
}
