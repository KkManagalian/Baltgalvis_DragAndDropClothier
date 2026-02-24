using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Change : MonoBehaviour
{
    public GameObject characterImg;
    public GameObject wardrobe;
    public GameObject SansInfo;
    public GameObject PapyrusInfo;
    public UnityEngine.UI.Toggle[] toggles;
    public Sprite[] characterSprite;
    public Sprite[] SansWardrobe;
    public Sprite[] PapyrusWardrobe;
    public GameObject[] SansClothes;
    public GameObject[] PapyrusClothes;

    private int bigIndex;


    void Start()
    {
        for (int i = 0; i < toggles.Length; i++)
        {
            int index = i;

            toggles[i].onValueChanged.AddListener((isOn) =>
            {
                if (isOn)
                {
                    ChangeWardobe(index);
                }
            });
        }

        for (int i = 0; i < toggles.Length; i++)
        {
            if (toggles[i].isOn)
            {
                ChangeWardobe(i);
                break;
            }
        }
    }

    void ChangeWardobe(int index)
    {
        if (index >= 0 && index < SansWardrobe.Length)
        {
            wardrobe.GetComponent<UnityEngine.UI.Image>().sprite = SansWardrobe[0];
        }
    }

    public void ChangeCharacterImage(int index)
    {
        if (index == 0)
        {
            bigIndex = 0;
            SansInfo.SetActive(true);
            PapyrusInfo.SetActive(false);
            characterImg.GetComponent<UnityEngine.UI.Image>().sprite = characterSprite[index];


        }
        else if (index == 1)
        {
            bigIndex = 1;
            SansInfo.SetActive(false);
            PapyrusInfo.SetActive(true);
            characterImg.GetComponent<UnityEngine.UI.Image>().sprite = characterSprite[index];

        }

    }
}