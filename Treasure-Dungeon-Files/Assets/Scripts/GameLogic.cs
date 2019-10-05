﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{

    public GameObject[] spawnPoints;

    public void SpawnOgre(GameObject Ogre){
        GameObject spawnPoint = GetRandomSpawnPoint();
        Ogre.transform.position = spawnPoint.transform.position;
        //GameObject.Find("Score").GetComponent<Score>().score;
        Score.score += 100;
    }

    GameObject GetRandomSpawnPoint(){
        return spawnPoints[Random.Range(0, spawnPoints.Length)];
    }

}
