using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candle : MonoBehaviour
{
    [SerializeField]
    private GameObject flame;

    [SerializeField]
    private ToggleParticle toggleParticle;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Flame"))
        {
            toggleParticle.Play();
        }
    }
}
