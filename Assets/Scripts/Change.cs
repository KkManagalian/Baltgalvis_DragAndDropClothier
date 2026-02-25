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

            SAllIcons[0].SetActive(true);
            //PAllIcons[0].SetActive(false);

            if (Toggles[0].GetComponent<Toggle>().interactable == true)
            {
                wardrobe.GetComponent<Image>().sprite = wardrobeSprite[0];
                SAllIcons[1].SetActive(true);
                for(int i = 2; i < SAllIcons.Length; i++)
                {
                    SAllIcons[1].SetActive(false);
                }
            }else if (Toggles[1].GetComponent<Toggle>().interactable == true)
            {
                wardrobe.GetComponent<Image>().sprite = wardrobeSprite[1];
                SAllIcons[2].SetActive(true);
                SAllIcons[1].SetActive(false);
                SAllIcons[3].SetActive(false);
                SAllIcons[4].SetActive(false);

            }else if(Toggles[2].GetComponent<Toggle>().interactable == true)
            {
                wardrobe.GetComponent<Image>().sprite = wardrobeSprite[2];
                SAllIcons[3].SetActive(true);
                SAllIcons[1].SetActive(false);
                SAllIcons[2].SetActive(false);
                SAllIcons[4].SetActive(false);
            }else if (Toggles[3].GetComponent<Toggle>().interactable == true)
            {
                wardrobe.GetComponent<Image>().sprite = wardrobeSprite[3];
                SAllIcons[4].SetActive(true);
                for (int i = 1; i < SAllIcons.Length - 1; i++)
                {
                    SAllIcons[i].SetActive(false);
                }
            }


        }
        else if (index == 1)
        {
            SansInfo.SetActive(false);
            PapyrusInfo.SetActive(true);
            characterImg.GetComponent<Image>().sprite = characterSprite[index];

            SAllIcons[0].SetActive(false);
            PAllIcons[0].SetActive(true);

        }

    }
}