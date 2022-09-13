using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootController : MonoBehaviour
{
    [SerializeField] private BulletController prefab;
    public void Shoot(Vector3 direction,Transform transform)
    {
        //GameManager.instance.bullet

        foreach (var item in GameManager.instance.bullets)
        {
            if (!item.gameObject.activeInHierarchy)
            {
                item.transform.position = transform.position + Vector3.up;
                item.gameObject.SetActive(true);
                item.Fire(direction);
                break;
            }
        }
        
    }
}
