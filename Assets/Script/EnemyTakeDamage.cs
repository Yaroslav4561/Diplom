using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DamageScript : MonoBehaviour
{
    public int damageAmount = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            other.GetComponent<EnemyScript>().Damage(damageAmount);
            Debug.LogError(other.gameObject.name);
        }
    }
}
