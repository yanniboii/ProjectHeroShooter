using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class AbstractShootable : MonoBehaviour
{

    public float damage = 5;
    public float shootSpeed = 20;

    [Header("Reload")]
    public float reloadSpeed = 3;
    public bool reloading = false;
    public int magSize = 20;
    public int ammo;

    [Header("BulletSpawn")]
    public Transform bulletOrgin;

    public virtual void Start()
    {
        ammo = magSize;
    }
    
    public virtual void Reload()
    {
        reloading = true;
        float tempcd = reloadSpeed;
        while (reloading)
        {
            tempcd -= Time.deltaTime;

            if (tempcd <= 0f)
            {
                reloading = false;
            }
        }
    }

    public abstract void Shoot(Vector3 direction, string tag);
}
