using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowButton : InteractableButtons
{
    public bool isLeft = false;
    public bool isColorPlate = true;
    public ConfigController configController;
    public Color idleColor;
    public Color hoverColor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void OnClick()
    {
        configController.OnArrowClicked(isLeft, isColorPlate);
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
