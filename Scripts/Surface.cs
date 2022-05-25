using UnityEngine;

public class Surface : MonoBehaviour
{
    public float bonceStrenght;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Minge ball = collision.gameObject.GetComponent<Minge>();

        if (ball != null)
        {
            Vector2 normal = collision.GetContact(0).normal;
            ball.AddForce(-normal * this.bonceStrenght);
        }
    }

}
