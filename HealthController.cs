using UnityEngine;

class HealthController : MonoBehaviour
{
    public float maxHealth = 100;
    public event System.Action OnDeath;
    public event System.Action OnDamage;
    private float currHealth;

    private void Start()
    {
        currHealth = maxHealth;
    }

    public void damage(float damage)
    {
        this.currHealth -= damage;
        if (OnDamage != null) {
            this.OnDamage.Invoke();
        }
        if (currHealth <= 0 && this.OnDeath != null)
        {
            this.OnDeath.Invoke();
        }
    }
}