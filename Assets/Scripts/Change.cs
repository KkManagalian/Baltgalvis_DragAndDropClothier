using UnityEngine;
using UnityEngine.UI;

public class Change : MonoBehaviour
{
    public GameObject characterImg;
    public GameObject wardrobe;
    public GameObject charInfo1;
    public GameObject charInfo2;
    public Sprite[] characterSprite;
    public Sprite[] wardrobeSprite;

    private bool Sans = true;
    public void ChangeCharacterImage(int index)
    {
        if (Sans == true)
        {
            Sans = false;
            charInfo1.SetActive(true);
            charInfo2.SetActive(false);
            characterImg.GetComponent<Image>().sprite = characterSprite[index];
            wardrobe.GetComponent<Image>().sprite = wardrobeSprite[index];
        }
        else
            Sans = true;
            charInfo1.SetActive(false);
            charInfo2.SetActive(true);
            characterImg.GetComponent<Image>().sprite = characterSprite[index];
            wardrobe.GetComponent<Image>().sprite = wardrobeSprite[index];
    }
}
