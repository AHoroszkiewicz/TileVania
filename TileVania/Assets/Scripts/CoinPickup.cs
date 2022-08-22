using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    [SerializeField] AudioClip pickupSound;
    [SerializeField] int pointValue = 100;

    bool wasCollected = false;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && !wasCollected)
        {
            wasCollected = true;
            FindObjectOfType<GameSession>().AddToScore(pointValue);
            AudioSource.PlayClipAtPoint(pickupSound, Camera.main.transform.position);
            Destroy(gameObject);
        }
    }

}
