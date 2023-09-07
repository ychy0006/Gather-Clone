using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; //InputValue����ϱ� ���� �ʿ�/////////////////////////////////////////////////

public class CharacterInputController : GameCharacterController
{
    private Camera _camera;

    public void Awake()
    {
        _camera = Camera.main;
    }

    //�ڵ� �� �ۼ��ϸ� Add Component���� Player Input�߰�. Actions�� Controller2D ����ٳ���. Default scheme�� �����ϱ�///////////////
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
