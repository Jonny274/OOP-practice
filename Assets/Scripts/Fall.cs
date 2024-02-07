using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour
{
    public virtual void OnMouseDown(){
        Destroy(gameObject);
    }
    private void OnCollisionEnter(){
        Destroy(gameObject);
    }
}
