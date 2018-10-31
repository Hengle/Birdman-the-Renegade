﻿using UnityEngine;
using SIS.Characters;
using SIS.Items.Weapons;

//Allows for things to be hit
namespace SIS
{
	//General
	interface IHittable
	{
		void OnHit(Character shooter, float baseDamage, Vector3 dir, Vector3 pos);
	}

	//Generic
	interface IHittable<C> where C : Character
	{
		void OnHit(C shooter, float baseDamage, Vector3 dir, Vector3 pos);
	}
}