using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public ParticleSystem _coinEffect;
    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<CoinCounter>()._coinCount++;
        _coinEffect.Play();
        Destroy(gameObject);
        
    }
}
