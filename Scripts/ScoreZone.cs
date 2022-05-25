using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BoxCollider2D))]
public class ScoreZone : MonoBehaviour
{
    public UnityEvent scoreTrigger;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Minge ball = collision.gameObject.GetComponent<Minge>();

        if (ball != null)
        {
            scoreTrigger.Invoke();
        }
    }

}