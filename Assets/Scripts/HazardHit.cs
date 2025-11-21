using UnityEngine;

public class HazardHit : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            FindObjectOfType<GameManager>().Lose();
        }
    }
}
