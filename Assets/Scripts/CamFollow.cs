using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    [SerializeField] Transform _followTarget;
    float _lerpRate = 5;
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, _followTarget.position, Time.deltaTime * _lerpRate);
    }
}
