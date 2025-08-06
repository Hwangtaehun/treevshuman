using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Character : MonoBehaviour
{
    public float speed = 1.0f;
    public GameObject Bullet_prefab;
    GameObject myInstance;
    public Transform firePos;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


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

            myInstance = Instantiate(Bullet_prefab, new Vector3(pos.x, pos.y, (pos.z+1.0f)), Quaternion.identity);


        }
          


    }
}
