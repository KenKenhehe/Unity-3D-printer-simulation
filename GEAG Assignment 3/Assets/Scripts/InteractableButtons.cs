using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableButtons : MonoBehaviour
{
    protected Animator animator;
    protected bool hovering = false;
    public Transform printerTransform;

    // Start is called before the first frame update
    void Start()
    {
        Init();
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    public virtual void Init()
    {
        animator = GetComponent<Animator>();
        //printerTransform = GameObject.FindGameObjectWithTag("printerTransform").transform;
    }

    public virtual void OnHover()
    {
        
    }

    public virtual void DeHover()
    {
       
    }

    public virtual void OnClick()
    {
        
    }
}
