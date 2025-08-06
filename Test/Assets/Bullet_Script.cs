using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
 

    }

    // Update is called once per frame
    void Update()
    {

        // 게임 오브젝트 기준으로 이동
        //transform.Translate(Vector3.right * Time.deltaTime);

        // 절대 좌표 기준으로 이동
        transform.Translate(Vector3.forward * Time.deltaTime * 2.0f);

        if (this.gameObject.transform.position.z >= 20.0f)
        {
            Destroy(this.gameObject);

        }


    }
}
