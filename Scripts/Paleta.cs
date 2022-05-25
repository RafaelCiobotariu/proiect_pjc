using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paleta : MonoBehaviour
{
    protected Rigidbody2D _rigidbody;
    public float speed = 10.0f;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }


    public void ResetPositionPaleta()
    {
        _rigidbody.position = new Vector2(_rigidbody.position.x, 0.0f);
        _rigidbody.velocity = Vector2.zero;
    }

}
