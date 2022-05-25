using UnityEngine;

public class Minge : MonoBehaviour
{

    public float speed = 200.0f;
    protected Rigidbody2D _rigidbody;
    public void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }



    public void Start()
    {
        ResetBall();
    }

    public void AddStartingForce()
    {
        float x = Random.value < 0.5f ? -1 : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1.0f);

        Vector2 direction = new Vector2(x, y);
        _rigidbody.AddForce(direction * this.speed);
    }

    public void AddForce(Vector2 force)
    {
        _rigidbody.AddForce(force);
    }


    public void ResetBall()
    {
        _rigidbody.position = Vector3.zero;
        _rigidbody.velocity = Vector3.zero;

        AddStartingForce();
    }
}
