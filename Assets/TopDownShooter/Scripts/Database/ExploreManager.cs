using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExploreManager : MonoBehaviour
{
    public GameObject player;
    public Transform spawnPos;
    public Transform[] wanderPositions;

    [Header("Bandit")]
    public int totalBandit;
    public GameObject[] bandit;
    public Transform[] banditPos;

    [Header("Enemies")]
    public int totalZombies;
    public GameObject[] zombies;
    public Transform[] zombieSpawnPositions;
    [Space]
    public int currentEnemies;
    public GameObject[] enemyList;

    [Header("Civilians")]
    public int totalCivivls;
    public GameObject[] civilians;
    public Transform[] civilPositions;

    [Header("Survival")]
    public Transform[] srv_spawnPositions;

    [Header("Vehicles")]
    public GameObject[] Vehicles;
    public int vehicleIndex;
    public Transform vehSpawnPos;

    PlayfabManager database;


    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(player, spawnPos.position, spawnPos.rotation);

        database = GameObject.FindGameObjectWithTag("Database").GetComponent<PlayfabManager>();

        StartCoroutine(LoadData());

        
    }

    IEnumerator LoadData()
    {
        yield return new WaitForSeconds(0.5f);

        GetData();
    }

    // Update is called once per frame
    void Update()
    {
        enemyList = GameObject.FindGameObjectsWithTag("Enemy");

        currentEnemies = enemyList.Length;

        if (currentEnemies < totalZombies)
        {
            Spawn();
        }

    }

    void GetData()
    {
        for (int i = 0; i < totalZombies; i++)
        {
            Spawn();
        }

        for (int i = 0; i < totalCivivls; i++)
        {
            CivilSpawn();
        }

        for (int i = 0; i < totalBandit; i++)
        {
            BanditSpawn();
        }

        vehicleIndex = database.carVehicleIndex;
        if (vehicleIndex > 0)
        {
            Instantiate(Vehicles[vehicleIndex], vehSpawnPos.position, vehSpawnPos.rotation);
        }

    }

    void Spawn()
    {
        Transform tSpawn = zombieSpawnPositions[Random.Range(0, zombieSpawnPositions.Length)];
        Instantiate(zombies[Random.Range(0, zombies.Length)], tSpawn.position, tSpawn.rotation);
    }

    void CivilSpawn()
    {
        Transform tSpawn = civilPositions[Random.Range(0, civilPositions.Length)];
        Instantiate(civilians[Random.Range(0, civilians.Length)], tSpawn.position, tSpawn.rotation);
    }

    void BanditSpawn()
    {
        Transform tSpawn = banditPos[Random.Range(0, banditPos.Length)];
        Instantiate(bandit[Random.Range(0, bandit.Length)], tSpawn.position, tSpawn.rotation);
    }
}
