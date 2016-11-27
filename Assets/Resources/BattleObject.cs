using UnityEngine;
using System.Collections;

public class BattleObject : MonoBehaviour {

	protected string objName;
	public int level;
	public int hp;
	public int mp;
	public int strength;
	public int deffence;
	public int agillity;
	public int money;

	/// <summary>
	/// ダメージ計算関数。Mathf.Max((1stPara - 2ndPara),1~5) = return int;
	/// </summary>
	/// <returns>int</returns>
	protected int CulcuratedDamage(int firstDamagePara,int secondDamagePara){
		int minimumA = 1;
		int minimumB = 5;
		int thirdDamagePara = firstDamagePara - secondDamagePara;
		float damageValue = 
			Mathf.Max ((float)thirdDamagePara,Random.Range((float)minimumA,(float)minimumB));
		return (int)damageValue;
	}

	/// <summary>
	/// 攻撃用関数。someoneにculcDamageのダメージを与える。culcDamageにはculcuratedDamage()などの戻り値を推奨。
	/// </summary>
	protected void Attack(BattleObject someone,int culcDamage){
		someone.hp -= culcDamage;
		Debug.Log (someone.objName + " に " + culcDamage + " の ダメージ！");
//		Debug.Log(someone.objName);
		Debug.Log("あああ");
	}

//	protected void hoge(){
//	}
}
