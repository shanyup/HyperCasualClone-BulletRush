using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [Header("Object Pool")] public List<BulletController> bullets;

    public List<GameObject> enemiesInArea = new List<GameObject>();
    private void Start()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }
}
