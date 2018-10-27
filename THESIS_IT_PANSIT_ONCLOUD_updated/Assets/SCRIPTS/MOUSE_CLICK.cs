using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOUSE_CLICK : MonoBehaviour {
    public AudioSource SFx;
    public AudioClip clickS;
    
    
    public void clickSound() {
        SFx.PlayOneShot(clickS);
    }

}
