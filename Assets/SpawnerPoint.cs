using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerPoint : MonoBehaviour
{
    public GameObject[] kupler;
    public float hiz=5.0f;
    // Start is called before the first frame update
    void Start()
    {
        YenKupler();
    }

    public void YenKupler()
    {
        Instantiate(kupler[Random.Range(0, kupler.Length)], transform.position, Quaternion.identity);
    }
}
