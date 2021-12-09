using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public SpriteRenderer ArmorRenderer;
    public SpriteRenderer WeaponRenderer;

public button ArmorShop;
public Button WeaponShop;

    public void ArmorShops()
    {
this.ArmorShop.SetActive(false);
this.WeaponRenderer(true);
    }
    public void WeaponShops()
    {
        this.ArmorShop.SetActive(true);
        this.WeaponShop.SetActice(false);
    }
    
    public void SetArmor(Sprite newSprite)
    {
        ArmorRenderer.sprite = newSprite;
    }
    
     public void SetWeapon(Sprite WeaponSprite)
     {
         WeaponRenderer.sprite = WeaponSprite;
     }


}
