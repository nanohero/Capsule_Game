using UnityEngine;
using System.Collections;

public class SetCapsule : MonoBehaviour
{
    // Use this for initialization
    Ray ray;
    RaycastHit hit;
    public GameObject prefab;
    public Camera cam;
    LayerMask pan;
    LayerMask sel;
    LayerMask ene;
    bool capsuleSelect = false;
    public int health = 10;
    bool isAttacking = false;

    void Start()
    {
        //gets masks
        pan = LayerMask.GetMask("panel");
        sel = LayerMask.GetMask("select");
        ene = LayerMask.GetMask("e");
    }

    // Update is called once per frame
    void Update()
    {   
        ray = cam.ScreenPointToRay(Input.mousePosition);
        SelectGamePiece();
        
        
           
            
        
    }

    private void SelectGamePiece()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            //select game piece
            if (Physics.Raycast(ray, out hit, Mathf.Infinity, sel))
            {
                Debug.Log("You clciked on the object");
                capsuleSelect = true;
                Debug.Log(hit.collider.name);
                string name = hit.collider.name;
                prefab = GameObject.Find(name);


            }
        }
        PlaceGamePiece();
    }

    private void PlaceGamePiece()
    {
        if (capsuleSelect == true)
        {
            if (Physics.Raycast(ray, out hit, Mathf.Infinity, pan))
            {
                if (Input.GetKey(KeyCode.Mouse0))
                {

                    GameObject obj = Instantiate(prefab, new Vector3(hit.point.x, hit.point.y, hit.point.z), Quaternion.identity) as GameObject;


                    capsuleSelect = false;
                    Destroy(prefab);
                }

            }
        }
    }
}
