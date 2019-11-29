using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ConfigController : MonoBehaviour
{
    public GameObject leftArrow;
    public GameObject rightArrow;
    public GameObject sizeText;
    public GameObject colorPlate;
    public GameObject cancelButton;

    [HideInInspector]
    public int size = 1;
    [HideInInspector]
    public Color color = new Color(1, 1, 1, 1);

    [HideInInspector]
    public GameObject ObjectToPrint;

    public Color[] colors;

    int maxSize = 10;
    int colorIndex = 2;
    Color currentColor;
    // Start is called before the first frame update
    void Start()
    {
        colors = new Color[] {
            new Color(1,1,1,1), //white
            new Color(1, 0, 0, 1), //red
            new Color(0, 1, 0, 1), //green
            new Color(0, 0, 1, 1), //blue
            new Color(0,0,0,1) //black
        };

        colorPlate.GetComponent<SpriteRenderer>().color = colors[colorIndex];
        color = colors[colorIndex];
    }

    // Update is called once per frame
    void Update()
    {
        colorPlate.GetComponent<SpriteRenderer>().color = colors[colorIndex];
        color = colors[colorIndex];
    }

    public void OnArrowClicked(bool isLeft, bool isColorPlate)
    {
        print(colorIndex);
        if (isColorPlate == true)
        {
            if (isLeft == false)
            {
                colorIndex++;
                if (colorIndex >= colors.Length)
                {
                    colorIndex = 0;
                }
            }
            else
            {
                colorIndex--;
                if (colorIndex < 0)
                {
                    colorIndex = colors.Length;
                }
            }
            colorPlate.GetComponent<SpriteRenderer>().color = colors[colorIndex];

        }
        else
        {
            if (isLeft == false)
            {
                size++;
                if (size >= 10)
                {
                    size = 1;
                }
            }
            else
            {
                size--;
                if (size <= 1)
                {
                    size = 10;
                }
            }
            sizeText.GetComponent<TextMeshPro>().text = "Size: " + size + " / 10";
        }
    }
}
