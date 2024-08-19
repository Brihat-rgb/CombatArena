using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinLogic : MonoBehaviour
{
    public gameManagerLogic gameManager;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("Player Enter");
            gameManager.coinAdd();
            Destroy(gameObject); 
        }
    }
}
