using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public void Shoot(GameObject bullet, GameObject firePoint, GameObject player)
    {
        Instantiate(bullet, firePoint.transform.position, player.transform.rotation);
    }
}