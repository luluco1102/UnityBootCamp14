using System;
using System.Globalization;
using UnityEngine;
//  ����Ƽ �ν����Ϳ��� ������ ���� ǥ���� Ȯ���ϴ� �ڵ�

public enum TYPE
{
  ��,��,Ǯ
}


//���� ���� �����ϴ� ���(flag)
//���� 2�� ���� ���� ǥ���� �� �ֽ��ϴ�.
//2�� �������� ��Ʈ �������� ǥ���ϱⰡ �����ϴ� n << 1 �̸� n�� ����, n << 2�� n�� 2����
[Flags]
public enum TYPE2
{
    �� = 1 << 0,
    ��Ʈ =1 << 1, //1���� 1ĭ �̵��ϰڽ��ϴ�.(��Ʈ ����) 01 << 1 = 10
    �巡�� = 1 << 2, // 01 << 2 = 100
    ���� = 1 <<3
}


public class Variable : MonoBehaviour
{
    //������ �տ� u�� ������ ����� ǥ���ϴ� ���� �ǹ��մϴ�.
    //ex) int�� ǥ�� ������ -2147483648 ~ 2147483647 ���� ǥ���� �����մϴ�.
    //ex) uint�� ����� ����� 0 ~ 4294967295

    //null�� "���� ����"�� ��Ÿ���� ��(0�̳� empty�� �ٸ� ����)

    //����Ƽ���� ���� ���Ǵ� C# �⺻ ������ Ÿ��(primitive)
    //����(int) 
    //�Ǽ�(float)
    //��(bool)
    //���ڿ�(string)
    //�� �� ���(nullable) : �ڷ���?�� �ۼ��ϸ� �ش� ���� null�� ����� �� ����.


    public int Integer;
    public float Float;
    public string Sentence;
    public TYPE type;
    public bool isDead;
    public TYPE2 type2;
}
