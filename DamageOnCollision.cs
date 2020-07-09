using UnityEngine;

public class DamageOnCollision : MonoBehaviour {
    public float Damage;

    [SerializeField]
    private string targetTag= "Enemy";

    private void OnCollisionEnter(Collision other) {
        HealthController health;
        if (other.gameObject.tag != targetTag) return;
        if (other.collider.gameObject.TryGetComponent<HealthController>(out health)) {
            health.damage(Damage);
        }
    }
}