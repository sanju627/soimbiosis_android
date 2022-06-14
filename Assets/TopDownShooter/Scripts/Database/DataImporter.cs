
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DataImporter : MonoBehaviour
{
    //public AuthManager authManager;
    public int woodAmount;
    public bool dataLoaded;
    [Space]
    public GameObject civils;

    [Header("Vehicles")]
    public GameObject[] Vehicles;
    public int vehicleIndex;

    [Header("Survival")]
    public GameObject survival;

    HomeBase homeBase;
    ExploreManager expManager;
    PlayfabManager database;
    Player player;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Player>();

        database = GameObject.FindGameObjectWithTag("Database").GetComponent<PlayfabManager>();
        //authManager.LoadData();
        StartCoroutine(LoadData());

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Game"))
        {
            homeBase = GameObject.FindGameObjectWithTag("HomeBase").GetComponent<HomeBase>();
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Junkyard"))
        {
            expManager = GameObject.FindGameObjectWithTag("Manager").GetComponent<ExploreManager>();
        }
    }

    IEnumerator LoadData()
    {
        yield return new WaitForSeconds(0.1f);

        GetData();
    }

    // Update is called once per frame
    void GetData()
    {
        if(database.ammoAmount > 0)
        {
            player.inventory.AddItem(new Item { itemType = Item.ItemType.ammo, amount = database.ammoAmount });
        }

        if (database.medkitAmount > 0)
        {
            player.inventory.AddItem(new Item { itemType = Item.ItemType.medkit, amount = database.medkitAmount });
        }

        if (database.bandageAmount > 0)
        {
            player.inventory.AddItem(new Item { itemType = Item.ItemType.bandage, amount = database.bandageAmount });
        }

        if (database.grenadeAmount > 0)
        {
            player.inventory.AddItem(new Item { itemType = Item.ItemType.grenade, amount = database.grenadeAmount });
        }

        if (database.molotovAmount > 0)
        {
            player.inventory.AddItem(new Item { itemType = Item.ItemType.molotov, amount = database.molotovAmount });
        }

        if (database.smokeAmount > 0)
        {
            player.inventory.AddItem(new Item { itemType = Item.ItemType.smoke, amount = database.smokeAmount });
        }

        if (database.landmineAmount > 0)
        {
            player.inventory.AddItem(new Item { itemType = Item.ItemType.landmine, amount = database.landmineAmount });
        }

        if (database.chickenAmount > 0)
        {
            player.inventory.AddItem(new Item { itemType = Item.ItemType.chicken, amount = database.chickenAmount });
        }

        if (database.woodAmount > 0)
        {
            woodAmount = database.woodAmount;
            player.inventory.AddItem(new Item { itemType = Item.ItemType.wood, amount = database.woodAmount });
        }

        if (database.stoneAmount > 0)
        {
            player.inventory.AddItem(new Item { itemType = Item.ItemType.stone, amount = database.stoneAmount });
        }

        if (database.woodWallAmount > 0)
        {
            player.inventory.AddItem(new Item { itemType = Item.ItemType.wall, amount = database.woodWallAmount });
        }

        if (database.metalWallAmount > 0)
        {
            player.inventory.AddItem(new Item { itemType = Item.ItemType.metalWall, amount = database.metalWallAmount });
        }

        if (database.woodDoorAmount > 0)
        {
            player.inventory.AddItem(new Item { itemType = Item.ItemType.woodDoor, amount = database.woodDoorAmount });
        }

        if (database.metalDoorAmount > 0)
        {
            player.inventory.AddItem(new Item { itemType = Item.ItemType.metalDoor, amount = database.metalDoorAmount });
        }

        //-------------------------------------------Weapons------------------------------------//

        if (database.krissAmount > 0)
        {
            player.inventory.AddItem(new Item { itemType = Item.ItemType.kriss, amount = database.krissAmount });
        }

        if (database.MP7Amount > 0)
        {
            player.inventory.AddItem(new Item { itemType = Item.ItemType.mp7, amount = database.MP7Amount });
        }

        if (database.MP5Amount > 0)
        {
            player.inventory.AddItem(new Item { itemType = Item.ItemType.mp5, amount = database.MP5Amount });
        }

        if (database.UMPAmount > 0)
        {
            player.inventory.AddItem(new Item { itemType = Item.ItemType.ump45, amount = database.UMPAmount });
        }

        if (database.Tec9Amount > 0)
        {
            player.inventory.AddItem(new Item { itemType = Item.ItemType.tec9, amount = database.Tec9Amount });
        }

        if (database.UZIAmount > 0)
        {
            player.inventory.AddItem(new Item { itemType = Item.ItemType.uzi, amount = database.UZIAmount });
        }

        if (database.ak12Amount > 0)
        {
            player.inventory.AddItem(new Item { itemType = Item.ItemType.ak12, amount = database.ak12Amount });
        }

        if (database.ak74Amount > 0)
        {
            player.inventory.AddItem(new Item { itemType = Item.ItemType.ak74, amount = database.ak74Amount });
        }

        if (database.G3A4Amount > 0)
        {
            player.inventory.AddItem(new Item { itemType = Item.ItemType.g3a4, amount = database.G3A4Amount });
        }

        if (database.G36CAmount > 0)
        {
            player.inventory.AddItem(new Item { itemType = Item.ItemType.g36c, amount = database.G36CAmount });
        }

        if (database.flamethrowerAmount > 0)
        {
            player.inventory.AddItem(new Item { itemType = Item.ItemType.flamethrower, amount = database.flamethrowerAmount });
        }

        if (database.Glock17Amount > 0)
        {
            player.inventory.AddItem(new Item { itemType = Item.ItemType.glock17, amount = database.Glock17Amount });
        }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Game"))
        {
            for (int i = 0; i < database.civilAmount; i++)
            {
                Transform tSpawn = homeBase.campFirePos[Random.Range(0, homeBase.campFirePos.Length)];

                Instantiate(civils, tSpawn.position, tSpawn.rotation);
            }

            for (int i = 0; i < database.srvAmount; i++)
            {
                Transform tSpawn = homeBase.srv_spawnPositions[Random.Range(0, homeBase.srv_spawnPositions.Length)];

                Instantiate(survival, tSpawn.position, tSpawn.rotation);
            }
        }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Junkyard"))
        {
            for(int i = 0; i < database.srvAmount; i++)
            {
                Transform tSpawn = expManager.srv_spawnPositions[Random.Range(0, expManager.srv_spawnPositions.Length)];

                Instantiate(survival, tSpawn.position, tSpawn.rotation);
            }
        }

        dataLoaded = true;
    }
}
