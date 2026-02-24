using UnityEngine;
using UnityEngine.UI;

public class Change : MonoBehaviour
{
    public GameObject characterImg;
    public GameObject wardrobe;
    public ScrollRect scrollRect;
    public Sprite[] characterSprite;
    public Sprite[] wardrobeSprite;

    private bool Sans = true;
    public void ChangeCharacterImage(int index)
    {
        if (Sans == true)
        {
            Sans = false;
            characterImg.GetComponent<Image>().sprite = characterSprite[index];
            wardrobe.GetComponent<Image>().sprite = wardrobeSprite[index];
        }
        else
            Sans = true;
            characterImg.GetComponent<Image>().sprite = characterSprite[index];
            wardrobe.GetComponent<Image>().sprite = wardrobeSprite[index];
    }
}
