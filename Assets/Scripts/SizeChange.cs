using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Izmeri : MonoBehaviour
{

    public GameObject targetImage;
    public GameObject widthSlider;
    public GameObject heightSlider;

    private float WidthValue=1;
    private float HeightValue=1;

    public void UpdateWidth()
    {
        WidthValue = widthSlider.GetComponent<UnityEngine.UI.Slider>().value;
        targetImage.transform.localScale = new Vector2(1f * WidthValue, HeightValue);
    }

    public void UpdateHeight()
    {
        HeightValue = heightSlider.GetComponent<UnityEngine.UI.Slider>().value;
        targetImage.transform.localScale = new Vector2(WidthValue, 1f * HeightValue);
    }
}
