using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public Rigidbody2D _rigidbody;
    float speed = 10f;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        Shoot();
    }
    private void Shoot()
    {
        //float rot = (gameObject.transform.rotation.eulerAngles.z + 90) * Mathf.Deg2Rad;
        //ȸ������ z �޾ƿ���. �׳� rotation���� �޾ƿ��� ���ʹϾ����� �޾ƿ��Ƿ� ���Ϸ������� �޾ƿ;��Ѵ�.
        //�׳� z���� �޾ƿ��� ��׸����̹Ƿ� �ٽ� ���Ȱ����� ��ȯ
        //Vector2 Aim = new Vector2(1, Mathf.Tan(rot));
        //Aim = Aim.normalized;
        //�̷����ϸ� �̻��ϰ� �������� ����� �����µ� ������ ����� �ȳ���...

        _rigidbody.velocity = Quaternion.AngleAxis(90, Vector3.forward) * gameObject.transform.right * speed;
        Destroy(gameObject, 2.0f);
    }
}
