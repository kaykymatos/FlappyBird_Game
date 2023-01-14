using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    MeshRenderer background;
    public MeshRenderer baseMove;

    // Start is called before the first frame update
    void Start()
    {
        background = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movimentImages = 0.5f * Time.deltaTime * Vector2.right; ;
        background.material.mainTextureOffset += movimentImages;
        baseMove.material.mainTextureOffset += movimentImages;
    }
}
