using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public SpriteRenderer ArmorRenderer;
    public SpriteRenderer WeaponRenderer;

    public void SetArmor(Sprite newSprite)
    {
        ArmorRenderer.sprite = newSprite;
    }
    
     public void SetWeapon(Sprite WeaponSprite)
     {
         WeaponRenderer.sprite = WeaponSprite;
     }
}
