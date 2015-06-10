using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GUITimerManager : MonoBehaviour
{
    static public GUITimerManager Instance;

    Text Text_PartyTime;

    public GameObject AttackButton;

    public float curTime = 0f;
    public float maxTime = 100f;
    public float fSpeed = 9f;


	void Awake()
    {
        Instance = this;
        Text_PartyTime = GetComponent<Text>();
        Text_PartyTime.text = curTime.ToString() + " / " + maxTime.ToString();
    }

    void Update()
    {
        curTime += fSpeed * Time.deltaTime;

        if (curTime > 99)
        {
            curTime = 100f;
            AttackButton.SetActive( true );
        }
        else
        {
            AttackButton.SetActive( false );
        }

        Text_PartyTime.text = curTime.ToString() + " / " + maxTime.ToString();
    }
}
