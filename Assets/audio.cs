using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour
{
    [SerializeField] AudioSource leaves;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Texture"))
        {
            leaves.Play();
        }
    }
}
