﻿using CryEngine;
using CryGameCode.Entities;

namespace CryGameCode.AngryBoids
{
	[Entity(Category = "AngryBoids")]
	public class Enemy : Rigidbody
	{
		[EditorProperty(Min = 0, Max = 10)]
		public float VelocityToKill { get; set; }

		protected override void OnCollision(EntityId targetEntityId, Vec3 hitPos, Vec3 dir, short materialId, Vec3 contactNormal)
		{
			if(Velocity.Length > VelocityToKill)
			{
				var particle = ParticleEffect.Get("explosions.barrel.explode");
				particle.Spawn(hitPos);

				Entity.Remove(Id);
			}
		}
	}
}