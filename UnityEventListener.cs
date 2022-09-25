using System.Collections.Generic;
using UnityEngine.Events;
using System;
using UnityEngine;

public class UnityEventListener : MonoBehaviour
{
    private List<Tuple<UnityEvent, UnityAction>> eventActionPairs = new List<Tuple<UnityEvent, UnityAction>>();

    protected void RegisterToEvent(UnityEvent i_Event, UnityAction i_Action)
    {
        i_Event.AddListener(i_Action); // Register the action to the event
        eventActionPairs.Add(new Tuple<UnityEvent, UnityAction>(i_Event, i_Action)); // Add the event and action as a new pair to the list

        Debug.Log(name + " registered the response " + i_Action.Method.Name);
    }

    protected virtual void OnDisable()
    {
        foreach (Tuple<UnityEvent, UnityAction> pair in eventActionPairs)
        {
            pair.Item1.RemoveListener(pair.Item2); // Unregister every action from its corresponding event.

            Debug.Log(name + " unregistered the response " + pair.Item2.Method.Name);
        }

        eventActionPairs.Clear(); // Clear the pairs list
    }
}
