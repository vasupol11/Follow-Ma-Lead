﻿using UnityEngine;
using SocketIO;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class LoginCtrl : MonoBehaviour {
	public InputField username;
	public InputField password;

	private SocketIOComponent socket;
//	private string password = "";

	// Use this for initialization
	void Start () {
		GameObject go = GameObject.Find("SocketIO");
		socket = go.GetComponent<SocketIOComponent>();

		socket.On("NET_AVAILABLE", onConnection);
	}

	public void onConnection(SocketIOEvent e){
		Debug.Log("is Connected");
		Debug.Log(e.data.ToString());
	}

	// Update is called once per frame
	void Update () {
		if (false){

			Dictionary<string, string> data = new Dictionary<string, string>();
			data["name"] = username.text;
			data["password"] = password.text;
			socket.Emit("LOGIN", new JSONObject(data));
		}
	}
		
}
