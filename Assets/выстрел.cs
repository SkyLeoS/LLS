using System.Net.Http.Headers;
using UnityEngine;

public class выстрел : MonoBehaviour
{
    [SerializeField] GameObject zombie;
    public int Range = 100;
    public void shoot()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, zombie.transform.position - transform.position);

        if (hit.collider != null)
        {
            //Debug.Log("Hit" + hit.collider.name);
        }
    }
    public void Update()
    {
        shoot();
    }
}
