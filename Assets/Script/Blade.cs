using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour
{
    public bool isCutting=false;

    public float minCuttingVeloction = .001f;

    public GameObject BladeTrailPrefab;

    SphereCollider circleCollider;

    GameObject CurrentBlade;

    Vector2 previousPosition;

    Rigidbody rb;

    Camera cam;


    private void Start()
    {
        cam = Camera.main;
        rb = GetComponent<Rigidbody>();
        circleCollider = GetComponent<SphereCollider>();
    }

    void Update()
    {
        //Kiểm tra khi bấm và đè vào màn hình 
        if(Input.GetMouseButtonDown(0))
        {
            StartCutting();
        }
        //Kiểm tra khi thả tay khỏi màn hình 
        else if (Input.GetMouseButtonUp(0))
        {
            Stopcutting();
        }
        //Kiểm tra khi isCutting = true
        if(isCutting)
        {
            UpdateCut();
        }
      

    }

   void UpdateCut()
    {
        //Lấy vị trí của chuột trên camera
        
        Vector2 newPosition= cam.ScreenToWorldPoint(Input.mousePosition);
        rb.position = newPosition;
        // Tính chiều dài 
        float Velecity = (newPosition -  previousPosition).magnitude*Time.deltaTime;
        if(Velecity > minCuttingVeloction)
        {
            circleCollider.enabled = true;
        }
        else
        {
            circleCollider.enabled = false;
        }
        previousPosition = newPosition;
    }

    void StartCutting()
    {
        isCutting = true;
        //Sinh ra line
        CurrentBlade = Instantiate(BladeTrailPrefab, transform);
        //Hiện Circlecollider
        circleCollider.enabled = true;
        previousPosition = cam.ScreenToWorldPoint(Input.mousePosition) ;
    }
    void Stopcutting()
    {
        isCutting=false;
        //Xóa Line
        CurrentBlade.transform.SetParent(null);
        Destroy(CurrentBlade ,2f);
        //Tắt Circlecollider
        circleCollider.enabled=false;
    }
}
