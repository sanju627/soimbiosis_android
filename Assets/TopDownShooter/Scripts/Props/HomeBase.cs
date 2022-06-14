using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeBase : MonoBehaviour
{
    public Transform[] campFirePos;
    public GameObject civils;

    [Header("Vehicles")]
    public GameObject CurrentVeh;
    public GameObject[] Vehicles;
    public int vehicleIndex;
    public Transform vehSpawnPos;

    [Header("Survivals")]
    public Transform[] srv_spawnPositions;

    PlayfabManager database;

    // Start is called before the first frame update
    void Start()
    {
        database = GameObject.FindGameObjectWithTag("Database").GetComponent<PlayfabManager>();

        SpawnVeh();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnVeh()
    {
        vehicleIndex = database.carVehicleIndex;
        if (vehicleIndex > 0)
        {
            CurrentVeh = Instantiate(Vehicles[vehicleIndex], vehSpawnPos.position, vehSpawnPos.rotation);
        }
    }

    public void DesVeh()
    {
        Destroy(CurrentVeh);
    }
}
