namespace encounter {

using UnityEngine;

[CreateAssetMenu(menuName = "Encounter/Monster", fileName = "Monster")]
public class MonsterData : ScriptableObject {

  public Sprite image;
  public WeaponData[] weapons;
  public int maxHp;
  public int armorClass;
  public int initiativeBonus;
  public int xpReward;

  public override string ToString () => name;
}
}
