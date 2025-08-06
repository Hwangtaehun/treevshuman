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
        // 절대 좌표 기준으로 이동
        transform.Translate(Vector3.forward * Time.deltaTime * 10.0f);

        //일정이상 날아가면 없어짐-파괴 code
        if(this.gameObject.transform.position.z  <= -10.0f)
        {
            Destroy(this.gameObject); 
        }
    }



    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(string.Format("{0} 오브젝트가 {1} 와 충돌했습니다.", gameObject.name, other.gameObject.name));
        Destroy(this.gameObject);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log(string.Format("{0} 오브젝트가 {1} 와 떨어졌습니다.", gameObject.name, other.gameObject.name));
    }

}
