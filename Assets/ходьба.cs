using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ходьба : MonoBehaviour
{
  
    [SerializeField] Transform[] points;
    [SerializeField] Transform target;
    [SerializeField] float speedMove;
    private Rigidbody2D rb;

    int i = 0;
    bool move = true;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if(i < 3 && move)
        {
            target.position = Vector3.MoveTowards(target.position, points[i].position, speedMove * Time.deltaTime);

            if (target.position == points[i].position)
            {
                i++;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        rb.bodyType = RigidbodyType2D.Kinematic;
        Debug.Log("hit");
        move = false;
    }
}

