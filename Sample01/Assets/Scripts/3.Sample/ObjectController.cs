using UnityEngine;
/*
-���Ϲ��� �÷��̾��� ��ǥ�� ���� ���̸� ����ϰ�,
 �浹 ������ ����ؼ� ó���մϴ�.(rigidbody, collider, trigger ���x)

- ���� �ӵ��� ���ϸ� ����

-���Ϲ��� y���� -2���� �۾�����
����
*/

public class ObjectController : MonoBehaviour
{
    public GameObject player;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.Find("Skeleton");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -0.5f *Time.deltaTime , 0);

        //���Ϲ��� y���� 2���� �۴ٸ� ���Ϲ��� �ı��ϴ� �ڵ�
        if(transform.position.y < -2)
        {
            Destroy(gameObject);
        }
        
        //�浹 ���� ó��
        //���� ���� �浹 ���� ���� ���
        Vector3 v1 = transform.position; //���Ϲ� ��ǥ
        Vector3 v2 = player.transform.position; //�÷��̾� ��ǥ

        Vector3 dir = v1- v2; // v1�� v2 ������ ��ġ 

        float d = dir.magnitude; //������ ũ�� �Ǵ� ���̸� �ǹ��մϴ�.(�� �� ������ �Ÿ��� ����� �� ����մϴ�.)

        float obj_r1 = 0.5f;
        float obj_r2 = 1.0f;

        //�� �� ������ �Ÿ��� d�� ���� ������ �������� �պ��� ũ�ٸ� �浹���� ���� ��Ȳ
        if (d < obj_r1 + obj_r2)
        {
            Destroy(gameObject);          
        }
    }
}
