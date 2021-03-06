﻿using UnityEngine;

public class Directions {
	
	public bool up;
	public bool down;
	public bool left;
	public bool right;

	public override bool Equals (object obj){
		Vector2 rhs = ((Vector2)obj).normalized;
		if (rhs == new Vector2(-1,0))
			return this.left;
		if (rhs == new Vector2(0,1))
			return this.up;
		if (rhs == new Vector2(1,0))
			return this.right;
		if (rhs == new Vector2(0,-1))
			return this.down;
		return false;
	}	

	public override int GetHashCode()
	{
		return 0;
	}

	public static bool operator== (Directions lhs, Vector2 rhs){
		rhs = rhs.normalized;
		if (rhs == new Vector2(-1,0))
			return lhs.left;
		if (rhs == new Vector2(0,1))
			return lhs.up;
		if (rhs == new Vector2(1,0))
			return lhs.right;
		if (rhs == new Vector2(0,-1))
			return lhs.down;
		return false;
	}	

	public static bool operator!= (Directions lhs, Vector2 rhs){
		rhs = rhs.normalized;
		if (rhs == new Vector2(-1,0))
			return !lhs.left;
		if (rhs == new Vector2(0,1))
			return !lhs.up;
		if (rhs == new Vector2(1,0))
			return !lhs.right;
		if (rhs == new Vector2(0,-1))
			return !lhs.down;
		return false;
	}

	public static explicit operator int (Directions directions) {
		return (directions.left ? 1 : 0) + (directions.up ? 1 : 0) + (directions.right ? 1 : 0) + (directions.down ? 1 : 0);
	}
}