using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Vector2.zero;
    }

    // Update is called once per frame
    void Update()
    {
        //yield return new WaitForSeconds(2);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<Rigidbody>().isKinematic = false; 
    }
}
