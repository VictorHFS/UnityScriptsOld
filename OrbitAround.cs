using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class OrbitAround : MonoBehaviour
{
    public Vector3 FreezeModeOffset = Vector3.zero;
    public GameObject Target;
    public GameObject FreezeTarget;
    public float MovingSpeed = 1;
    public float MouseSensitive = 1;
    public Vector3 lookAtEulerOffset = new Vector3(45,0,0);
    private float degrees = 0;
    private Vector3 offset;
    private event System.Action updateAction;

    private UserControls controls;

    private void Awake() {
        controls = new UserControls();
    }

    private void OnEnable() {
        controls.Camera.MouseMove.Enable();
        controls.Camera.MouseMove.performed += (ctx) => onMouseMove(ctx.ReadValue<float>());
    }

    private void OnDisable() {
        controls.Camera.MouseMove.Disable();
        controls.Camera.MouseMove.performed -= (ctx) => onMouseMove(ctx.ReadValue<float>());
    }

    void Start()
    {
        this.offset = this.transform.position - this.Target.transform.position;
        this.updateAction = defaultUpdate;
    }

    void FixedUpdate()
    {
        if(updateAction != null)
            updateAction.Invoke();
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(Camera.main.transform.position + FreezeModeOffset, .1f);
    }

    void onSelectMagic(MagicEnum magic)
    {
        if (magic.Equals(MagicEnum.Freeze))
        {
            updateAction = freezeUpdate;
        } else //if(magic.Equals(MagicEnum.None))
        {
            updateAction = defaultUpdate;
        }
    }

    private void freezeUpdate()
    {
        freezeCheckPositionRotation();
        checkFreezeLookAt();
    }


    private void freezeCheckPositionRotation()
    {
        Quaternion newRotation = Quaternion.Euler(0, degrees, 0);
        Vector3 newPos = this.Target.transform.position + newRotation * this.offset;
        Vector3 newPos2= Vector3.Lerp(newPos, newPos + newRotation * FreezeModeOffset, Time.deltaTime * MovingSpeed);
        this.transform.position = Vector3.Lerp(this.transform.position, newPos2, Time.deltaTime * MovingSpeed);
    }


    private void defaultUpdate()
    {
        checkPositionRotation();
        checkLookAt();
    }

    private void checkLookAt()
    {
        this.transform.LookAt(this.Target.transform);
        this.transform.rotation *= Quaternion.Euler(this.lookAtEulerOffset);
    }

    private void checkFreezeLookAt()
    {
        this.transform.LookAt(this.Target.transform);
        this.transform.rotation *= Quaternion.Euler(this.lookAtEulerOffset);
    }

    private void checkPositionRotation()
    {
        //Debug.Log("degrees -> " + degrees);
        Quaternion newRotation = Quaternion.Euler(0, degrees, 0);
        Vector3 newPos = this.Target.transform.position + newRotation * this.offset;
        this.transform.position = Vector3.Lerp(this.transform.position, newPos, Time.deltaTime * MovingSpeed);
    }

    void onMouseMove(float mouseInput)
    {
        Debug.Log("mouseInput -> " +  mouseInput);
        degrees += Mathf.Lerp(degrees, mouseInput * MouseSensitive, Time.deltaTime);
    }
}
