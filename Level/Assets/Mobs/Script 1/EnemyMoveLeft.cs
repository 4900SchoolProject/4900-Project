using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveLeft : MonoBehaviour
{
	public float speed;
	public bool MoveLeft;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
     if(MoveLeft) {
	transform.Translate(-2 * Time.deltaTime * speed, 0,0);
}   
    }
}
