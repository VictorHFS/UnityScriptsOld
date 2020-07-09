using UnityEngine;

public class ShootProjectile : MonoBehaviour {

    [SerializeField]
    protected Projectile prefab;

    [SerializeField]
    private float CoolDown = 1;

    private float timer = 0;

    public bool Timeout(){
        return timer <= 0;
    }
    public bool onCoolDown(){
        return timer > 0;
    }

    public void ResetTimer(){
        timer = CoolDown;
    }

    protected void Update()
    {
        if (onCoolDown()) {
            timer = Mathf.Clamp(timer - Time.deltaTime, 0, CoolDown);
        }
    }

    public virtual void Shoot() {
        if (onCoolDown()) return;
        ResetTimer();
        Projectile p = Instantiate(prefab);
        p.gameObject.SetActive(true);
    }
}