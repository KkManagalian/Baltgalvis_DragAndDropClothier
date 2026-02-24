using UnityEngine;
using UnityEngine.UI;

public class Change : MonoBehaviour
{
    public GameObject characterImg;
    public GameObject wardrobe;
    public GameObject SansInfo;
    public GameObject PapyrusInfo;
    public Sprite[] characterSprite;
    public Sprite[] SansWardrobe;
    public Sprite[] PapyrusWardrobe;
    public GameObject[] SansClothes;
    public GameObject[] PapyrusClothes;

    public void ChangeCharacterImage(int index)
    {
        if (index == 0)
        {
            SansInfo.SetActive(true);
            PapyrusInfo.SetActive(false);
            characterImg.GetComponent<Image>().sprite = characterSprite[index];
        } else if (index == 1)
        {
            SansInfo.SetActive(false);
            PapyrusInfo.SetActive(true);
            characterImg.GetComponent<Image>().sprite = characterSprite[index];
        }

    }
}
