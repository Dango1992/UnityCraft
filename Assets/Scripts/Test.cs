using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	void Start () {
        ushort msg = (ushort)MsgConst.UpdateScore;

        int s  = (msg >> 8);

        Debug.Log(s);
	}

}
