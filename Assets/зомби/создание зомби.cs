using System.Collections;
using UnityEngine;

public class созданиезомби : MonoBehaviour
{
    [SerializeField] GameObject RangerZombie;
    [SerializeField] GameObject zombie;
    public GameObject[] Zombies;
    public GameObject[] RangerZombies;

    public void Start()
    {
        StartCoroutine(ZombieGenerating());
    }
    IEnumerator ZombieGenerating()
    {
        for(int i = 0; i < Wave.waves.Count; i++)
        {
            if(Wave.waves[i] == 1)
            {
                Instantiate(zombie, transform.position, Quaternion.identity);
            }
            else
            {
                Instantiate(RangerZombie, transform.position, Quaternion.identity);
            }
            yield return new WaitForSeconds(1);
        }
    }
}
