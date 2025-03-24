using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public float Timer = 1.0f;
    public GameObject EnemyObject;

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime; 

        if (Timer <= 0)                     //만약 Timer 의 수치가 0이하로 내려갈 경우(1초마다 동작되는 행동을 만들때)
        {
            Timer = 1;                         //다시 1초로 타이머를 초기화 시켜준다.
          
            GameObject Temp = Instantiate (EnemyObject);
            Temp.transform.position = new Vector3(Random.Range(-8, 8), Random.Range(-4, 4), 0);
        }


        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider != null)
                {
                   Debug.Log($"hit : {hit.collider.name}");
                   hit.collider.gameObject.GetComponent<Enemy>().CharacterHit(30);  
                }
            }
        }
    }
}
