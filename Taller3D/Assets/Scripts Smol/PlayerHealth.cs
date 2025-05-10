using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private Transform spawnPoint;
    private Vector3 initialPosition;
    private void Start()
    {
        initialPosition = spawnPoint.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DeathZone"))
        {
            Respawn();
        }
    }

    private void Respawn()
    {
        transform.position = initialPosition;
    }
}

