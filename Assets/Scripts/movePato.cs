using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePato : MonoBehaviour
{
    public float vel = 2.5f;
    public float forcaPulo = 40f;
    public Rigidbody2D pato;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector2(vel * Time.deltaTime, 0));
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector2(-vel * Time.deltaTime,0));
        }

        if (Input.GetKey(KeyCode.Space))
        {
            pato.AddForce(new Vector2(0, forcaPulo * Time.deltaTime), ForceMode2D.Impulse);
        }
    }
}
