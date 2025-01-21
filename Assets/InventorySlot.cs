using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InventorySlot : MonoBehaviour, IDropHandler
{
    public List<ItemType> acceptedItemTypes = new List<ItemType>();
    public void OnDrop(PointerEventData eventData)
    {
        GameObject dropped = eventData.pointerDrag;
        if (dropped != null)
        {
            DraggableItem draggableItem = dropped.GetComponent<DraggableItem>();

            if (acceptedItemTypes.Count == 0 || acceptedItemTypes.Contains(draggableItem.itemType))
            {
                draggableItem.parentAfterDrag = transform;
            }
            else
            {
                Debug.Log("ten przedmiot nie pasuje do tego slotu");
            }
        }
    }

}
