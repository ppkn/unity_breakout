using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public float horizontalExtent = 2.5f;
    float horizontalInput = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        transform.Translate(Vector2.right * horizontalInput * Time.deltaTime * speed);

        if (transform.position.x < -horizontalExtent) {
            transform.position = new Vector2(-horizontalExtent, transform.position.y);
        }
        if (transform.position.x > horizontalExtent) {
            transform.position = new Vector2(horizontalExtent, transform.position.y);
        }
    }
}
