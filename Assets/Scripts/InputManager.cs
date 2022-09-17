using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private HUD hud;
    private bool _isInputActive = true;

    private void Update()
    {
        if (_isInputActive)
        {
            if (Input.GetKey(KeyCode.W))
            {
                Invoker.PlayerMovement.Move(player.playerRB, +player.playerMoveSpeed);
            }
            if (Input.GetKey(KeyCode.S))
            {
                Invoker.PlayerMovement.Move(player.playerRB, -player.playerMoveSpeed);
            }
            if (Input.GetKey(KeyCode.D))
            {
                Invoker.PlayerMovement.Rotate(player.playerRB, +player.playerRotationSpeed);
            }
            if (Input.GetKey(KeyCode.A))
            {
                Invoker.PlayerMovement.Rotate(player.playerRB, -player.playerRotationSpeed);
            }
            if (Input.GetKey(KeyCode.Space))
            {
                Invoker.PlayerMovement.Jump(player.playerRB, player.jumpForce);
            }
            if (Input.GetKeyDown(KeyCode.Q))
            {
                Invoker.PlayerCombat.Shoot(player.bullet, player.firePoint, player.gameObject);
            }
            if (Input.GetKeyDown(KeyCode.Return))
            {
                _isInputActive = false;
                hud.ChangeInputStatusText();
            }
        }

        if (!Input.GetKey(KeyCode.Mouse0) || _isInputActive != false) return;
        _isInputActive = true;
        hud.ChangeInputStatusText();
    }
}
