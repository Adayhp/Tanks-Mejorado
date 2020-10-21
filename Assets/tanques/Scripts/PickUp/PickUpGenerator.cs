using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class PickUpGenerator : MonoBehaviour
{
    public Transform[] spawnPoints;
    public float spawnTime = 5.0f;
    //public GameObject Packs;
    public GameObject[] Packs;

    void Start()
    {
        InvokeRepeating("SpawnPacks", spawnTime, spawnTime);
    }

    void SpawnPacks()
    {
        int spawnIndex = UnityEngine.Random.Range(0, spawnPoints.Length);//set the index number of the array
        int objectIndex = UnityEngine.Random.Range(0, Packs.Length);
        Instantiate(Packs[objectIndex], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
    }


}
