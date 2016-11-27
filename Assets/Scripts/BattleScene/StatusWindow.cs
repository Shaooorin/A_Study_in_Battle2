using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StatusWindow : MonoBehaviour {

	Text stateText;
//	BattlePlayer battlePlayer;
	Enemy enemy;

	void Start () {
		stateText = GameObject.Find("StatusWindow/Text").GetComponent<Text> ();
//		battlePlayer = GameObject.Find ("BattlePlayer").GetComponent<BattlePlayer> ();
		enemy = GameObject.Find ("Enemy").GetComponent<Enemy> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(enemy.enemyHp > 10){
			stateText.color = new Color (255,255,255,255);
			stateText.text = enemy.enemyName + "\n" + " \nHP : " + enemy.enemyHp.ToString() + "\nMP : " + enemy.enemyMp.ToString();
		}else if(enemy.enemyHp < 10){
			stateText.color = new Color (255,0,0,255);
			stateText.text = enemy.enemyName + "\n" + " \nHP : " + enemy.enemyHp.ToString() + "\nMP : " + enemy.enemyMp.ToString();
		}
	}
}
