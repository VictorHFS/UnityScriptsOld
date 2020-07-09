using UnityEngine;
using System.Collections;

public class DeactivateOnDeath : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        GetComponent<HealthController>().OnDeath += Deactivate;
    }

    void Deactivate()
    {
        this.gameObject.SetActive(false);
    }
}
