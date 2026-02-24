using UnityEngine;
using UnityEngine.UI;

public class DraggableItem : MonoBehaviour
{
    public ClothingType itemType;

    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;

    public static DraggableItem currentDraggedItem;

    private bool isDragging = false;
    private bool isPlaced = false;

    void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = gameObject.AddComponent<CanvasGroup>();
    }

    void Update()
    {
        if (isDragging)
        {
            rectTransform.position = Input.mousePosition;

            if (Input.GetMouseButtonUp(0))
            {
                PlaceItem();
            }
        }
    }

    public void StartDragging()
    {
        if (isPlaced) return;

        currentDraggedItem = this;
        isDragging = true;
        canvasGroup.blocksRaycasts = false;
        rectTransform.position = Input.mousePosition;
    }

    void PlaceItem()
    {
        isDragging = false;
        isPlaced = true; // 🔒 permanently placed
        canvasGroup.blocksRaycasts = true;
        currentDraggedItem = null;
    }
}