using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_UsableItem : MonoBehaviour
{

    public int Index_Connect;

    // 1 = Red
    // 2 = Blue
    // 3 = Green
    // 4 = Magenta
    // 5 = Pied de biche
    // 6 = Key

    public void AttachItem()
    {
        gameObject.tag = "Untagged";
        GetComponent<Rigidbody>().isKinematic = true;
    }

}
