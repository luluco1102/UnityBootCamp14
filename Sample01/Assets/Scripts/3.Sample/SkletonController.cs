using UnityEngine;
//��ư�� Onclick�� ����� ���

/*(��ư �۾�)
OnClick�� ��ư�� ������ �ִ� �̺�Ʈ �������
Ŭ���� ���� ��, ������ ����� �ۼ��ϴ� ��ġ
-��ư�� onClick�� ����� �����մϴ�.
-���� �̵�
-������ �̵�
*/
//    ���� ��ư�� ������ �� ���⿡ �°�
//    �����̵��� �ڵ带 �������ּ���.

//    �̹��� �ٹ̱�� ����(���� ����� Ȱ��)

//    ������ ���õ� ��ũ��Ʈ�� �ۼ��ؼ�
//    �ð��� ���������� ������ �������� �����ϰ�
//    ȭ�鿡�� ��µ� �� �ֵ��� �ڵ带 �����մϴ�.
//    (UI�� Text)
//    ���� ������ �Ǹ� ���� �ӵ��� �� ����������
//    �ڵ带 �������ּ���.

//    ex) ���� 5000�� �� �ӵ� 1����




public class SkletonController : MonoBehaviour
{
    public GameObject skeleton;

    //public void �޼ҵ��()
    //{
    // �� �޼ҵ带 ������ ��� ������ ��ɹ��� �ۼ��ϴ� ��ġ
    //}
    public void OnLButtonEnter()
    {
        skeleton.transform.Translate(1, 0, 0); 

    }
   
    public void OnRButtonEnter()
    {
        skeleton.transform.Translate(-1, 0, 0);
    }
}
