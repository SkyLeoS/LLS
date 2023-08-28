using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class созданиезомби : MonoBehaviour
{
    public int ZombieCount = 10;
    [SerializeField] GameObject zombie;
    public GameObject[] Zombies;

    public void Start()
    {
        Zombies = new GameObject[ZombieCount];
        StartCoroutine(ZombieGenerating());
    }
    IEnumerator ZombieGenerating()
    {
        for (int i = 0; i < ZombieCount; i++)
        {
            Zombies[i] = Instantiate(zombie, transform.position, transform.rotation);
            yield return new WaitForSeconds(1);
        }
    }
}
