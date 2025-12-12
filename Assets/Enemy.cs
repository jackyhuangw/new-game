using UnityEngine;

public class Enemy : MonoBehaviour
{
    public void TakeDamage()
    {
        Debug.Log(gameObject.name + " Take damage!");
    }
}
