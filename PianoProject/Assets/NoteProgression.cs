using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* HOW A NOTE STREAM TRAVERSES THE SCREEN 
 * A note_stream starts above the top of the screen
 * and travels at a speed dictated by the song's tempo.
 * Once the stream arrives at the piano tile's level,
 * the shrink in size */

// NOTE. The transform.position.x should be assigned based on the note being played

public class NoteProgression : MonoBehaviour {

    // Duration of the note
    public float duration;
    // Tempo - speed of note_stream (m/s) [0.0381 m/s = 1.5 inch/s] ~ 1 quarter beat/sec
    public float speed;

	// Use this for initialization
	void Start () {
        transform.localScale = new Vector3(transform.localScale.x, 4.0f * speed, transform.localScale.z);
        transform.position = new Vector3(transform.position.x, 8.0f * speed + transform.localScale.y / 2.0f + 0.0111125f /* 8 beats offset from tile */, transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.localScale.y <= 0.0f)
        {
            // Finished playing the note. Destroy current note_stream
            Destroy(gameObject);
        }
	}

	// Fixed Update at regular time intervals
	private void FixedUpdate()
	{
        // Note has not been fully played
        if (transform.localScale.y > 0.0f)
        {
            // Ensure note_stream does not pass the piano tiles
            if (transform.position.y - transform.localScale.y / 2.0f <= 0.0111125f /* 7/16 inches (Tile width) */)
            {
                transform.position -= new Vector3(0.0f, speed / 2.0f * Time.deltaTime, 0.0f);
                transform.localScale -= new Vector3(0.0f, speed * Time.deltaTime, 0.0f);
            }
            // Translate note_stream downwards
            else
            {
                transform.position -= new Vector3(0.0f, speed * Time.deltaTime, 0.0f);
            }
        }

	}
}
