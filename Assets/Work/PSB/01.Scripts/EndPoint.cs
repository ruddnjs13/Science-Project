using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPoint : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            GameManager.Instance.ClearEvent();
        }
    }
}
