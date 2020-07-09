using System.Collections.Generic;
using UnityEngine;

public class RemoveSlowDownOnTrigger : MonoBehaviour {
    private Dictionary<GameObject, float> objects;
    private void OnTriggerEnter(Collider other) {
        SlowsDownTime slowDownScript = other.gameObject.GetComponent<SlowsDownTime>();
        float rate = slowDownScript.slowDownRate;
        objects.Add(other.gameObject, rate);
        slowDownScript.slowDownRate = 1;
    }

    private void OnTriggerExit(Collider other) {
        SlowsDownTime script = other.gameObject.GetComponent<SlowsDownTime>();
        float value;
        if (objects.TryGetValue(other.gameObject, out value)) {
            if (script.slowedDown) {
                script.slowDownRate = value;
            }
        }
        objects.Remove(other.gameObject);
    }
}