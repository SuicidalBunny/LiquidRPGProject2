using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumePuzzle : MonoBehaviour
{
    public Volume volumeS;
    public float volumeHeld;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        VolumeHeld();
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.E) && volumeS.volume >= 0)
        {
            volumeS.volume = volumeS.volume -+ Time.deltaTime;
            volumeHeld = volumeHeld + Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.E) && volumeS.volume !>= 0)
        {
            Debug.Log("Not enough water");
        }
    }

    public void VolumeHeld()
    {
        if (volumeHeld > 5)
        {
            Debug.Log("Full Capacity");
        }
    }
}
