﻿using System;
using Components;
using HealthHandler;
using UnityEngine;

namespace DamageHandler
{
    public interface IDamageable
    {
        public event Action<HealthInfo,int> OnGetDamage;

        public void GetDamage (int amount);

        public Vector3 Position { get; }

        public Vector3 HpBarPosition { get; }

        public bool IsAlive { get; }
    }
}