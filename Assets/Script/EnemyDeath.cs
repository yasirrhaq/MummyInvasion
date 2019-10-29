using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    Spawner spawner;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Destroy(gameObject);
        }
    }
    // public GameObject deathEffect;
    // public GameObject gameCamera;

    // private void Start() {
    //     gameCamera = GameObject.Find("AR Camera");
    // }
    // private void Update()
    // {
    //     DetectTouch();
    // }
    // void DetectTouch()
    // {
    //     RaycastHit hit = new RaycastHit();
    //     for (int i = 0; i < Input.touchCount; ++i)
    //     {
    //         if (Input.GetTouch(i).phase.Equals(TouchPhase.Began))
    //         {
    //             // Construct a ray from the current touch coordinates
    //             Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
    //             if (Physics.Raycast(ray, out hit))
    //             {
    //                 if (hit.transform.gameObject.tag == "Enemy")
    //                 {
    //                     Destroy(gameObject);
    //                 }
    //             }
    //         }
    //     }
    // }
}