using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnCollisionEnter(Collision collision) {
        if(collision.collider.tag == "Obstacle") {
            Debug.Log("Hit an obstacle!");
            movement.enabled = false;
            FindAnyObjectByType<GameManager>().EndGame();

        }
    }
}
