using System.Collections;
using System.Collections.Generic;
using SonicRealms.Core.Actors;
using SonicRealms.Core.Utils;
using UnityEngine;
using SonicRealms.Core.Moves;

public class VarAuto : MonoBehaviour {

    #region Control
    /// <summary>
    /// The direction of the movement Ground 1 or -1.
    /// </summary>
    [ControlFoldout]
    [Tooltip("The direcation of the movement on the Ground.")]
    public float AutoMovementAxisG;

    /// <summary>
    /// For jumping true or false.
    /// </summary>
    [ControlFoldout]
    [Tooltip("For the Jump.")]
    public bool AutoJumping;

    /// <summary>
    /// The direction of the movement in air 1 or -1.
    /// </summary>
    [ControlFoldout]
    [Tooltip("The direcation of the movement on the air.")]
    public float AutoMovementAxisA;

    /// <summary>
    /// For jumping true or false.
    /// </summary>
    [ControlFoldout]
    [Tooltip("For the Jump.")]
    public bool AutoLookUp;

    /// <summary>
    /// For Ducking.
    /// </summary>
    [ControlFoldout]
    [Tooltip("For the Duck")]
    public bool AutoDucking;

    /// <summary>
    /// For Rolling.
    /// </summary>
    [ControlFoldout]
    [Tooltip("For the Roll")]
    public bool AutoRolling;

    /// <summary>
    /// For Dashing.
    /// </summary>
    [ControlFoldout]
    [Tooltip("For the Dash")]
    public bool AutoDashing;

    #endregion



    public static float VarAutoMovG;
    public static bool AutoJump;
    public static float VarAutoMovA;
    public static bool AutoUp;
    public static bool AutoDuck;
    public static bool AutoRoll;
    public static bool AutoDash;

    // Use this for initialization
    void Start () {
        VarAutoMovG = AutoMovementAxisG;
        AutoJump = AutoJumping;
        VarAutoMovA = AutoMovementAxisA;
        AutoUp = AutoLookUp;
        AutoDuck = AutoDucking;
        AutoRoll = AutoRolling;
        AutoDash = AutoDashing;
    }
	
	// Update is called once per frame
	void Update () {

}
}
