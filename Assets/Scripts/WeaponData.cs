namespace encounter {

using UnityEngine;

[CreateAssetMenu(menuName = "Encounter/Weapon", fileName = "Weapon")]
public class WeaponData : ScriptableObject {

  public Sprite image;
  public int attackBonus;
  public int damageDie;

  public override string ToString () => name;
}
}
