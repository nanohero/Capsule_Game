using UnityEngine;
using System.Collections;

public class SetCapsule  : MonoBehaviour{
    // Use this for initialization
    Ray ray;
    RaycastHit hit;
    public GameObject prefab;
    public Camera cam;
    LayerMask pan;
    LayerMask sel;

    public NoobCaption nb;
    bool capsuleSelect = false;
    public int health = 10;
    //bool isAttacking = false;
    bool CapsuleFlag=true;
    private Capsule cap = new NoobCapsule();
    private Capsule ninja = new NinjaCapsule();
    public GameTurnSystem gts = new GameTurnSystem();
    void Start()
    {
        //gets masks
        pan = LayerMask.GetMask("panel");
        sel = LayerMask.GetMask("select");
    

    }
    // Update is called once per frame
    void Update()
    {
       
        ray = cam.ScreenPointToRay(Input.mousePosition);
        if(GameTurnSystem.playerTurnStates==GameTurnSystem.ePlayerTurns.PLACEPHASE)
        {
            //Debug.Log("State test");
            capsuleSelect = true;
            CapsuleFlag = true;
            SelectGamePiece();
        }
        
    }
    
  
  public void SelectGamePiece()
    {
        
        if (Input.GetKey(KeyCode.Mouse0))
        {
            //select game piece
            if (CapsuleFlag==true)
            {
                if (Physics.Raycast(ray, out hit, Mathf.Infinity, sel))
                {
                    
                    capsuleSelect = true;

                    string name = hit.collider.name;
                    Debug.Log("You clciked on " + name);
                    prefab = GameObject.Find(name);
                    if (prefab.name=="noob")
                    {
                        Debug.Log("Name: " + cap.CapsuleName);
                        Debug.Log("Name: " + cap.CapsuleName);
                        Debug.Log("Info: " + cap.CapsuleInfo);
                        Debug.Log("Flavor Text: " + cap.CapsuleFlavorText);
                        Debug.Log("Race " + cap.CapsuleRace);
                        Debug.Log("Level " + cap.CapusleLevel.ToString());
                        Debug.Log("Attack " + cap.CapusleAttack.ToString());
                        Debug.Log("Defence " + cap.CapusleDefence.ToString());
                        Debug.Log("Skill Points" + cap.CapusleSkillPoints.ToString());
                    }
                    if (prefab.name=="Ninja")
                    {
                          Debug.Log("Name: " + ninja.CapsuleName);
                        Debug.Log("Name: " + ninja.CapsuleName);
                        Debug.Log("Info: " + ninja.CapsuleInfo);
                        Debug.Log("Flavor Text: " + ninja.CapsuleFlavorText);
                        Debug.Log("Race " + ninja.CapsuleRace);
                        Debug.Log("Level " + ninja.CapusleLevel.ToString());
                        Debug.Log("Attack " + ninja.CapusleAttack.ToString());
                        Debug.Log("Defence " + ninja.CapusleDefence.ToString());
                        Debug.Log("Skill Points" + ninja.CapusleSkillPoints.ToString());
                    }
                }
            }
           
        }
        PlaceGamePiece();
    }

    private void PlaceGamePiece()
    {
        float num=100f;
        if (capsuleSelect == true)
        {
            if (Physics.Raycast(ray, out hit, Mathf.Infinity, pan))
            {
                if (Input.GetKey(KeyCode.Mouse0))
                {
                    Vector3 v= GameObject.Find("Black_01").transform.position;
                    Debug.Log(v);
                   // GameObject obj = Instantiate(prefab, new Vector3(hit.point.x, hit.point.y, hit.point.z), Quaternion.identity) as GameObject;                
                  
                   // Debug.Log("You Placed " + obj.name);
                    //GameObject player = GameObject.FindGameObjectWithTag("Player");
                    Vector3 v2 = prefab.transform.position;
                    
                    prefab.transform.position = Vector3.MoveTowards(v2,hit.point,num);
                    capsuleSelect = false;
                    CapsuleFlag = false;
                    GameTurnSystem.playerTurnStates = GameTurnSystem.ePlayerTurns.PLAYSKILLPHASE;

                }

            }
        }
    }
}
