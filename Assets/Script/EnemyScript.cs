using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private int HP = 1;
    public Animator animator;

    public void Damage(int damageAmount)
    {
        HP -= damageAmount;
        Debug.Log("Damage taken: " + damageAmount + ", HP left: " + HP);

        if (HP <= 0)
        {
            Debug.Log("Triggering Death animation");
            animator.SetTrigger("Death");
        }
    }
}
