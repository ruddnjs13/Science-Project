using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowTimeUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _timePanel;

    private void Update()
    {
        _timePanel.text = GameManager.Instance.CurrentTime.ToString();
    }
}
