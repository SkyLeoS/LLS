using UnityEngine;

public class ходьба : MonoBehaviour
{
  
    [SerializeField] public Transform[] points;
    [SerializeField] float Speed;
    [SerializeField] private string TAG;
    public float speed;
    private Rigidbody2D rb;

    public int i = 0;
    public int Health = 10;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = Speed;
    }
    private void Update()
    {
        if(Health < 0)
        {
            Destroy(gameObject);
        }
    }
    void FixedUpdate()
    {
        if (i < points.Length)
        {
            Vector2 direction = (Vector2)points[i].position - rb.position;
            direction.Normalize();

            if (Vector2.Distance(rb.position, points[i].position) < 0.1f)
            {
                i++;
            }
            else
            {
                rb.velocity = direction * speed;
            }
            RaycastHit2D hit = Physics2D.Raycast(new Vector2(transform.position.x + 0.6f, transform.position.y), new Vector2(1, 0), 0.01f);
            if (hit.collider != null)
            {
                if (hit.collider.tag == TAG)
                {
                    speed = 0;
                }
            }
            else
            {
                speed = Speed;
            }
        }
        else
        {
            rb.velocity = Vector2.zero;
            speed = 0;
        }
    }
}

