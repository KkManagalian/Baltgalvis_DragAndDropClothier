using UnityEngine;
using UnityEngine.UI;

public class Change : MonoBehaviour
{
    public GameObject characterImg;
    public GameObject wardrobe;

    public GameObject SansInfo;
    public GameObject PapyrusInfo;

    public GameObject[] Toggles; //0 - Shoes, 1 - Shorts, 2 - Shirt, 3 - Jacket

    public GameObject[] SAllIcons; //0 - Whole Sans clothes, 1-4 - seperate Clothing

    public GameObject[] PAllIcons; //0 - Whole Papyrus clothes, 1-4 - seperate Clothing

    public Sprite[] characterSprite;
    public Sprite[] wardrobeSprite;

    public void ChangeCharacterImage(int index)
    {
        if (index == 0)
        {
            SansInfo.SetActive(true);
            PapyrusInfo.SetActive(false);
            characterImg.GetComponent<Image>().sprite = characterSprite[index];

           // SAllIcons[0].SetActive(true);
            //PAllIcons[0].SetActive(false); Nepabeigta dala (Drebes otram characteram)

            


        }
        else if (index == 1)
        {
            SansInfo.SetActive(false);
            PapyrusInfo.SetActive(true);
            characterImg.GetComponent<Image>().sprite = characterSprite[index];

            //SAllIcons[0].SetActive(false);
            //PAllIcons[0].SetActive(true); Nepabeigta dala (Drebes otram characteram)

        }

    }
}