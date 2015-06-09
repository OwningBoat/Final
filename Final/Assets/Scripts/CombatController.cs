using UnityEngine;
using System.Collections;

public class CombatController : MonoBehaviour
{
	ArrayList combatantList = new ArrayList();

	public GameObject combatant01;
	public GameObject combatant02;
	public GameObject combatant03;

    bool turnPaused = false;


	void Start ()
    {
		combatantList.Add (combatant01);
		combatantList.Add (combatant02);
		combatantList.Add (combatant03);

		foreach (GameObject combatant in combatantList)
		{
            Combatant unit = combatant.GetComponent<Combatant>();
            unit.timerProgress = Random.Range(0, unit.timer);
		}
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (!turnPaused)
        {
            foreach (GameObject combatant in combatantList)
            {
                Combatant unit = combatant.GetComponent<Combatant>();
                unit.timerProgress += 1000 * Time.deltaTime;
                if (unit.timerProgress >= unit.timer)
                {
                    turnPaused = true;
                    Debug.Log("PAUSE");
                    unit.DoAction();
                }
            }
        }
	}

    public void ResumeCombat()
    {
        turnPaused = false;
    }
}
