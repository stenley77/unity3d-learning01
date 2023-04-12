using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class moveCube : MonoBehaviour, Controls.IPlayerActions
{
    public Keyboard keyboard;
    [SerializeField] private float _speed = 5.0f;
//    private float _qtnCube;
//    private float _x;
    private Vector3 _direction;

    public void OnMove(InputAction.CallbackContext context)
    {
        var values = context.ReadValue<Vector2>();
        _direction = new Vector3(values.x, 0, values.y);
    }

    // Start is called before the first frame update
    void Start()
    {
        keyboard = Keyboard.current;
    }

    // Update is called once per frame
    void Update()
    {
        if (keyboard == null)
        {
            Debug.Log("No Keyboard");
            return;
        }
        transform.Translate(_direction * (_speed * Time.deltaTime));
    }
}
