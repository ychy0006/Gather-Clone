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
        //회전각도 z 받아오기. 그냥 rotation으로 받아오면 쿼터니언값으로 받아오므로 오일러각으로 받아와야한다.
        //그냥 z까지 받아오면 디그리값이므로 다시 라디안값으로 변환
        //Vector2 Aim = new Vector2(1, Mathf.Tan(rot));
        //Aim = Aim.normalized;
        //이렇게하면 이상하게 오른쪽은 제대로 나가는데 왼쪽은 제대로 안나감...

        _rigidbody.velocity = Quaternion.AngleAxis(90, Vector3.forward) * gameObject.transform.right * speed;
        Destroy(gameObject, 2.0f);
    }
}
