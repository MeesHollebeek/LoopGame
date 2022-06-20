using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlatfromSpawner : MonoBehaviour
{
    public List<GameObject> platfroms;
    private float offset = 30f;
    // Start is called before the first frame update
    void Start()
    {
        if(platfroms != null && platfroms.Count > 0)
        {
            platfroms = platfroms.OrderBy(r => r.transform.position.z).ToList();
        }
    }

    public void MovePlatforms()
    {
        GameObject movePlatfroms = platfroms[0];
        platfroms.Remove(movePlatfroms);
        float newZ = platfroms[platfroms.Count - 1].transform.position.z + offset;
        movePlatfroms.transform.position = new Vector3(0, 0, newZ);
        platfroms.Add(movePlatfroms);
    }
}
