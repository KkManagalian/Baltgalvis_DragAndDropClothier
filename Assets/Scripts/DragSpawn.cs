using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSpawner : MonoBehaviour, IPointerClickHandler
{
    public GameObject itemPrefab;
    public Transform dragLayer;
    public ClothingType itemType;

    private static System.Collections.Generic.Dictionary<ClothingType, DraggableItem> spawnedItems
        = new System.Collections.Generic.Dictionary<ClothingType, DraggableItem>();

    public void OnPointerClick(PointerEventData eventData)
    {
        // Prevent spawning while dragging something
        if (DraggableItem.currentDraggedItem != null)
            return;

        // If this item type already exists → destroy it (REPLACE behavior)
        if (spawnedItems.ContainsKey(itemType))
        {
            if (spawnedItems[itemType] != null)
                Destroy(spawnedItems[itemType].gameObject);

            spawnedItems.Remove(itemType);
        }

        // Spawn new item
        GameObject newItem = Instantiate(itemPrefab, dragLayer);

        DraggableItem draggable = newItem.GetComponent<DraggableItem>();
        draggable.itemType = itemType;

        spawnedItems[itemType] = draggable;

        draggable.StartDragging(); // Immediately drag
    }
}
