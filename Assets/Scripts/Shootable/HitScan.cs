using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitScan : AbstractShootable
{
    public float range;
    // Start is called before the first frame update
    public override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Shoot(Vector3 direction,string tag)
    {
        ammo--;
        if (ammo <= 0)
        {
            Reload();
            return;
        }
        RaycastHit hit;

        Physics.Raycast(bulletOrgin.position, direction, out hit, range);

        if (hit.transform.gameObject.GetComponent<IDamagable>() != null)
        {
            hit.transform.gameObject.GetComponent<IDamagable>().Damage(damage);
        }
    }

    public override void Reload()
    {
        base.Reload();
    }
}
