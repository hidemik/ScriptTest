using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss{
	private int hp = 100;
	private int power = 25;
	private int mp = 53;

	public void Attack(){
		Debug.Log (this.power + "のダメージを与えた");
	}

	public void Defence (int damage){
		Debug.Log (damage + "のダメージを受けた");
		this.hp -= damage;
	}
	public void Magic(int c){
		if(this.mp >= c){
			this.mp -= c;
			Debug.Log ("魔法攻撃をした。残りMPは" + this.mp + "。");
			} else {
			Debug.Log("MPが足りないため魔法が使えない。");
			}
	}
	}

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int[] array = { 10, 20, 30, 40, 50 };
		for (int a = 0; a < array.Length; a++) {
			Debug.Log (array [a]);
		}

		for (int b = array.Length -1; b >= 0; b--) {
			Debug.Log (array [b]);
		}

		Boss lastboss = new Boss ();

		lastboss.Attack ();
		lastboss.Defence (3);

		for (int d = 0; d < 10; d++) {
			lastboss.Magic (5);
		}
		lastboss.Magic (5);
	}


	// Update is called once per frame
	void Update () {
		
	}
}
