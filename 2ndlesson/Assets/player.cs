using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Move()
    {
        var deltaX = Input.GetAxis("Horizontal");

        var newXPos = transform.position.x + deltaX;

        this.transform.position = new Vector2(newXPos, CryptoAPITransform.position.y);
    }
}
