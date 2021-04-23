using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    public playermovement movement;

    void OnCollisionEnter(Collision collisionInfo)
    {

        if(collisionInfo.collider.tag == "coin")
        {   
            Debug.Log("Coin collected!");  
            Destroy(gameObject);//des coin
        }
    }
}
