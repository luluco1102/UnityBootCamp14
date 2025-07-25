using UnityEngine;
//����Ƽ���� �����Ǵ� Ŭ���� ����� ��ũ��Ʈ�� �ۼ��մϴ�.

//1. ����Ƽ�� Transform Ŭ���� ���
//Ʈ�������� ����Ƽ �����Ϳ��� ���� ������Ʈ�� ������ ��, ��� ���� ������Ʈ�� �⺻������
//�ο��Ǵ� ������Ʈ�� �ǹ��մϴ�.

//�ش� ������Ʈ�� ��ġ(Position), ȸ��(Rotation), ũ��(Scale)�� ���� ������ ������ �ֽ��ϴ�.
//������Ʈ�� ����� ȣ���ϴ� GetComponent<T>�� ������� �ʰ� �ٷ� ����� �����մϴ�.

//�ش� Ŭ������ �������ִ� �ֿ� �Ӽ�(Property)
//transform.position --> ���� ������Ʈ�� ��ġ ������ �ǹ��մϴ�.
//Vector3 ������ ������, x,y,z���� ���� float

//transform.rotation --> ���� ������Ʈ�� ȸ�� ������ �ǹ��մϴ�.
//Quaternion ������ ������, x,y,z,w ���� float

//transform.forward --> ���� ������Ʈ ������ ������ ��Ÿ���� ��

//transform.up --> ���� ������Ʈ �������� ����� ��Ÿ���� ��

//transform.right --> ���� ������Ʈ �������� �������� ��Ÿ���� ��

//transform.eulerAngles --> ���� ������Ʈ�� ȸ�� ������ �ǹ��մϴ�.
//Vector3 ������ ������ x,y,z ���� float

//�ش� Ŭ������ �������ִ� �ֿ� ����(�޼ҵ�)
//transform.LookAt(Transform target)
//������Ʈ�� �־��� Ÿ���� ���ϵ��� ���� ������Ʈ�� ȸ����Ű�� ���
//transform.Rotate(Vector3 eulerAngles)
//���޹��� ������ �������� ���� ������Ʈ�� ȸ����Ű�� ���
//transform.Translate(Vector3 translate)
//�־��� ����ŭ ���� ������Ʈ�� �̵���Ű�� ���



public class Sample3 : MonoBehaviour
{
    //transform�� �̿��� ������Ʈ�� ������Ʈ ����
    public GameObject go;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(go.transform.GetComponent<Sample4>().value);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
