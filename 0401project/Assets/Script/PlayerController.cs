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
        //���� ��Ȳ�� ���� ó��
        //Debug.Log("test");
        //Debug.LogWarning("This is a warning message!");
        //Debug.LogError("This is an error message!");

        //GameObject => Ŭ������
        //gameObject => Ŭ���� �Ļ���
        //C#���� Vector������ ��� ����Ƽ���� Ŭ���� �߰�

        //�̵�
        //this.gameObject.transform.position += new Vector3(3, 0, 0);
        //this.transform.position += new Vector3(3, 0, 0);

        //ȸ��
        //this.gameObject.transform.rotation = Quaternion.Euler(90.0f, 90.0f, 0.0f);

        //Ȯ��/���
        //transform.localScale = new Vector3(1f, 2f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        //Translate�Լ� ����
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
