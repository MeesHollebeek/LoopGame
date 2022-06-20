using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    PlatfromSpawner platfromSpawner;

    // Start is called before the first frame update
    void Start()
    {
        platfromSpawner = GetComponent<PlatfromSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnTriggerEnterd()
    {
        platfromSpawner.MovePlatforms();
    }
}
