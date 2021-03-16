using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
public class AutoHost : MonoBehaviour
{   
   public NetworkManager networkManager;
    
    void Start()
    {
        if(!Application.isBatchMode)
        {
            Debug.Log("Server Started");                
            networkManager.StartClient();
        }
         else
        {
            Debug.Log("Server Started");
        }
    }
    public void Join()
    {
        networkManager.networkAddress = "localhost";
        networkManager.StartClient();
    }
    

}
