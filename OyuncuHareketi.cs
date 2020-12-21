using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.U2D;
using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;


public class OyuncuHareketi : MonoBehaviour
{
    public float hareketHızı = 5f;

    public Rigidbody2D ragdoll;
    public Camera kam;

    Vector2 hareket;
    Vector2 mousecoord;

    void Start()
    {
        
    }

   
    void Update()
    {
        hareket.x = Input.GetAxisRaw("Horizontal");
        hareket.y = Input.GetAxisRaw("Vertical");
        mousecoord = Input.mousePosition;
        mousecoord = kam.ScreenToWorldPoint(Input.mousePosition);
        Debug.Log(mousecoord);
    }

    void FixedUpdate()
    {
        ragdoll.MovePosition(ragdoll.position + hareket * hareketHızı * Time.fixedDeltaTime);

        Vector2 facetomouse = mousecoord - ragdoll.position;
        float açı = Mathf.Atan2(facetomouse.y, facetomouse.x) * Mathf.Rad2Deg;
        ragdoll.rotation = açı;
        
    }
}