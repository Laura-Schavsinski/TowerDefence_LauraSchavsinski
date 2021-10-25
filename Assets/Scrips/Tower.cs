using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public GameObject _upgrade = null;
    private GameObject upgrade { get { return _upgrade; } }

    private List<Enemy> enemies { get; set; } = null;
    private void Start()
    {
        enemies = new List<Enemy>();
    }


    private void Update()
    {
        
    }

    public void Upgrade()
    {
        if(upgrade == null)
        {
            return;
        }

        Instantiate(upgrade, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        Enemy enemy = other.GetComponent<Enemy>();
        if(enemy != null)
        {
            enemies.Add(enemy);
        }
    }


}
