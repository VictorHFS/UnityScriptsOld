using UnityEngine;
using Cinemachine;

public class AimAssistShootProjectile : ShootProjectile {

    [SerializeField]
    private float AssistRange = 50;

    [SerializeField]
    private float AssistRadius = 10;

    [SerializeField]
    private string TargetTag = "Enemy";

    private bool shoot = false;

    private void OnDrawGizmos() {
        Ray r = Camera.main.ScreenPointToRay(screenCenter());
        Gizmos.DrawRay(r.origin, r.direction * AssistRange);
        Gizmos.DrawRay(Camera.main.transform.position, Camera.main.transform.forward * AssistRange);
    }

    private void LateUpdate() {
        if (shoot) {
            shoot = false;
            Projectile p = Instantiate(prefab);
            p.enabled = true;

            p.gameObject.SetActive(true);

            //raycast from screen center
            Ray r = Camera.main.ScreenPointToRay(screenCenter());
            foreach(RaycastHit hit in Physics.SphereCastAll(r, AssistRadius, AssistRange)) {

                if (hit.collider.gameObject.tag == TargetTag) {
                    Vector3 direction = hit.point - p.transform.position;

                    Debug.DrawRay(p.transform.position, direction, Color.red, 1);
                    p.setDirection(direction.normalized);
                    break;
                }
            }
        }
    }

    public override void Shoot() {
        if (onCoolDown()) return;
        ResetTimer();

        shoot = true;
    }

    private Vector2 screenCenter() {
        return new Vector2(Screen.width/2, Screen.height/2);
    }
}