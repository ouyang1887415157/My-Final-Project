using TMPro;
using UnityEngine;

public class TextColor : MonoBehaviour
{
    void Start()
    {
        // ��ȡTextMeshPro���
        TextMeshProUGUI textMeshPro = GetComponent<TextMeshProUGUI>();

        // ����������ɫΪ��ɫ
        textMeshPro.color = Color.blue;
    }
}
