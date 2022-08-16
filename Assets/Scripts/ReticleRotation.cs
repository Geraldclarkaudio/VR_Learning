using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReticleRotation : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    void Update()
    {
        transform.Rotate(0, 1, 0 * _speed * Time.deltaTime);
    }
}
