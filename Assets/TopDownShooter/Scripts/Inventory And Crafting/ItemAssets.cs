using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ItemAssets : MonoBehaviour
{
	public static ItemAssets Instance {get; private set;}

	// ammo,
	// medkit,
	// bandage,
	// grenade,
	// molotov,
	// smoke,
	// landmine,

	void Awake()
	{
		Instance = this;
        //database = GameObject.FindGameObjectWithTag("Database").GetComponent<AuthManager>();
        //database.LoadData();
    }

	public Transform itemWorldPrefab;
	[Space]

    public Sprite ammoSprite; 
    public Sprite medkitSprite;
    public Sprite bandageSprite;
    public Sprite grenadeSprite;
    public Sprite molotovSprite;
    public Sprite smokeSprite;
    public Sprite landmineSprite;
    public Sprite chickenSprite;
    public Sprite woodSprite;
    public Sprite stoneSprite;
    [Space]
    //----------------------------------------------------------Weapon---------------------------------------------//
    public Sprite krissSprite;
    public Sprite mp7Sprite;
    public Sprite mp5Sprite;
    public Sprite tec9Sprite;
    public Sprite umpSprite;
    public Sprite uziSprite;
    public Sprite ak12Sprite;
    public Sprite ak74Sprite;
    public Sprite g3a4Sprite;
    public Sprite g36cSprite;
    public Sprite flamethrowerSprite;
    public Sprite glock17Sprite;
	public Sprite wallSprite;
    public Sprite metalSprite;
    public Sprite woodDoorSprite;
    public Sprite metalDoorSprite;

	[Header("Amounts")]
	public int ammoAmount;
    public int medkitAmount;
    public int bandageAmount;
    [Space]
    public int grenadeAmount;
    public int molotovAmount;
    public int smokeAmount;
    public int landmineAmount;
    public int chickenAmount;
    [Space]
    public int woodAmount;
    public int stoneAmount;
    public int wallAmount;
    public int metalWallAmount;
    public int woodDoorAmount;
    public int metalDoorAmount;
    [Space]
    public int krissAmount;
    public int mp7Amount;
    public int mp5Amount;
    public int ump45Amount;
    public int tec9Amount;
    public int uziAmount;
    public int ak12Amount;
    public int ak74Amount;
    public int g3a4Amount;
    public int g36cAmount;
    public int flamethrowerAmount;
    public int glock17Amount;
    [Space]
    public int civils;
    public int survivals;
    public int vehiclesIndex;

    Inventory inventory;
    PlayfabManager database;
    DataImporter data;
    Player player;

    void Start()
    {
        //civils = database.civils;
        //vehiclesIndex = database.vehiclesIndex;
        database = GameObject.FindGameObjectWithTag("Database").GetComponent<PlayfabManager>();
        data = GetComponent<DataImporter>();
        //database.GetData();
    }

    void Update()
    {
        inventory = GetComponent<Player>().inventory;
        player = GetComponent<Player>();
        
        if(data.dataLoaded)
        CheckItem();
    }

	void CheckItem()
    {
        ammoAmount = inventory.ammoAmount;
        medkitAmount = inventory.medkitAmount;
        bandageAmount = inventory.bandageAmount;
        grenadeAmount = inventory.grenadeAmount;
        molotovAmount = inventory.molotovAmount;
        smokeAmount = inventory.smokeAmount;
        landmineAmount = inventory.landmineAmount;
        chickenAmount = inventory.chickenAmount;
        woodAmount = inventory.woodAmount;
        stoneAmount = inventory.stoneAmount;
        wallAmount = inventory.wallAmount;
        metalWallAmount = inventory.metalWallAmount;
        woodDoorAmount = inventory.woodDoorAmount;
        metalDoorAmount = inventory.metalDoorAmount;
        krissAmount = inventory.krissAmount;
        mp7Amount = inventory.mp7Amount;
        mp5Amount = inventory.mp5Amount;
        ump45Amount = inventory.ump45Amount;
        tec9Amount = inventory.tec9Amount;
        uziAmount = inventory.uziAmount;
        ak12Amount = inventory.ak12Amount;
        ak74Amount = inventory.ak74Amount;
        g3a4Amount = inventory.g3a4Amount;
        g36cAmount = inventory.g36cAmount;
        flamethrowerAmount = inventory.flamethrowerAmount;
        glock17Amount = inventory.glock17Amount;

        /*database.SendData("Item Ammo", ammoAmount.ToString());
        database.SendData("Item Bandage", bandageAmount.ToString());
        database.SendData("Item Medkit", bandageAmount.ToString());
        database.SendData("Item Chicken", chickenAmount.ToString());
        database.SendData("Item Landmine", landmineAmount.ToString());
        database.SendData("Item MetalWall", metalWallAmount.ToString());
        database.SendData("Item MetalDoor", metalDoorAmount.ToString());
        database.SendData("Item WoodDoor", woodDoorAmount.ToString());
        database.SendData("Item WoodWall", wallAmount.ToString());
        database.SendData("Item Molotov", molotovAmount.ToString());
        database.SendData("Item Stone", stoneAmount.ToString());
        database.SendData("Item Wood", woodAmount.ToString());


        database.SendData("Weapon AK12", ak12Amount.ToString());
        database.SendData("Weapon AK74", ak74Amount.ToString());
        database.SendData("Weapon Kriss", krissAmount.ToString());
        database.SendData("Weapon Flamethrower", flamethrowerAmount.ToString());
        database.SendData("Weapon G36C", g36cAmount.ToString());
        database.SendData("Weapon G3A4", g3a4Amount.ToString());
        database.SendData("Weapon Glock17", glock17Amount.ToString());
        database.SendData("Weapon MP5", mp5Amount.ToString());
        database.SendData("Weapon MP7", mp7Amount.ToString());
        database.SendData("Weapon Tec9", tec9Amount.ToString());
        database.SendData("Weapon UMP", ump45Amount.ToString());
        database.SendData("Weapon UZI", uziAmount.ToString());*/

        /*StartCoroutine(database.UpdateItem("Ammo Amount", ammoAmount));

        StartCoroutine(database.UpdateItem("Kriss Amount", krissAmount));
        StartCoroutine(database.UpdateItem("mp7 Amount", mp7Amount));
        StartCoroutine(database.UpdateItem("mp5 Amount", mp5Amount));
        StartCoroutine(database.UpdateItem("ump45 Amount", ump45Amount));
        StartCoroutine(database.UpdateItem("tec9 Amount", tec9Amount));
        StartCoroutine(database.UpdateItem("uzi Amount", uziAmount));
        StartCoroutine(database.UpdateItem("AK12 Amount", ak12Amount));
        StartCoroutine(database.UpdateItem("AK74 Amount", ak74Amount));
        StartCoroutine(database.UpdateItem("g3a4 Amount", g3a4Amount));
        StartCoroutine(database.UpdateItem("g36c Amount", g36cAmount));
        StartCoroutine(database.UpdateItem("flamethrower Amount", flamethrowerAmount));
        StartCoroutine(database.UpdateItem("glock17 Amount", glock17Amount));*/

        //StartCoroutine(database.UpdateItem("Car Black Hawk", 0));

        //StartCoroutine(database.UpdateItem("Car 1940", 0));
        //StartCoroutine(database.UpdateItem("Car Bubble", 0));
        //StartCoroutine(database.UpdateItem("Car Hotrod", 0));
        //StartCoroutine(database.UpdateItem("Car IceCream", 0));
        //StartCoroutine(database.UpdateItem("Car MiniVan", 0));
        //StartCoroutine(database.UpdateItem("Car MonsterTruck", 0));
        //StartCoroutine(database.UpdateItem("Car Muscle", 0));
        //StartCoroutine(database.UpdateItem("Car Pickup", 0));
        //StartCoroutine(database.UpdateItem("Car Poop", 0));
        //StartCoroutine(database.UpdateItem("Car Pork", 0));
        //StartCoroutine(database.UpdateItem("Car Prison", 0));
        //StartCoroutine(database.UpdateItem("Car Water", 0));
        //StartCoroutine(database.UpdateItem("Car Wiener", 0));

        //StartCoroutine(database.UpdateItem("Survivals", 0));

        //StartCoroutine(database.UpdateItem("Civils", civils));
        //StartCoroutine(database.UpdateItem("Vehicle Index", vehiclesIndex));
    }
}
