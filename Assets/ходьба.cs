using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ходьба : MonoBehaviour
{
  
    [SerializeField] Transform[] points;
    [SerializeField] Transform target;
    [SerializeField] float speedMove;

    int i = 0;

    void Update()
    {
        target.position = Vector3.MoveTowards(target.position, points[i].position, speedMove * Time.deltaTime);

        if (target.position == points[i].position)
        {
            /* if (++i == points.Length)
             {
                 i = 0;
             } */
            i++;
        }
    }
}

