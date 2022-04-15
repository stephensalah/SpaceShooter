/**** 
 * Created by: Steve Salah
 * Date Created: April 14, 2022
 * 
 * Last Edited by: Steve Salah
 * Last Edited: April 14, 2022
 * 
 * Description: Scrolls through the background
****/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MAterialScroller : MonoBehaviour
{

    /***VARIABLES***/
    public Vector2 scrollSpeed = new Vector2(0, 0f); //x and y speed for scroll

    private Renderer goRenderer; //game object's renderer component
    private Material goMat; //the game object's material
    private Vector2 offset; //the offset of scroll
    // Start is called before the first frame update
    void Start()
    {
        goRenderer = GetComponent<Renderer>();
        goMat = goRenderer.material;
    }

    // Update is called once per frame
    void Update()
    {
        offset = (scrollSpeed * Time.deltaTime); //set offset value over time
        goMat.mainTextureOffset += offset; //set texture offeset
    }
}
