using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item_BTN : MonoBehaviour
{
    public Item item;
    public GameObject FunctionsOBJ;

    public bool functionOpen;
    public bool isWeapon;
    
    Player player;
    WeaponManger weapon;
    bool switched;
    ItemAssets itemAssets;
    UI_Inventory uI_Inventory;
    SurvivalShop sShop;

    void Start()
    {
    	player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        itemAssets = player.GetComponent<ItemAssets>();
        weapon = player.GetComponent<WeaponManger>();

        uI_Inventory = player.ui_Inventory;
        sShop = uI_Inventory.survivalShop;

    	functionOpen = false;
        FunctionsOBJ.SetActive(false);
    }


    public void SetItem(Item item)
    {
    	this.item = item;
    }

    public void ClickFunction()
    {
        switch (item.itemType)
        {
            case Item.ItemType.wall:
                weapon.SelectItem(0);
                break;
            case Item.ItemType.metalWall:
                weapon.SelectItem(1);
                break;
            case Item.ItemType.woodDoor:
                weapon.SelectItem(2);
                break;
            case Item.ItemType.metalDoor:
                weapon.SelectItem(3);
                break;
            case Item.ItemType.grenade:
                weapon.SelectItem(4);
                break;
            case Item.ItemType.smoke:
                weapon.SelectItem(5);
                break;
            case Item.ItemType.molotov:
                weapon.SelectItem(6);
                break;
            case Item.ItemType.medkit:
                if(player.currentHealth < player.maxHealth && !player.healing)
                {
                    StartCoroutine(player.heal(50f));
                }
                break;
            case Item.ItemType.glock17:
                weapon.SecondryWeaponIndex = 12;
                weapon.SwitchTwo();
                weapon.SelectGun(12);
                sShop.EnableWeapon(0);
                break;
            case Item.ItemType.kriss:
                weapon.PrimaryWeaponIndex = 1;
                weapon.SwitchOne();
                weapon.SelectGun(1);
                sShop.EnableWeapon(1);
                break;
            case Item.ItemType.mp7:
                weapon.PrimaryWeaponIndex = 2;
                weapon.SwitchOne();
                weapon.SelectGun(2);
                sShop.EnableWeapon(2);
                break;
            case Item.ItemType.mp5:
                weapon.PrimaryWeaponIndex = 3;
                weapon.SwitchOne();
                weapon.SelectGun(3);
                sShop.EnableWeapon(3);
                break;
            case Item.ItemType.tec9:
                weapon.PrimaryWeaponIndex = 4;
                weapon.SwitchOne();
                weapon.SelectGun(4);
                sShop.EnableWeapon(4);
                break;
            case Item.ItemType.ump45:
                weapon.PrimaryWeaponIndex = 5;
                weapon.SwitchOne();
                weapon.SelectGun(5);
                sShop.EnableWeapon(5);
                break;
            case Item.ItemType.uzi:
                weapon.PrimaryWeaponIndex = 6;
                weapon.SwitchOne();
                weapon.SelectGun(6);
                sShop.EnableWeapon(6);
                break;
            case Item.ItemType.ak12:
                weapon.PrimaryWeaponIndex = 7;
                weapon.SwitchOne();
                weapon.SelectGun(7);
                sShop.EnableWeapon(7);
                break;
            case Item.ItemType.ak74:
                weapon.PrimaryWeaponIndex = 8;
                weapon.SwitchOne();
                weapon.SelectGun(8);
                sShop.EnableWeapon(8);
                break;
            case Item.ItemType.g3a4:
                weapon.PrimaryWeaponIndex = 9;
                weapon.SwitchOne();
                weapon.SelectGun(9);
                sShop.EnableWeapon(9);
                break;
            case Item.ItemType.g36c:
                weapon.PrimaryWeaponIndex = 10;
                weapon.SwitchOne();
                weapon.SelectGun(10);
                sShop.EnableWeapon(10);
                break;
        }
    }

    public void ItemClick()
    {
        if(!functionOpen)
        {
            FunctionsOBJ.SetActive(true);
            functionOpen = true;
        }else
        {
            FunctionsOBJ.SetActive(false);
            functionOpen = false;
        }
    }

    public void Drop()
    {
        // if(isWeapon && player.weaponAmount <= 1)return;

    	Item duplicateItem = new Item {itemType = item.itemType, amount = item.amount};
        player.inventory.RemoveItem(item);
        ItemWorld.DropItem(player.dropPosition, duplicateItem);
    }

}
