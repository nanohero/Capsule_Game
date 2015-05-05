using UnityEngine;
using System.Collections;

public class NinjaCapsule : Capsule {

	public NinjaCapsule()
    {
        CapsuleName = "Ninja";
        CapsuleInfo = "Allows player to look at one of your enemies skills";
        CapsuleRace = "Human";
        CapsuleFlavorText = "Always get's lost in buffet";
        CapusleLevel = 1;
        CapusleAttack = 10;
        CapusleDefence = 15;
        CapusleSkillPoints = 20;
    }
	
}
