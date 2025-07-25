using UnityEngine;

public class CameraController : MonoBehaviour
{
    //���ӿ�����Ʈ Ÿ�� ���� player(����)
    public GameObject player;

    //ī�޶�� �÷��̾� ������ ���� offset(Vector3 : �����)
    private Vector3 offset;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //ī�޶�� �÷��̾��� �Ÿ� ���̸� offset�� ������ �����մϴ�.

        offset = transform.position - player.transform.position;

    }

    // Update is called once per frame
    void Update()
    {

    }
    //Update()���� ó���� �κ��� �� ó���� �Ŀ� ȣ��Ǵ� ��ġ
    //ī�޶� �۾����� ���� ���ȴ�.(������Ʈ ������ ������ ���)
    private void LateUpdate()
    {
        //ī�޶��� ��ġ�� �÷��̾���� ���� �Ÿ��� �����Ѵ�.(offset)
        transform.position = player.transform.position + offset;
    }


}
