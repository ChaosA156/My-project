using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{
    public HealthManager manager;
    public ShieldManager shieldManager;
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            manager.TakeDamage(0.1f);
        }
    }
}
