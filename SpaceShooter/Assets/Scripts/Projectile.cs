/**** 
 * Created by: Steve Salah
 * Date Created: April 6, 2022
 * 
 * Last Edited by: Steve Salah
 * Last Edited: April 6, 2022
 * 
 * Description: Behaviors for projectile
****/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    private BoundsCheck bndCheck; //referencing Boundscheck

    void Awake(){
        bndCheck = GetComponent<BoundsCheck>(); //get the BoundsCheck component
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bndCheck.offUp){
            gameObject.SetActive(false);
            bndCheck.offUp=false;//reset bounds
            //Destroy(gameObject);
        }//end if (bndcheck.offUp)
    }
}
