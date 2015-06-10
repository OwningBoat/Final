using UnityEngine;
using System.Collections;

public class GUIAttackManager : MonoBehaviour
{
    public GameObject Timer;

    public void AttackClicked(int intMember)
    {
        // TODO: Create DoAttack() method in CombatController.cs
        //DoAttack( intMember );
        Debug.Log( "Character " + intMember.ToString() + " DoAttack()" );
        //Timer = Timer.GetComponent<GUITimerManager>;
        //GetComponent<GUITimerManager>
    }
}
