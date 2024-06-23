using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Ball : MonoBehaviour
{    
    private Rigidbody2D _rigidbody;

    public float speed = 200.0f;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    
    // Start is called before the first frame update
    void Start()
    {
        ResetPosition();
        AddStartingForce();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetPosition()
    {
        _rigidbody.position = UnityEngine.Vector3.zero;
        _rigidbody.velocity = UnityEngine.Vector3.zero;
    }

    public void AddStartingForce()
    {
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1.0f);

        UnityEngine.Vector2 direction = new UnityEngine.Vector2(x, y);
        _rigidbody.AddForce(direction * speed);
    }

    public void AddForce(UnityEngine.Vector2 force)
    {
        _rigidbody.AddForce(force);
    }

}
