using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
<<<<<<< HEAD:Sample01/Assets/Scripts/1.Sample/PlayerController.cs
    public Score score;
=======
    private Score score;
>>>>>>> aaebf3edf6f0bce0ab647693cf4fa81be9ba7074:Sample01/Assets/Scripts/PlayerController.cs

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speed = 5;
        rb = GetComponent<Rigidbody>();
<<<<<<< HEAD:Sample01/Assets/Scripts/1.Sample/PlayerController.cs
        
=======
        score = GetComponent<Score>();
>>>>>>> aaebf3edf6f0bce0ab647693cf4fa81be9ba7074:Sample01/Assets/Scripts/PlayerController.cs
        //GetComponent<T>() : ���� ������Ʈ�� �پ��ִ� ������Ʈ��
        //�������� ����Դϴ�.
        //T : Type
        Debug.Log("������ �Ϸ�Ǿ����ϴ�!");
    }

    // Update is called once per frame
    void Update()
    {
        //speed += 1;
        //Debug.Log($"�ӵ��� 1 �����մϴ�. ���� �ӵ��� {speed}�Դϴ�.");


        //���� �̵�
        float horizontal = Input.GetAxis("Horizontal");

        //���� �̵�
        float vertical = Input.GetAxis("Vertical");

        //�̵� ��ǥ(����) ����
        Vector3 movement = new Vector3(horizontal, 0, vertical);

        rb.AddForce(movement * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
<<<<<<< HEAD:Sample01/Assets/Scripts/1.Sample/PlayerController.cs


=======
        
        
>>>>>>> aaebf3edf6f0bce0ab647693cf4fa81be9ba7074:Sample01/Assets/Scripts/PlayerController.cs
        //�浹ü�� ���� ������Ʈ�� �±װ� ItemBox���?
        if (other.gameObject.CompareTag("ItemBox"))
        {
            
            Debug.Log("������ ȹ��!");
            //�浹ü�� ���ӿ�����Ʈ�� ��Ȱ��ȭ�մϴ�.
<<<<<<< HEAD:Sample01/Assets/Scripts/1.Sample/PlayerController.cs

            other.gameObject.SetActive(false);
            score.GetComponent<Score>().point += 10;
=======
            
            other.gameObject.SetActive(false);
            
>>>>>>> aaebf3edf6f0bce0ab647693cf4fa81be9ba7074:Sample01/Assets/Scripts/PlayerController.cs

        }





    }



}
