using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnController : MonoBehaviour
{
    public Transform pipe;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 0f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Spawn()
    {
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(-3, 3), 0), Quaternion.identity);
    }
}
