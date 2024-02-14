using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    Button TitleButton = null;
    // Start is called before the first frame update
    void Start()
    {
        transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().color = new Color32(255, 255, 255, 255);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
