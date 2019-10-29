using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : MonoBehaviour
{
    public Transform target;
    public float enemyMovementSpeed;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindWithTag("Player").transform;
    }

    private void Otw()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, enemyMovementSpeed * Time.deltaTime);
    }
    // Update is called once per frame
    void Update()
    {
        Otw();
    }
}
