using UnityEngine;
using System.Collections;
using Photon;

public class MatchMakingController : MonoBehaviour
{
	
	private string name;
	
	private void Awake()
	{
		Application.runInBackground = true;
		name = Time.time.ToString();
	}
	
}
