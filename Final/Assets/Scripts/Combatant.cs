using UnityEngine;
using System.Collections;

public class Combatant : MonoBehaviour {

    public GameObject controllerObject;

    
    // Set the name that will appear in combat here. If void appears this wasn't set.
	public string characterName = "void";

    // Set the character's total timer, in milliseconds. This will be changed to
        // a ratio based on speed at some point in the future. 500 ms is the current default.
           // A lower number means a faster character.
	public float timer = 500;

    // Whether this is a player character or NPC. NPC is the default.
	public bool controllable = false;

    // How far into the timer this current character is.
	public float timerProgress;

    bool acting = false;

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

}
