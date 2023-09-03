using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public GameObject ball;
    public GameObject dog;
    public float xMax = 10;
    private Vector3 pos = new Vector3();
    private int i=1;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("RandomPosSpawner",2,1);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&& i>0)
        {
            Instantiate(dog, transform.position,transform.rotation);
            i--;
        }
    }

    void RandomPosSpawner(){
        pos = new Vector3(Random.Range(-xMax,xMax),10,10);
        Instantiate(ball, pos, transform.rotation);
        i++;
    }
}
