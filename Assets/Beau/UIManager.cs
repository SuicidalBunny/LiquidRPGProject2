using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    public TMPro.TMP_Text volumeTXT;

    public Volume volumeS;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        volumeTXT.text = volumeS.volume + "L";
    }
}
