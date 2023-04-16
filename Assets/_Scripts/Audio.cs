using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    bool toggle = false;
    public void ToggleSound()
    {
        if (toggle)
            AudioListener.volume = 1f;

        else
            AudioListener.volume = 0f;
        toggle = !toggle;
        Debug.Log(toggle);
    }
}
