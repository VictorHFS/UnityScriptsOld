using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    public GameObject Target;
    [Range(1, 10)]
    public float Speed;
    private Vector3 offset;
    void Start()
    {
        this.offset = this.transform.position - this.Target.transform.position;
    }
    void FixedUpdate()
    {
        this.transform.position = Vector3.Lerp(this.transform.position, this.Target.transform.position + this.offset, Time.deltaTime * Speed);
    }
}
