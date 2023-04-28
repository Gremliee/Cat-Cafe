using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move ()
    {
        var horizontal = Input.GetAxisRaw("Horizontal");
        var vertical = Input.GetAxisRaw("Vertical");
        transform.position += new Vector3(horizontal * Time.deltaTime * speed, vertical * Time.deltaTime * speed, 0);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -7.14f, 7.19f), Mathf.Clamp(transform.position.y, -4.4f, 4.18f));
    }
    
}
