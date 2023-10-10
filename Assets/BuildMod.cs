using UnityEngine;

public class BuildMod : MonoBehaviour
{
    private void Update()
    {
        Debug.Log((Input.mousePosition / 10) - transform.position);
    }
}
