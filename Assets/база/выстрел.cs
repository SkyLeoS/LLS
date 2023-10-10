using UnityEngine;

public class выстрел : MonoBehaviour
{
    [SerializeField] GameObject zombie;
    [SerializeField] private int CoolDown = 10;
    private bool DoSomething = true;

    public int Range = 1;

    private void Start()
    {
        InvokeRepeating("Shoot", 0f, CoolDown);
    }

    private void Shoot()
    {
        if (DoSomething)
        {
            if (zombie == null)
            {
                zombie = GameObject.FindWithTag("zombie");
                if (zombie == null)
                {
                    DoSomething = false;
                }
            }
            RaycastHit2D hit = Physics2D.Raycast(transform.position, zombie.transform.position - transform.position,Range);

            if (hit.collider != null)
            {
                hit.collider.gameObject.GetComponent<ходьба>().Health--;
            }
        }
    }
}