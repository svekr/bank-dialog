using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.InteropServices;
using TMPro;

public class BankItem : MonoBehaviour {

    public TextMeshProUGUI coins;
    public TextMeshProUGUI price;
    public Image icon;

    public void UpdateData(BankItemData data) {
        int coinsAmount = 0;
        string localizedPrice = "$0.0";
        if (data != null) {
            coinsAmount = data.coinsAmount;
            if (data.localizedPrice != null && data.localizedPrice.Length > 0) {
                localizedPrice = data.localizedPrice;
            }
            if (icon != null) {
                icon.sprite = data.icon;
            }
        }
        if (coins != null) {
            coins.text = coinsAmount.ToString();
        }
        if (price != null) {
            price.text = localizedPrice;
        }
    }
}
