using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.transform.rotation  = Quaternion.Euler(0.0f, 180.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        // ���� ��ǥ �������� �̵�
        transform.Translate(Vector3.forward * Time.deltaTime * 10.0f);

        //�����̻� ���ư��� ������-�ı� code
        if(this.gameObject.transform.position.z  <= -10.0f)
        {
            Destroy(this.gameObject); 
        }
    }



    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(string.Format("{0} ������Ʈ�� {1} �� �浹�߽��ϴ�.", gameObject.name, other.gameObject.name));
        Destroy(this.gameObject);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log(string.Format("{0} ������Ʈ�� {1} �� ���������ϴ�.", gameObject.name, other.gameObject.name));
    }

}
