using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameTurnSystem : MonoBehaviour {

	// Use this for initialization
    public static ePlayerTurns playerTurnStates;
    public DrawCardLogic drawCardScript = new DrawCardLogic();
    public PlaySkillLogic psl = new PlaySkillLogic();
    
    public Text text2;
    //public SetCapsule capsuleScript = new SetCapsule();
	void Start () {
        playerTurnStates = ePlayerTurns.DRAWPHASE;
        text2 =GetComponent<Text>();
        text2.text = playerTurnStates.ToString();
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(playerTurnStates);
        text2.text = "Current Phase:" + playerTurnStates.ToString();
        /*
     
         * */
	}
    public enum ePlayerTurns
    {
        DRAWPHASE,
        PLACEPHASE,
        PLAYSKILLPHASE,
        ATTACKPHASE,
        ENDPHASE
    }
    public void GamePhaseUI()
    {
        
        switch (playerTurnStates)
        {

            case (ePlayerTurns.DRAWPHASE):
                drawCardScript.DrawCard();
                playerTurnStates = ePlayerTurns.PLACEPHASE;
                break;
            //case (ePlayerTurns.PLACEPHASE):
                //break;
            case (ePlayerTurns.PLAYSKILLPHASE):
                psl.PlaySkill();
                playerTurnStates = ePlayerTurns.ATTACKPHASE;
                break;
            case (ePlayerTurns.ATTACKPHASE):
                //playerTurnStates = ePlayerTurns.ENDPHASE;
                break;
            case (ePlayerTurns.ENDPHASE):
                playerTurnStates = ePlayerTurns.DRAWPHASE;
                break;
        }
        text2.text = "Current Phase:"+playerTurnStates.ToString();
    }
}
