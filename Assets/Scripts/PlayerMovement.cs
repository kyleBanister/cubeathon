using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    public float forwardForce = 1000f;
    public float sidewaysForce = 20f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        Debug.Log("Hello, World!");
        
    }

    void FixedUpdate() {
        rb.AddForce(0, 0, forwardForce*Time.deltaTime);

        if (Input.GetKey("a")) {
            rb.AddForce(-sidewaysForce*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("d")) {
            rb.AddForce(sidewaysForce*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    
        if (rb.position.y < -1f) {
            FindAnyObjectByType<GameManager>().EndGame();
        }
    }
}
