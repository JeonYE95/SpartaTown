using System;
using UnityEngine;
using UnityEngine.UIElements;

public class SpartaTownAimRotation : MonoBehaviour
{
    [SerializeField] private SpriteRenderer characterRenderer;
    [SerializeField] private Transform pivot;

    private SpartaTownController controller;

    private void Awake()
    {
        controller = GetComponent<SpartaTownController>();
    }

    private void Start()
    {
        controller.OnLookEvent += OnAim;
    }

    private void OnAim(Vector2 direction)
    {
        RotatePlayer(direction);
    }

    private void RotatePlayer(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;

        pivot.rotation = Quaternion.Euler(0, 0, rotZ);
    }
}