using UnityEngine;

public class Pushable : MonoBehaviour {

    private float Deaceleration = 5;
    private Vector3 force = Vector3.zero;

    private void FixedUpdate() {
        this.transform.position += force;
    }

    private void LateUpdate() {
        deaccelerate();
    }

    private void deaccelerate() {
        if (Vector3.zero != force) {
            float resultingMagnitude = force.magnitude - Deaceleration;
            force = force.normalized * Deaceleration;
        }
    }

    void push(Vector3 force) {
        this.force = force;
    }
}