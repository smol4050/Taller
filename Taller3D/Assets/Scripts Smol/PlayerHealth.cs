using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private Scene2Controller sceneController;

    private Vector3 initialPosition;

    void Start()
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
        
        sceneController.PenalizeDeath(30f);

        
        transform.position = initialPosition;

        
    }
}
