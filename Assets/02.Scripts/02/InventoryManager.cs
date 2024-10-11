using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{

    private Inventory<IItem> playerInventory;
    // Start is called before the first frame update
    void Start()
    {
        playerInventory = new Inventory<IItem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)) playerInventory.AddItem(new Weapon("Sword", 1, 10));
        if (Input.GetKeyDown(KeyCode.W)) playerInventory.AddItem(new Weapon("Potion", 1, 10));
        if (Input.GetKeyDown(KeyCode.Space)) playerInventory.Listitems();
        if (Input.GetKeyDown(KeyCode.Alpha1)) playerInventory.UseItem(0);
        if (Input.GetKeyDown(KeyCode.Alpha2)) playerInventory.UseItem(1);
    }
}
