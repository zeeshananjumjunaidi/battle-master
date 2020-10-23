using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildBuilding : MonoBehaviour
{
    public GameObject BuildingBlueprint;
    public void SpawnBuilding()
    {
        Instantiate(BuildingBlueprint);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
