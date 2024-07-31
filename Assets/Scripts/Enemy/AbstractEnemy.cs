using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractEnemy : MonoBehaviour, IDamagable
{

    #region Events

    public delegate void OnEnemyDeath(int currency);
    public static OnEnemyDeath onEnemyDeath;

    #endregion
    public float health = 200;

    public float damage = 10;

    public float abilityHaste = 1;

    public int currency = 50;

    public virtual void CheckHealth()
    {
        if(health <= 0)
        {
            Die();
        }
    }

    public virtual void Damage(float Damage)
    {
        health -= Damage;
    }

    public virtual void Die()
    {
        Destroy(gameObject);
        onEnemyDeath?.Invoke(currency);
    }

    public abstract void Attack();

}
