using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimeManager : MonoBehaviour
{
    public bool win = false;


    public GameObject winPanel;

    public List<GameObject> destroyAfterGame = new List<GameObject>();

    private void Update()
    {

        if(win == true)
        {
            UpdateObjectList("Enemy");
            UpdateObjectList("Object");
            winPanel.SetActive(true);
            foreach (GameObject allObjects in destroyAfterGame)
            {
                Destroy(allObjects);
            }
        }
        if(win == false)
        {
            winPanel.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }

    void UpdateObjectList(string tag)
    {
        destroyAfterGame.AddRange(GameObject.FindGameObjectsWithTag(tag));
    }

    
}
