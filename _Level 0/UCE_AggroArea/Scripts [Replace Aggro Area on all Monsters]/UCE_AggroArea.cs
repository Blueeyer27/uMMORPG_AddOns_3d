// =======================================================================================
// Created and maintained by iMMO
// Usable for both personal and commercial projects, but no sharing or re-sale
// * Discord Support Server.............: https://discord.gg/YkMbDHs
// * Public downloads website...........: https://www.indie-mmo.net
// * Pledge on Patreon for VIP AddOns...: https://www.patreon.com/IndieMMO
// * Instructions.......................: https://indie-mmo.net/knowledge-base/
// =======================================================================================
using UnityEngine;
using UnityEngine.AI;

// AGGRO AREA

[RequireComponent(typeof(SphereCollider))]
public partial class UCE_AggroArea : MonoBehaviour
{
    protected Entity owner;

    void Awake()
    {
        owner = GetComponentInParent<Entity>();
    }
    
    void OnTriggerEnter(Collider co)
    {
        AggroCheck(co.GetComponentInParent<Entity>());
    }

    void OnTriggerStay(Collider co)
    {
        AggroCheck(co.GetComponentInParent<Entity>());
    }

    void AggroCheck(Entity entity)
    {
        if (owner.UCE_CanAttack(entity))
            owner.OnAggro(entity);
    }

}
