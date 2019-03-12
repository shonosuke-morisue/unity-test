using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player {
	
	private int hp = 100;
	private int power = 50;

	public void Attack(){
		//Debug.Log(this.power + "のダメージを与えた");
	}
	public void Damage(int damage){
		this.hp -= damage;
		//Debug.Log(damage + "のダメージを受けた");
	}
}



public class Test : MonoBehaviour {

	Vector3 PlayerPos = new Vector3(3.0f, 4.0f, 2.0f);

	// Use this for initialization
	void Start () {
        int[] points = { 2, 10, 5, 15, 3 };

        for (int i = 0; i < 5; i++)
        {
            //Debug.Log("point[" + i + "]:" + points[i]);
        }

        Player myPlayer = new Player();
		myPlayer.Attack();
		myPlayer.Damage(30);

		PlayerPos.x += 8.0f;
		PlayerPos.y += 5.0f;
		PlayerPos.z += 1.0f;
		//Debug.Log(PlayerPos);

	}



    // Update is called once per frame
    //void Update()
    //{
    //    PlayerPos.x += 8.0f;
    //    PlayerPos.y += 5.0f;
    //    PlayerPos.z += 1.0f;
    //    Debug.Log("PlayerPos.x = " + PlayerPos.x);
    //    Debug.Log("PlayerPos.y = " + PlayerPos.y);
    //    Debug.Log("PlayerPos.z = " + PlayerPos.z);
    //}
}
