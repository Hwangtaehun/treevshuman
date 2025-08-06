using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private GameObject myInstance;
    public float speed = 1.0f;
    public GameObject Bullet_prefab;
    public Transform firePos;

    // Start is called before the first frame update
    void Start()
    {
        //문제 상황에 따라서 처리
        //Debug.Log("test");
        //Debug.LogWarning("This is a warning message!");
        //Debug.LogError("This is an error message!");

        //GameObject => 클래스명
        //gameObject => 클래스 파생명
        //C#에는 Vector연산이 없어서 유니티에서 클래스 추가

        //이동
        //this.gameObject.transform.position += new Vector3(3, 0, 0);
        //this.transform.position += new Vector3(3, 0, 0);

        //회전
        //this.gameObject.transform.rotation = Quaternion.Euler(90.0f, 90.0f, 0.0f);

        //확대/축소
        //transform.localScale = new Vector3(1f, 2f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        //Translate함수 실행
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //myInstance = Instantiate(Bullet_prefab, new Vector3(0,0,0), Quaternion.identity);
            Vector3 pos = this.gameObject.transform.position;

            myInstance = Instantiate(Bullet_prefab, new Vector3(pos.x, pos.y, pos.z + 1.0f), Quaternion.identity);
        }
    }
}
