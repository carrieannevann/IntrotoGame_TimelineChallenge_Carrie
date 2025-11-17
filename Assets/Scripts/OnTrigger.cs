using UnityEngine;
using UnityEngine.Playables;   // for PlayableDirector

public class OnTrigger : MonoBehaviour
{
    // Drag your TimelineController (with PlayableDirector) here in the Inspector
    public PlayableDirector timeline;

    private void OnTriggerEnter(Collider other)
    {
        // Only react to the player
        if (!other.CompareTag("Player"))
            return;

        // Play the timeline when the player enters
        if (timeline != null)
        {
            timeline.Play();
        }
        else
        {
            Debug.LogWarning("Timeline reference not set on OnTrigger script.");
        }
    }
}
