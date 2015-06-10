using UnityEngine;
using System.Collections;

public class Combatant : MonoBehaviour 
{
    /*  // TODO: Fix variable assignments, otherwise script won't compile - AG 6/10/15
    public GameObject controllerObject;
    
    // Set the name that will appear in combat here. If void appears this wasn't set.
	public string characterName = "void";

    // Whether this is a player character or NPC. NPC is the default.
	public bool controllable = false;

    // How far into the timer this current character is.
	public float timerProgress;

    bool acting = false;

	public float combatantLevel = 1;

	// How often does the combatant attack. 
	public float attackSpeed = 1;

	// this is used to calculate the total HP. It's set as 3 by default. The higher it is, the more exponential will the HP be relative to the level. 
	public float globalStatGrowth = 3;

	//base HP is the base HP the combatant has, HPGrowth is the ammount he gains per level.
	public float baseHP = 1;
	public float HPGrowth = 1;
	public float hitPoints = baseHP + (combatantLevel ^ globalStatGrowth) + (combatantLevel * HPGrowth);
	
	public float baseDefense = 1;
	public float defenseGrowth = 1;
	public float defense = baseDefense + (defenseGrowth * combatantLevel);

	public float baseAttack = 1;
	public float attackGrowth = 1;
	public float damage = baseAttack + (combatantLevel * AttackGrowth )+ (((combatantLevel ^ globalStatGrowth)/16) / (attackSpeed/10);
	public float damageTaken = (other guys attack) * (100/100+defense);	

	public float experience = 0;

	//levelUp



	// Set the character's total timer, in milliseconds. This will be changed to
	// a ratio based on speed at some point in the future. 500 ms is the current default. //[Snow, 6/9/2015]changed to 10000/AttackSpeed ms as default
	// A lower number means a faster character.
	public float timer = 10000/attackSpeed;

    public void DoAction()
    {
        Debug.Log( name + "'s turn to act. Press enter to do something.");
        acting = true;
    }

    void Update ()
    {
        if (acting && Input.GetKeyDown(KeyCode.Return))
        {
            CombatController controller = controllerObject.GetComponent<CombatController>();
            timerProgress = 0;
            acting = false;
            controller.ResumeCombat();
        }
    }
    */
}
