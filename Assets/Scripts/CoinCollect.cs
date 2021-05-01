using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    public playermovement movement;

    void OnTriggerEnter(Collider other)
    {

        
        
        if(other.GetComponent<Collider>().tag == "Player")
        {   
            Debug.Log("Coin collected!");  
            Destroy(gameObject);//des coin
        }
    }
}
