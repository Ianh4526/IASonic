using System.Collections;
using System.Collections.Generic;
using SonicRealms.Core.Actors;
using SonicRealms.Core.Utils;
using UnityEngine;
using SonicRealms.Core.Moves;

public class VarAuto : MonoBehaviour {

    #region Control
    /// <summary>
    /// The direction of the movement 1 or -1.
    /// </summary>
    [ControlFoldout]
    [Tooltip("The direcation of the movement.")]
    public float AutoMovementAxis;
    #endregion

    public static float VarAutoMov;
    

    // Use this for initialization
    void Start () {
        VarAutoMov = AutoMovementAxis;
    }
	
	// Update is called once per frame
	void Update () {

}
}
