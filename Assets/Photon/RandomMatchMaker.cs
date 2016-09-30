using UnityEngine;
using System.Collections;
using Photon;

public class RandomMatchMaker : Photon.PunBehaviour {

	// Use this for initialization
	void Start ()
    {
        PhotonNetwork.ConnectUsingSettings("0.1");
	}
	
    void OnGUI()
    {
        GUILayout.Label(PhotonNetwork.connectionStateDetailed.ToString());
    }

    public override void OnJoinedLobby()
    {
        PhotonNetwork.JoinRandomRoom();
    }


    void OnPhotonRandomJoinFailed()
    {
        Debug.Log("Can't join random room");
        PhotonNetwork.CreateRoom(null);
    }

    void OnJoinedRoom()
    {
        GameObject VRPlayer = PhotonNetwork.Instantiate("VRPlayer", Vector3.zero, Quaternion.identity, 0);
        
    }

}
