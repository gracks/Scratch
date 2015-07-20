using UnityEngine;
using System.Collections;

public class Arrays : MonoBehaviour
{
	void Start()
	{
		print( "Arrays" );
		GameObject[ , ] twoDimension = new GameObject[ 2, 3 ];
		for ( int i = 0; i < twoDimension.Length; i++ )
		{
			Debug.Log( i );
		}
	}

	void Update()
	{
	
	}
}