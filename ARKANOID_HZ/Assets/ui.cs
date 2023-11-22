using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ui : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            text.text = "ZMIENIONY TEKST";
            text.fontSize = 42;
            text.color = Color.red;
            text.fontStyle = FontStyles.Italic;
        }
    }
}
