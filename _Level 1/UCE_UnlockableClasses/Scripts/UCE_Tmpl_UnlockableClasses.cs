// =======================================================================================
// Created and maintained by iMMO
// Usable for both personal and commercial projects, but no sharing or re-sale
// * Discord Support Server.............: https://discord.gg/YkMbDHs
// * Public downloads website...........: https://www.indie-mmo.net
// * Pledge on Patreon for VIP AddOns...: https://www.patreon.com/IndieMMO
// * Instructions.......................: https://indie-mmo.net/knowledge-base/
// =======================================================================================
using UnityEngine;

// DEFAULT UNLOCKED CLASSES

[CreateAssetMenu(fileName = "UCE Default Unlocked Classes", menuName = "UCE Templates/New UCE Default Unlocked Classes", order = 999)]
public class UCE_Tmpl_UnlockableClasses : ScriptableObject
{
    [Tooltip("[Required] Default classes available to all players")]
    public Player[] defaultClasses;
}
