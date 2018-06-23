using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public Scrollbar Progress;
    public bool is_progress_done;
    public float time_left;
    public float total_time;

    void Start()
    {
        time_left = 0;
        total_time = 30.0f;
            //Progress = gameObject.AddComponent<Slider>();
            Progress = GameObject.Find("ProgressBar").GetComponent<Scrollbar>();
            Progress.size = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        //Reduce fill amount over 30 seconds
        //fill_progress_bar.fillAmount -= 1.0f / wait_time * Time.deltaTime;

            //Progress = gameObject.AddComponent<Slider>();
            Progress = GameObject.Find("ProgressBar").GetComponent<Scrollbar>();
            Progress.size += 1.0f;
       
    }
}

        

