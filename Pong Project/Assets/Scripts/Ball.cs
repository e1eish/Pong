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
        AddStartingForce();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void AddStartingForce()
    {
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1.0f);

        UnityEngine.Vector2 direction = new UnityEngine.Vector2(x, y);
        _rigidbody.AddForce(direction * speed);
    }
}
