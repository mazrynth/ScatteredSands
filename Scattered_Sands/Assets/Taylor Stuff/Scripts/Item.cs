using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Item : MonoBehaviour {

	public enum ItemType {ROCK, OTHER};
	public ItemType type;

	public Sprite spriteNeutral;
	public Sprite spriteHighlighted;
	public int maxSize;


	public void Use()
	{
		switch(type) 
		{
		case ItemType.ROCK:
			Debug.Log("Rock");
			break;
		case ItemType.OTHER:
			Debug.Log("Other");
			break;
		}

	}


}
