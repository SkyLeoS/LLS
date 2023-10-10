using UnityEngine;
using System.Collections;

public class RangerZombie : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    private bool Do = true;
    void Update()
    {
        if (GetComponent<ходьба>().speed == 0 && Do)
        {
            StartCoroutine(Attacking());
            Do = false;
        }
    }
    private IEnumerator Attacking()
    {
        yield return new WaitForSeconds(1f);
        Instantiate(bullet, transform.position, Quaternion.Euler(0, 30, 0));

        Do = true;
    }
}