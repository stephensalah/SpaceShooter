/**** 
 * Created by: Steve Salah
 * Date Created: April 11, 2022
 * 
 * Last Edited by: Steve Salah
 * Last Edited: April 11, 2022
 * 
 * Description: Returns object to pool on disable
****/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolReturn : MonoBehaviour
{
    private ObjectPool pool;
    // Start is called before the first frame update
    void Start()
    {
        pool= ObjectPool.POOL;
    }
    private void OnDisable(){
        if (pool!= null){
            pool.ReturnObject(this.gameObject);//return object to pool
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
