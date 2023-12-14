using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sumonFood : MonoBehaviour
{
    public Transform SpTr;
    public GameObject PvFood;
    float cdTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            var Food = Instantiate(PvFood, SpTr.position, SpTr.rotation);
            Food.GetComponent<Rigidbody>().velocity = new Vector3(0,0,1); 
        }
        
    }
}
