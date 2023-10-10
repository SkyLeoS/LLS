using UnityEngine;

public class pause : MonoBehaviour
{
    public bool OnPause;
    public void OnClick()
    {
        if (OnPause)
        {
            Resume();
        }
        else
        {
            Pause();
        }
    }
    public void Pause()
    {
        Time.timeScale = 0f;
        OnPause = true;
    }
    public void Resume()
    {
        Time.timeScale = 1f;
        OnPause = false;
    }
}
