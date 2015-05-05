using UnityEngine;
using System.Collections;

public class NoobCaption : MonoBehaviour {
    private Capsule cap = new NoobCapsule();  
	// Use this for initialization
	void Start () {
        Debug.Log("Name: " + cap.CapsuleName);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnGui()
    {
  
    }
}
