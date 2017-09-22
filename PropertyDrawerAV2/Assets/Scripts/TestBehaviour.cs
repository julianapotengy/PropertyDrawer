using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class TestBehaviour : MonoBehaviour
{
    [TagSelector]
    public string myTag;

    [LayerSelector]
    public int myLayer;

    [HideInInspector]
    public GameObject anotherObj;

    private void Update()
    {
        this.gameObject.tag = myTag;
        this.gameObject.layer = myLayer;

        // change another GameObject tag and layer
        anotherObj = GameObject.Find("Another" + this.gameObject.name);
        anotherObj.tag = this.gameObject.tag;
        anotherObj.layer = this.gameObject.layer;
    }
}