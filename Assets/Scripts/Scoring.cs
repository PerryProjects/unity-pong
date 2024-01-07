using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class Scoring : MonoBehaviour
{
    public EventTrigger.TriggerEvent scoreTrigger;
    public void OnCollisionEnter2D(Collision2D collision) {
        var ball = collision.gameObject.GetComponent<Ball>();

        if (ball != null) {
            var eventData = new BaseEventData(EventSystem.current);
            scoreTrigger.Invoke(eventData);
        }
    }
}
