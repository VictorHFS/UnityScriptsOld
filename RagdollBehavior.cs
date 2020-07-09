using UnityEngine;

public class RagdollBehavior : MonoBehaviour {

    public event System.Action<bool> OnRagdoll;
    public bool IsRagdoll {get {return _isRagdoll;}}
    private bool _isRagdoll = false;

    public Animator Animator {get {return _animator;}set{_animator = value;}}
    private Animator _animator;

    public Rigidbody Rigidbody {get {return _rigidbody;} set {_rigidbody = value;}}
    private Rigidbody _rigidbody;

    public Collider[] ChildrenColliders {get{return _childrenColliders;}set{_childrenColliders=value;}}
    private Collider[] _childrenColliders;

    public Collider Collider{get {return _collider;}set{_collider=value;}}
    private Collider _collider;

    public void DoRagdoll(bool value) {
        if (_childrenColliders!=null)
            foreach(Collider col in _childrenColliders)
                col.enabled = value;
        if (_collider)
            _collider.enabled = !value;
        if (_rigidbody)
            _rigidbody.useGravity= !value;
        if (_animator)
            _animator.enabled = !value;
        _isRagdoll = value;
        if (OnRagdoll!=null)
            OnRagdoll.Invoke(value);
    }
}