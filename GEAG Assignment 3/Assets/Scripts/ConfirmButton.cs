using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfirmButton : InteractableButtons
{
    private GameObject objectToPrint;
    private int objectSize;
    private Color color;

    public GameObject configObj;
    public Color idleColor;
    public Color hoverColor;
    ConfigController configController;
    Color OriginColor;
    // Start is called before the first frame update
    void Start()
    {
        Init();
        configController = configObj.GetComponent<ConfigController>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void OnClick()
    {
        print("Size: " + configController.size);
        print("Color: " + configController.color);
        SpawnObject();
    }

    void SpawnObject()
    {
        if (configController.ObjectToPrint != null)
        {
           GameObject printedObject = 
                Instantiate(configController.ObjectToPrint, printerTransform.position, Quaternion.identity);

            printedObject.transform.localScale =
               new Vector3(configController.size * 0.03f, configController.size * 0.03f, configController.size * 0.03f);

            printedObject.GetComponent<Renderer>().material.color = configController.color;
            printedObject.AddComponent<Rotator>();
        }
    }

    public override void OnHover()
    {
        if (hovering == false)
        {
            GetComponent<SpriteRenderer>().color = hoverColor;
            hovering = true;
        }
    }

    public override void DeHover()
    {
        if (hovering == true)
        {
            GetComponent<SpriteRenderer>().color = idleColor;
            hovering = false;
        }
    }
}
