using UnityEngine;
using UnityEngine.InputSystem;

public class Player : RagdollBehavior, UserControls.IPlayerActions
{
    public event System.Action<MagicEnum> OnCast;
    public event System.Action OnCancelCastAction;
    public float Speed;
    [SerializeField]
    private Rigidbody rb;

    [SerializeField]
    private float RotationSpeed = 1;
    private UserControls controls;
    private Vector3 ResultingSpeed;
    private Vector3 MovementInput;
    private Vector3 ResultingAcceleration;
    private Vector3 SlowDownForce;

    private HealthController health;

    [SerializeField]
    private float delayOnDamage = 2;

    private float delayInput;
    private EnemyCoordenator enemyCoordenator;

    [SerializeField]
    private Transform[] feet;

    float currRagD = 0;

    private void Awake() {
        controls = new UserControls();
        health = GetComponent<HealthController>();
        if (GameObject.Find("EnemyCoordenator"))
            enemyCoordenator = GameObject.Find("EnemyCoordenator").GetComponent<EnemyCoordenator>();
        Rigidbody = rb;
        Animator = GetComponentInChildren<Animator>();
        ChildrenColliders = GetComponentsInChildren<Collider>(true);
        Collider = GetComponent<Collider>();
        OnRagdoll += (val) => {
            Debug.Log("OnRagdoll -> " + val);
            if (val) {
                currRagD = delayInput;
            }
        };
        DoRagdoll(false);
    }

    void Start()
    {
        controls.Player.SetCallbacks(this);
    }

    private void OnEnable() {
        controls.Enable();
        if (health)
        health.OnDamage += OnDamage;
    }

    private void OnDisable() {
        controls.Disable();
        if (health)
        health.OnDamage -= OnDamage;
    }

    private void FixedUpdate()
    {
        if (delayInput > 0) return;
        updateResultingDirection();
        checkAcceleration();
        checkRotation();
        checkAnimation();
        checkFootPlacement();
        if (currRagD > 0)
        {
            currRagD  = Mathf.Clamp(currRagD - Time.deltaTime, 0, delayInput);
        } else if (IsRagdoll)
        {
            DoRagdoll(false);
        }
    }

    private void checkFootPlacement() {

    }

    private void LateUpdate() {
        updateDelay();
    }

    void OnDamage() {
        Debug.Log("call OnDamage");
        enemyCoordenator.StandBy();
        delayInput = delayOnDamage;
    }

    void updateDelay() {
        if (delayInput > 0) {
            delayInput = Mathf.Clamp(delayInput - Time.deltaTime, 0, delayOnDamage);
        }
    }

    void updateResultingDirection() {
        Vector3 input = Quaternion.Euler(90, 0, 0) * MovementInput; // correct input direction
        Vector3 cameraDirection = Camera.main.transform.TransformDirection(input);
        Vector3 direction = removeY(cameraDirection).normalized;
        this.ResultingSpeed = direction * Speed;
    }

    private void checkAnimation() {
        if (Animator)
        {
            Animator.SetBool("Walking", rb.velocity.magnitude > 0);
            Animator.SetBool("Running", rb.velocity.magnitude > 5);
        }
    }

    private void checkAcceleration()
    {
        this.ResultingSpeed -= this.SlowDownForce * Time.deltaTime;
        this.rb.velocity = this.ResultingSpeed;
    }

    private void checkRotation() {
        Debug.Log("transform.rotation -> "+ transform.rotation.eulerAngles);
        Vector3 direction = removeY(Camera.main.transform.forward);
        Quaternion rotationToDirection = Quaternion.LookRotation(direction).normalized;
        transform.rotation = Quaternion.Lerp(transform.rotation.normalized, rotationToDirection, Time.deltaTime * RotationSpeed);
        Debug.Log(transform.rotation.eulerAngles);
    }

    private Vector3 removeY(Vector3 vector)
    {
        return new Vector3(vector.x, 0, vector.z);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        MovementInput = context.ReadValue<Vector2>();
    }

    void drawLine(Vector3 Line, Color color) {
        Debug.DrawLine(transform.position+Vector3.up , transform.position+Vector3.up+Line, color);
    }

    public void OnCastFreeze(InputAction.CallbackContext context)
    {
        if(delayInput > 0) return;
        OnCancelCastAction.Invoke();
        OnCast.Invoke(MagicEnum.Freeze);
    }

    void UserControls.IPlayerActions.OnCancelCast(InputAction.CallbackContext context)
    {
        if(delayInput > 0) return;
        OnCancelCastAction.Invoke();
    }
}
