using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : MonoBehaviour
{
    Transform pipeTransform;
    // Start is called before the first frame update
    void Start()
    {
        pipeTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        pipeTransform.position += Vector3.left * 2.5f * Time.deltaTime;

    }
}
