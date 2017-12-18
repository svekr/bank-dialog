using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BankController : MonoBehaviour {
    public BankItem templateItem;
    public BankItemsDataList dataProvider;

    private BankItem[] _bankItems;

    public void Start() {
        if (templateItem != null) {
            templateItem.gameObject.SetActive(false);
        }
        InitializeBank();
    }

    private void InitializeBank() {
        if (templateItem != null) {
            float distance = 0;
            RectTransform rectTransform = (RectTransform)templateItem.transform;
            if (rectTransform != null) {
                distance = rectTransform.rect.xMax;
            }
            distance = 180;

            if (dataProvider != null && dataProvider.bankItems != null) {
                int counter = 0;
                foreach (BankItemData itemData in dataProvider.bankItems) {
                    BankItem newItem = CreateBankItem(itemData, counter * distance);
                    if (newItem != null) {
                        if (_bankItems == null) {
                            _bankItems = new BankItem[dataProvider.bankItems.Length];
                        }
                        _bankItems[counter] = newItem;
                        counter++;
                    }
                }
            }
        }
    }

    private BankItem CreateBankItem(BankItemData itemData, float displacement = 0) {
        BankItem result = Instantiate(templateItem, transform);
        Vector3 newPosition = new Vector3(transform.position.x + displacement, transform.position.y);
        result.transform.SetPositionAndRotation(newPosition, result.transform.rotation);
        result.UpdateData(itemData);
        result.gameObject.SetActive(true);
        return result;
    }
}
