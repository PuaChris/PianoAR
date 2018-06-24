using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Play : MonoBehaviour {

    public Button play_button;
        
    // Use this for initialization
	void Start () {
        play_button = GameObject.Find("Play").GetComponent<Button>();
        play_button.onClick.AddListener(PlaySong);
    }

    // Update is called once per frame
    void Update () {
        play_button = GameObject.Find("Play").GetComponent<Button>();
    }

    void PlaySong()
    {
        Debug.Log("You have clicked the button!");
    }
}
