using UnityEngine;
using System.Collections;

public class AttackLogic : MonoBehaviour{
    LayerMask ene;
    Ray ray;
    RaycastHit hit;
    public Camera cam;
    void Start()
    {
        ene = LayerMask.GetMask("e");
    }
    void Update()
    {
        ray = cam.ScreenPointToRay(Input.mousePosition);
        if (GameTurnSystem.playerTurnStates==GameTurnSystem.ePlayerTurns.ATTACKPHASE)
        {
            AttackEnenmy();
            GameTurnSystem.playerTurnStates=GameTurnSystem.ePlayerTurns.ENDPHASE;
        }
    }

    private void AttackEnenmy()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            if (Physics.Raycast(ray,out hit,Mathf.Infinity,ene))
            {
                string name = hit.collider.name;
                GameObject obj = GameObject.Find(name);
                Destroy(obj);
                Debug.Log(name);
                Debug.Log("Enemy took 5 damage");

            }
        }
    }
	

}
