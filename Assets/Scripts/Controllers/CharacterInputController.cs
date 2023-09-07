using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; //InputValue사용하기 위해 필요/////////////////////////////////////////////////

public class CharacterInputController : GameCharacterController
{
    private Camera _camera;

    public void Awake()
    {
        _camera = Camera.main;
    }

    //코드 다 작성하면 Add Component에서 Player Input추가. Actions에 Controller2D 끌어다놓기. Default scheme도 설정하기///////////////
    public void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
    }
    public void OnLook(InputValue value)
    {
        Vector2 newAim = value.Get<Vector2>();
        Vector2 worldPos = _camera.ScreenToWorldPoint(newAim);
        newAim = (worldPos - (Vector2)transform.position).normalized;

        if (newAim.magnitude >= .9f)
        {
            CallLookEvent(newAim);
        }
    }
    public void OnFire(InputValue value)
    {
        IsAttacking = value.isPressed;
    }
}
