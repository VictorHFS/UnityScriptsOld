using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class FreezeSkill : MonoBehaviour
{
    public float AreaRadius = 2;
    public float SkillDamage = 10;

    [SerializeField]
    private float FreezeCoolDown;
    private float currFreezeCoolDown;

    [SerializeField]
    private VisualEffectActivation EffectActivation;
    private Player player;
    private Vector3 hidenPosition;
    private bool targeting;
    private Camera mainCamera;
    private Collider _col;
    private float timeToDamage =1f;
    private float currTimeToDamage = 0;

    private UserControls controls;


    private void Awake() {
        controls = new UserControls();
    }
    void Start()
    {
        hidenPosition = this.transform.position;
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        player.OnCast += startTargeting;
        player.OnCancelCastAction += cancelCast;
        mainCamera = Camera.main;
        _col = GetComponent<Collider>();
    }

    void Update()
    {
        // updateTimers();
        // if (targeting)
        // {
        //     updateTargetPosition();
        //     checkInput();
        // }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(this.transform.position, AreaRadius);
    }

    private void checkInput()
    {
        if (Mouse.current.leftButton.isPressed)
        {
          Vector3 position = this.transform.position;
          RaycastHit[] hits = Physics.SphereCastAll(new Ray(this.transform.position, Vector3.down), AreaRadius);
            foreach(RaycastHit hit in hits)
            {
                damage(hit.collider.gameObject.GetComponent<HealthController>());
                currTimeToDamage = 0;
                hide();
            }
            currTimeToDamage = timeToDamage;
            hide();
         
            currFreezeCoolDown = FreezeCoolDown;
         
            if (EffectActivation) {
                EffectActivation.Activate(position);
            }
        }
    }

    private void updateTimers()
    {
        if (currTimeToDamage > 0)
        {
            currTimeToDamage -= Time.deltaTime;
            currTimeToDamage = Mathf.Clamp(currTimeToDamage, 0, timeToDamage);
        }
        if (currFreezeCoolDown > 0) 
        {
            currFreezeCoolDown -= Time.deltaTime;
            currFreezeCoolDown = Mathf.Clamp(currFreezeCoolDown, 0, FreezeCoolDown);
        }
    }

    private void updateTargetPosition()
    {
        Ray mouseRay = mainCamera.ScreenPointToRay(new Vector2(Screen.width/2, Screen.height/2));
        RaycastHit[] hits = Physics.RaycastAll(mouseRay);
        foreach(RaycastHit hit in hits) {
            if (hit.collider.gameObject.tag != "Character")
            {
                if (hit.transform.gameObject != this.gameObject)
                {
                    this.transform.position = atZero(hit.point);
                    break;
                }
            }
        }
    }

    Vector3 atZero(Vector3 vector)
    {
        return new Vector3(vector.x, 0, vector.z);
    }

    Vector3 atZ(Vector3 vector, float z)
    {
        return new Vector3(vector.x, vector.y, z);
    }

    void startTargeting(MagicEnum magic) 
    {
        if (MagicEnum.Freeze.Equals(magic)) 
        {
            targeting = true;
        }
    }
    void cancelCast()
    {
        hide();
        targeting = false;
    }

    private void hide()
    {
        this.transform.position = this.hidenPosition;
        targeting = false;
    }

    void damage(HealthController controller)
    {
        if (controller)
            controller.damage(SkillDamage);
    }
}
