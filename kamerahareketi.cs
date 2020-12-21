using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// need to change this

public class kamerahareketi : MonoBehaviour
{
    //move object
    public Transform moveThis;
    //hit plate on layer
    public LayerMask hitLayers;
    void Update()
    {
        Vector3 mouse = Input.mousePosition;
        Ray castPoint = Camera.main.ScreenPointToRay(mouse);
        RaycastHit hit;
        if (Physics.Raycast(castPoint, out hit, Mathf.Infinity, hitLayers))
        {
            moveThis.transform.position = hit.point;
        }
    }
}
