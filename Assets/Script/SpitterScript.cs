using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpitterScript : MonoBehaviour
{
    public GameObject spikeBall;
    public float spawnTimer;

    private void Start()
    {
        //sätter igång funktionen "Spit" efter X antal sekunder. I detta fall spawnTimer
        InvokeRepeating("Spit", spawnTimer, spawnTimer);
    }


    void Spit()
    {
        //spawnar GameObjectet spikeBall med samma position och rotation som "host"
        Instantiate(spikeBall, transform.position, transform.rotation);
    }
}
