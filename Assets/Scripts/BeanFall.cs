using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bean : Fall
{
    private int count = 0;
    // Update is called once per frame
    private void Update()
    {
        Vector3 spin;
        spin = new Vector3(1,0,0);
        transform.Rotate(spin);
    }
    public override void OnMouseDown(){
        if(count == 0){
            count++;
        } else {
        Destroy(gameObject);
    }}
}
