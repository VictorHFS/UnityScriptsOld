using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class SimpleFollow : RagdollBehavior
{
    [SerializeField]
    private float PushForce = 10;

    [SerializeField]
    private float Damage = 1;

    [SerializeField]
    private float Speed = 10;
    private Transform Target;

    [SerializeField]
    private float DelayMove = 4f;

    [SerializeField]
    private float DelayRag = 4f;
    private float currDelayMove = 0f;

    private EnemyCoordenator enemyCoordenator;

    private HealthController health;

    private float currRagDelay = 0;

    [SerializeField]
    private List<Collider> triggers;

    private TargetOnSight OnSight;

    private void Awake()
    {
        OnSight = GetComponent<TargetOnSight>();
        Animator = GetComponentInChildren<Animator>();
        enemyCoordenator = GameObject.Find("EnemyCoordenator")
                                     .GetComponent<EnemyCoordenator>();
        Rigidbody = GetComponent<Rigidbody>();
        ChildrenColliders = childrenCollidersIgnoringTrigger();
        Collider = GetComponent<Collider>();
        health = GetComponent<HealthController>();
        health.OnDamage += StandBy;
        GetComponentInChildren<TargetOnSight>().OnTriggeredTarget += (obj) => {
            if (obj)
                Target = obj.transform;
            else 
                Target = null;
        };
        OnRagdoll += (val) =>
        {
            if (val)
                currRagDelay = DelayRag;
            else
                currDelayMove = 0;
        };
        DoRagdoll(false);
    }


    private Collider[] childrenCollidersIgnoringTrigger()
    {
        List<Collider> a = new List<Collider>();
        foreach (Collider c in GetComponentsInChildren<Collider>())
        {
            if (!triggers.Contains(c))
            {
                a.Add(c);
            }
        }
        return a.ToArray();
    }

    private void OnEnable()
    {
        enemyCoordenator.OnStandBy += StandBy;
    }

    private void OnDisable()
    {
        enemyCoordenator.OnStandBy -= StandBy;
    }
    void StandBy()
    {
        currDelayMove = DelayMove;
        this.Animator.SetBool("Running", false);
    }

    private void Update()
    {
        if (currDelayMove > 0)
        {
            currDelayMove = Mathf.Clamp(currDelayMove - Time.deltaTime, 0, DelayMove);
        }
    }

    void FixedUpdate()
    {
        if (currDelayMove > 0) return;

        transform.rotation = Quaternion.identity;
        if (Target)
        {
            Vector3 direction = (Target.transform.position - this.transform.position).normalized;
            transform.rotation = Quaternion.LookRotation(direction, transform.up);
            Rigidbody.velocity = direction * Speed;
            Animator.SetBool("Running", true);
        }
        else
        {
            Animator.SetBool("Running", false);
        }
        if (currRagDelay > 0)
        {
            currRagDelay = Mathf.Clamp(currRagDelay - Time.deltaTime, 0, DelayRag);
        }
        else if (IsRagdoll)
        {
            Debug.Log("Remove RagDoll");
            DoRagdoll(false);
        }
    }

    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "Player")
        {
            HealthController h = other.gameObject.GetComponent<HealthController>();
            if (h)
            {
                h.damage(Damage);
            }
            ;
            Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
            if (rb)
            {
                rb.velocity = (transform.forward + transform.up) * PushForce;
            }
            other.gameObject.GetComponent<Player>().DoRagdoll(true);
        }
    }

}
