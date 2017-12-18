using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

[CreateAssetMenu]

public class BankItemData : ScriptableObject {
    public string id;
    public int coinsAmount;
    public string localizedPrice;
    public Sprite icon;
}
