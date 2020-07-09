using UnityEngine;

public class SlowsDownTime : MonoBehaviour {
    public InputHandler input;
    private Rigidbody _rb;
    public float slowDownRate = 1;
    public bool slowedDown = false;

    private void Start() {
        _rb = GetComponent<Rigidbody>();
        input.onSlowDown += val => {
            slowDownRate = val;
            slowedDown = val != 1;
        };
    }
    private void FixedUpdate() {
        if (_rb && slowDownRate != 1) {
            _rb.velocity *= slowDownRate;
        }
    }
}