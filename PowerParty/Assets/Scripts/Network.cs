﻿using UnityEngine;
using System.Collections;
using SocketIO;

public class Network : MonoBehaviour {

	static SocketIOComponent socket;
	public GameObject playerPrefab;

	void Start () 
	{
		socket = GetComponent<SocketIOComponent> ();

		//callbacks
		socket.On("open", OnConnected);
		socket.On ("spawn", OnSpawned);
	}
	
	void OnConnected(SocketIOEvent e)
	{
		Debug.Log ("connected");
		socket.Emit("move");
	}

	void OnSpawned(SocketIOEvent e)
	{
		Debug.Log ("spawned");
		Instantiate (playerPrefab);
	}
}
