using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int Health = 100;      //ü���� ���� �Ѵ�. (����)
    public float Timer = 1.0f;    //Ÿ�̸� ������ ���� �Ѵ�.
    public int AttackPoint = 50;    //���ݷ� ����

    //���� �������� ������Ʈ �Ǳ� �� �ѹ� ���� �ȴ�.
    // Start is called before the first frame update
    void Start()
    {
        Health = 100;            //�� ��ũ��Ʈ�� ���� �� �� 100�� �� �÷��ش�.
        
    }

    //���� �������� �� ������ ���� ȣ��ȴ�. 
    // Update is called once per frame
    void Update()
    {
        CharacterHealthUP(); 

        if(Input.GetKeyDown(KeyCode.Space))        //�����̽� �ٸ� ������ ��
        {
            Health -= AttackPoint;                  //ü�� ����Ʈ�� ���� ����Ʈ ��ŭ ���ҽ��� �ش�. (Health = Health - AttackPoint
        }
        CheckDeath();


    }

    public void CharacterHit(int Damage)                     //�������� �޴� �Լ��� �����Ѵ�.
    { 
        Health -= Damage;                             //���� ���ݷ¿� ���� ü���� ���ҽ�Ų��.
    }
    void CheckDeath()                                 //ü���� �˻��ϴ� �Լ��� ����
    {
        if (Health <= 0)                               //ü���� 0������ ���
        { 
            Destroy(gameObject) ;                      //�� ������Ʈ�� �ı� ��Ų��.
        }

        
    }
    void CharacterHealthUP()
    {
        Timer -= Time.deltaTime;         //�ð��� �� �����Ӹ��� ���� ��Ų��. (deltaTime ������ ������ �ð��� �ǹ��Ѵ�.)

        if (Timer <= 0)                     //���� Timer �� ��ġ�� 0���Ϸ� ������ ���(1�ʸ��� ���۵Ǵ� �ൿ�� ���鶧)
        {
            Timer = 1;                         //�ٽ� 1�ʷ� Ÿ�̸Ӹ� �ʱ�ȭ �����ش�.
            Health += 10;                      //1�ʸ��� ü���� 10 �÷��ش�.            
        }
    }
    

}


