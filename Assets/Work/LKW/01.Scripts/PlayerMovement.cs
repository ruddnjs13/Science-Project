using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    //[SerializeField] private InputReader _inputReader;

    [SerializeField] private float _moveLength;
    [SerializeField] private float _moveTime;

    private bool _isMove = false;


    private void OnEnable()
    {
        //_inputReader.OnMoveEvenet += HandleOnMoveEvent;
    }

    private void OnDisable()
    {
       // _inputReader.OnMoveEvenet -= HandleOnMoveEvent;
    }

    private void HandleOnMoveEvent(Vector3 moveDir)
    {
        if (!_isMove)
        {
            Vector2 end = transform.position + moveDir * _moveLength;

            StartCoroutine(GreedMoveCoroutine(end));
        }
    }

    private IEnumerator GreedMoveCoroutine(Vector2 end)
    {
        Vector2 start = transform.position;
        float current = 0;
        float percent = 0;

        _isMove = true;

        while (percent < 1)
        {
            current += Time.deltaTime;
            percent = current / _moveTime;

            transform.position = Vector3.Lerp(start, end, percent);
            yield return null;
        }
        _isMove = false;
    }
}
