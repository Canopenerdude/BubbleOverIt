using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TimeControl : MonoBehaviour
{
    public bool isPaused;

    public GameObject whatDo;
    // Start is called before the first frame update
    void Start()
    {
        isPaused = false;
        whatDo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            PauseUnpause();
        }
    }

    public void PauseUnpause()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            whatDo.SetActive(true);
        }
        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
            whatDo.SetActive(false);
        }
    }

    // public void TimeScale()
    // {
    //    if (isPaused == true)
    //    {
    //        Time.timeScale = 1;
    //    }
    //    else
    //    {
    //        Time.timeScale = 0;
    //    }
    // }
    
    
}
