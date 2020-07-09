using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputHandler : MonoBehaviour
{
    public Text CoolDownText;
    public Text ModeText;
    public event System.Action<Vector3> onMove;
    public event System.Action<MagicEnum> onSelectMagic;
    public event System.Action<Vector3> onMouseMove;
    public event System.Action<float> onSlowDown;
    private MagicEnum selectedMode = MagicEnum.None;

    private void Start()
    {
        Cursor.visible = false;
        onSelectMagic += updateSelectedMode;
    }

    void Update()
    {
        checkMouse();
        checkMove();
        checkMagic();
    }

    void updateSelectedMode(MagicEnum m)
    {
        selectedMode = m;
        ModeText.text = m.ToString();
        if (onSlowDown != null)
            if (m != MagicEnum.None) {
                onSlowDown.Invoke(0.2f);
            } else {
                onSlowDown.Invoke(1f);
            }
    }

    private void checkMouse()
    {
        if (this.onMouseMove == null)
        {
            return;
        }
        // Vector3 mouseInput = new Vector3(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        // if (mouseInput != Vector3.zero)
        // {
        //     this.onMouseMove.Invoke(mouseInput);
        // }
    }

    private void checkMagic()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            onSelectMagic.Invoke(MagicEnum.Freeze);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            onSelectMagic.Invoke(MagicEnum.Push);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            onSelectMagic.Invoke(MagicEnum.Damage);
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            onSelectMagic.Invoke(MagicEnum.None);
        }
    }

    private void checkMove()
    {
        Vector3 moveInput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        this.onMove.Invoke(moveInput);
    }

    public void resetMagic()
    {
        onSelectMagic.Invoke(MagicEnum.None);
    }
}
