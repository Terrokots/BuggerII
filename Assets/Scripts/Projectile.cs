using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public GameObject Bullet;
    public float xForce;
    public float yForce;
    public float zForce = 100f;
 
    void Update()
    {
        /*�������� �� ����������� ������ ��� ������ �������
        GetButtonDown ���������� �� ButtonDown, �� ����� ����������� �� ����������������
        ����� ������ ����� ��������� �� ������� � ����� ������*/
        if(Input.GetButtonDown("Fire1"))
        {
            GameObject LaunchedProjectile = Instantiate(Bullet, transform.position, transform.rotation);
            LaunchedProjectile.GetComponent<Rigidbody>().AddRelativeForce(xForce, yForce, zForce);
        }

    }

}
