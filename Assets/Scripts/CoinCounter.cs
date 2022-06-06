using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    [SerializeField] Text CoinNumber;
    public int _coinCount = 0;

    public void Update()
    {
        CoinNumber.text = _coinCount.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        _coinCount++;
        Destroy(gameObject);
    }
}
