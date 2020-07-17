﻿using Assets.Src.Controls.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Src.Controls
{
    public interface IControlScheme
    {
        Action StartupActions();

        void MovePlayer(GameObject gameObject);

        void RotatePlayer(GameObject gameObject, Transform cameraTransform);

        void SetMove(KeyCode keyCode, Vector3 direction);
    }
}
