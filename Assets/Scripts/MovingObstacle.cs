using UnityEngine;

public class MovingObstacle : MonoBehaviour {
    public Rigidbody rb;
    public float pathStart; //Lower x position of path
    public float pathLength; //Travel distance of path
    public float frequency; //Hertz

    void Start() {
        if (rb.position.x < pathStart) {
            rb.position.x = pathStart;
        } else if(rb.position.x > pathStart+pathLength) {
            rb.position.x = pathStart+pathLength;
        }

        timeValue = Math.Asin(rb.position.x/pathLength)/(frequency*Math.PI); //Get where in the sine wave the obstacle is starting.
        rb.linearVelocity.x = pathLength*frequency*Math.PI*Math.Cos(timeValue*frequency*Math.PI); //Set velocity to match sine wave position.
    }
    void FixedUpdate() {
        rb.AddForce(-pathLength*Math.Pow(frequency,2)*Math.Pow(Math.PI,2)*Math.Sin(frequency*Math.PI),0,0, ForceMode.Acceleration);
    }
}
