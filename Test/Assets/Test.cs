using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    int a = 1;
    int b = 2;
    int c = 0;
    string name = "hello kim";
    string greeting = "hi";

    int[] array = new int[5];

    int[] points = { 1, 2, 3, 4, 5 }; 
   

    public class Player
    {


        private int hp = 100;
        private int mp = 100; 

        public void Damange(int damage)
        {
            this.hp = this.hp - damage;
            Debug.Log("데미지를 입었다.현재 Hp는" + hp); 

        }

       

    }


    int Hello(int a, int b)
    {

        Debug.Log("This is Hello Function");
        return (a + b); 




    }

    // Start is called before the first frame update
    void Start()
    {
        array[0] = 1;
        array[1] = 3;
        array[2] = 5;
        array[3] = 10;
        array[4] = 12;


        Player myPlayer = new Player();

        myPlayer.Damange(30); 


        for (int i=0; i<5; i++)
        {

            Debug.Log("result A is " + (array[i].ToString()));
            Debug.Log("result B is " + (points[i].ToString()));


        }





        Debug.Log("Hello world");
        c = a + b;

        Debug.Log(c);
        Debug.Log(name);

        string result_string = name + greeting;
        Debug.Log(result_string);


        if (c > 0)
        {
            Debug.Log("C is greater than 0");

        }


        int j = 0; 

        for (int i=0; i<5; i++)
        {
            j++;
            
        }

        Debug.Log(j);

        int k = Hello(a, b); 
        Debug.Log(k); 





    }

    // Update is called once per frame
    void Update()
    {



    }
}
