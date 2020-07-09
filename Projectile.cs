using UnityEngine;

public class Projectile : MonoBehaviour {

    [SerializeField]
    private Rigidbody rigidbody;

    [SerializeField]
    private float Speed = 10;

    private Transform playerTransform;

    [SerializeField]
    private float TimeToDisapear = 0.5f;
    private float timer = 0;
    void Awake()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void OnEnable()
    {
        moveTowards(Camera.main.transform.TransformDirection(transform.forward));
        rotateTowards(Camera.main.transform.forward);

        transform.position = playerTransform.position + playerTransform.forward + playerTransform.up;
    }

    void moveTowards(Vector3 direction) {
        rigidbody.velocity = direction.normalized * Speed;
    }
    void rotateTowards(Vector3 direction) {
        float angle = Vector3.Angle(direction , transform.forward);
        transform.rotation *=  Quaternion.Euler(0,angle,0);
    }

    void OnDisable()
    {

        rigidbody.velocity = Vector3.zero;
    }

    void Update()
    {
        if (timer > 0) {
            timer -= Time.deltaTime;
        }

        if (timer < 0) {
            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        timer = TimeToDisapear;
    }

    public void setDirection(Vector3 direction) {
        moveTowards(direction);
    }

}