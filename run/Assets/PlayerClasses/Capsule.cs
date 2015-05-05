using UnityEngine;
using System.Collections;

public class Capsule  {
    
    private string capsuleName;
    private string capsuleInfo;
    private string capsuleRace;
    private string capsuleFlavorText;
    private int capsuleLevel;
    private int capsuleAttack;
    private int CapsuleDefence;
    private int capsuleSkillPoints;

    public string CapsuleName
    {
        get { return capsuleName; }
        set { capsuleName = value; }
    }
    public string CapsuleInfo
    {
        get { return capsuleInfo; } 
        set { capsuleInfo = value;}
    }
    public string  CapsuleRace
    {
        get { return capsuleRace; }
        set { capsuleRace = value; }
    }
    public string CapsuleFlavorText
    {
        get { return capsuleFlavorText; }
        set { capsuleFlavorText = value; }
    }
    public int CapusleLevel
    {
        get { return capsuleLevel; }
        set { capsuleLevel = value; }
    }
    public int CapusleAttack
    {
        get { return capsuleAttack; }
        set { capsuleAttack  = value; }
    }
    public int CapusleDefence
    {
        get { return CapsuleDefence; }
        set { CapsuleDefence = value; }
    }
    public int CapusleSkillPoints
    {
        get { return capsuleSkillPoints; }
        set { capsuleSkillPoints = value; }
    }

}
