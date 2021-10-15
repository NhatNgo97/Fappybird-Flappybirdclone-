using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    [SerializeField] 
    private GameObject pipe;

    private float queuetime = 2.5f;
    private float time  =0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (time > queuetime){
            GameObject.Instantiate(pipe, transform.position + new Vector3(0, Random.Range(0,5),0), transform.rotation);
            time = 0;
        }
        time += Time.deltaTime;
    }
}
