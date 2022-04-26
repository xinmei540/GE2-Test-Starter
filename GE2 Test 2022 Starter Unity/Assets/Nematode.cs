using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nematode : MonoBehaviour
{
    public int length = 5;

    public Material material;

    private float x;

    private float y;

    float ne = 0.2f;

    float body = (int) (length /2);


    public GameObject sphere;

    void Awake()
    {
        // Put your code here!
       for(int i = 0; i < length; i ++)
       {
           GameObject s = GameObject.Instantiate<GameObject>(sphere);
           s.transform.SetParent(thisi.transform);

           if(i < body)
           {
               s.transform.localScale = new Vector3(0.2f * (i + 1), 0.2f * (i + 1), 0.2f * (i + 1));
               s.transform.position = new Vector3((x + s.transform.localScale.x/2), y, 0);
           }
           else
           {
               s.transform.localScale = new Vector3(0.2f * (length - i), 0.2f * (length - i), 0.2f * (length - i));
               s.transform.position = new Vector3((x + s.transform.localScale.x/2), y, 0);
           }

       }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
