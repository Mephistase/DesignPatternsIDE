using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityReceiver : MonoBehaviour
{
    protected bool _ready = false;
    // Start is called before the first frame update
    void Start()
    {
        StartListening();
    }
    protected void StartListening()
    {
        EventBus.Subscribe(EventEnum.Active, SpellActive);
        EventBus.Subscribe(EventEnum.Inactive, SpellInactive);
        EventBus.Subscribe(EventEnum.Spell, ReceiveSpell);
    }

    protected void StopListening() 
    {
        EventBus.Unsubscribe(EventEnum.Active, SpellActive);
        EventBus.Unsubscribe(EventEnum.Inactive, SpellInactive);
        EventBus.Subscribe(EventEnum.Spell, ReceiveSpell);
    }

    public virtual void SpellActive()
    {
        _ready = true;
    }

    public virtual void SpellInactive()
    {
        _ready = false;
    }

    public virtual void ReceiveSpell()
    {

    }

    private void OnDestroy()
    {
        StopListening();
    }
    private void FixedUpdate()
    {
        Vector3 position = transform.position;
        position.x += Random.Range(-5.0f, 5.0f) * Time.deltaTime;
        position.y += Random.Range(-5.0f, 5.0f) * Time.deltaTime;
        position.z += Random.Range(-5.0f, 5.0f) * Time.deltaTime;
        if (position.x >= 5.0f) position.x = 5.0f;
        if (position.x <= -5.0f) position.x = -5.0f;
        if (position.y >= 5.0f) position.y = 5.0f;
        if (position.y <= -5.0f) position.y = -5.0f;
        if (position.z >= 5.0f) position.z = 5.0f;
        if (position.z <= -5.0f) position.z = -5.0f;
        transform.position = position;
    }
}
