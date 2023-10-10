using UnityEngine;

public class shoot : MonoBehaviour
{
    private Rigidbody2D rb;
    void Start()
    {
        Vector2 rotationVector = new Vector2(Mathf.Cos(30 * Mathf.Deg2Rad), Mathf.Sin(30 * Mathf.Deg2Rad));
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(rotationVector * 500);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "base")
        {
            Destroy(gameObject);
        }
    }
}
