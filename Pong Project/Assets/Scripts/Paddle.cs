using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    protected Rigidbody2D _rigidbody;

    public float speed = 10.0f;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetPosition()
    {
        _rigidbody.position = new UnityEngine.Vector2(_rigidbody.position.x, 0.0f);
        _rigidbody.velocity = UnityEngine.Vector2.zero;
    }
}
