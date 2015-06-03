using UnityEngine;
using System.Collections;

public class CombatController : MonoBehaviour {
	ArrayList combatantList = new ArrayList();

	public GameObject combatant01;
	public GameObject combatant02;
	public GameObject combatant03;


	void Start () {
		combatantList.Add (combatant01);
		combatantList.Add (combatant02);
		combatantList.Add (combatant03);

		foreach (GameObject combatant in combatantList)
		{

		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
