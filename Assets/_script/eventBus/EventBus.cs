using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering;

public class EventBus
{
    private static readonly IDictionary<EventEnum, UnityEvent> Events = new Dictionary<EventEnum,UnityEvent>();

    public static void Subscribe(EventEnum eventName, UnityAction listener)
    {
        UnityEvent unityEvent;
        if (Events.TryGetValue(eventName, out unityEvent))
        {
            unityEvent.AddListener(listener);
        }
        else
        {
            unityEvent = new UnityEvent();
            unityEvent.AddListener(listener);
            Events.Add(eventName, unityEvent);
        }
    }

    public static void Unsubscribe(EventEnum eventName, UnityAction listener) 
    {
        UnityEvent unityEvent;
        if(Events.TryGetValue(eventName, out unityEvent))
        {
            unityEvent.RemoveListener(listener);
        }
    }

    public static void InvokeEvent(EventEnum eventName)
    {
        UnityEvent unityEvent;
        if (Events.TryGetValue(eventName, out unityEvent)) 
        {
            unityEvent.Invoke();
        }

    }



}

