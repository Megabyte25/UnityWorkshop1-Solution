using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public ShieldSpawner shieldSpawner;

    void Update()
    {
        // TODO: Setup inputs to move the player left, right, forward and backwards
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = Vector3.ClampMagnitude(new Vector3(horizontal, 0f, vertical), 1f);
        transform.Translate(direction * speed * Time.deltaTime);

        // TODO: Press a specific button to spawn a shield
        // TODO: Deduct the number of shields available (consider writing this code in another component)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            shieldSpawner.SpawnShield();
        }
    }
}
