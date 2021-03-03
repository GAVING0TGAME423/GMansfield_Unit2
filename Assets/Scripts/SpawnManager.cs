using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalprefabs;
    private float XPositionRange = 19;
    void Start()
    {
        
    }

   
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.A))
        {
            float randomXposition = Random.Range(-XPositionRange, XPositionRange);
            int animalprefabIndex = Random.Range(0, animalprefabs.Length);
            Vector3 random = new Vector3(randomXposition, 0, 21);
            Instantiate(animalprefabs[animalprefabIndex], random,
                animalprefabs[animalprefabIndex].transform.rotation);
        }
    }
}
