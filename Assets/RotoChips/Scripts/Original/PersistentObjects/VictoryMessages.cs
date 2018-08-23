using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// an Decorator class for victory messages queue shown in WinnerScwnw
public class VictoryMessages : MonoBehaviour
{

	public static VictoryMessages instance;
	Queue<string> messageQueue;

	void Awake()
	{
		if (instance == null)
		{
			instance = this;
			messageQueue = new Queue<string>();
		}
		else if (instance != this)
		{
			Destroy(gameObject);
		}
	}

	// the next two methods manipulate the bonus queue
	public void PostMessage(string message)
	{
		messageQueue.Enqueue(message);
	}

	public string RetrieveMessage()
	{
		if (messageQueue.Count > 0)
		{
			return messageQueue.Dequeue();
		}
		return "";
	}

	public void Clear()
	{
		messageQueue.Clear();
	}

}
