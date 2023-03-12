using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class ContainerCounter : BaseCounter
{

    public event EventHandler OnplayerGrabbedObject;

    [SerializeField] private KitchenObjectSO kitchenObjectSO;


    public override void Interact(Player player)
    {
        if (!player.HasKitchenObject())
        {
            // plater is not carrying anything
            KitchenObject.SpawnKitchenObject(kitchenObjectSO, player);
        }

        OnplayerGrabbedObject?.Invoke(this, EventArgs.Empty);
    }
}
