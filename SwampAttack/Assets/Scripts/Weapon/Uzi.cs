using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uzi : Weapon
{
    public override void Shoot(Transform shootPoint)
    {
        Vector3 newBulletPosition = new Vector3(0.1f, 0f, 0f);

        Instantiate(Bullet, shootPoint.position + newBulletPosition, Quaternion.identity);
        Instantiate(Bullet, shootPoint.position , Quaternion.identity);
    }
}
