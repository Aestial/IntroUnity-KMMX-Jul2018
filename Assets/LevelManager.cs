using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class LevelManager : MonoBehaviour 
{
    [SerializeField] private GameObject floorPrefab;
    [SerializeField] private int floorLength;
    //[SerializeField] private float 


	void Update () 
    {
        DeleteCurrentFloor();
        SpriteRenderer sp = floorPrefab.GetComponent<SpriteRenderer>();
        float width = sp.size.x * floorPrefab.transform.localScale.x;
        Debug.Log(width);
        for (int i = 0; i < floorLength; i++)
        {
            Vector2 position = new Vector2(i * width, 0.0f);
            GameObject newFloor = Instantiate(floorPrefab, position, Quaternion.identity, this.transform);
        }
	}

    private void DeleteCurrentFloor()
    {
        int numChildren = this.transform.childCount;
        for (int i = 0; i < numChildren; i++)
        {
            DestroyImmediate(this.transform.GetChild(0).gameObject);
        }
    }
	
	//void Update () 
 //   {
		
	//}
}
