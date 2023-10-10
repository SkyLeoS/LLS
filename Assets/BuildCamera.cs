using UnityEngine;

public class BuildCamera : MonoBehaviour
{
    [SerializeField] Camera Camera;
    public bool BuildPosition;

    public void OnClick()
    {
        if(BuildPosition)
        {
            Camera.transform.position = new Vector3(0, 1.4f, -4);
            Camera.orthographicSize = 6.5f;
            BuildPosition = false;
        }
        else
        {
            Camera.transform.position = new Vector3(10, 1, -4);
            Camera.orthographicSize = 4.5f;
            BuildPosition = true;
        }
    }
}
