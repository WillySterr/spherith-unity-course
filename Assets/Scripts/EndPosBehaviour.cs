using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPosBehaviour : MonoBehaviour
{
    public CanvasGroup winMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Marble")
        {
            winMenu.alpha = 1;
            Time.timeScale = 0;
        }
    }
}
