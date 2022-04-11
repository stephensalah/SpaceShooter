/**** 
 * Created by: Steve Salah
 * Date Created: April 6, 2022
 * 
 * Last Edited by: Steve Salah
 * Last Edited: April 11, 2022
 * 
 * Description: Create a pool of objects for reuse.
****/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    static public ObjectPool POOL;

    #region POOL Singleton
    void CheckPoolIsInScene(){
        if (POOL==null){
            POOL=this;
        }else{
            Debug.LogError("POOL.Awake() - Attempted to assign a second ObjectPool.POOL");
        }
    }//End CheckpoolisinScene
    #endregion

    private Queue<GameObject> projectiles = new Queue<GameObject>();//new queue of projectiles
    [Header("Pool Settings")]
    public GameObject projectilePrefab;
    public int poolStartSize = 5;

    void Awake(){
        CheckPoolIsInScene();

    }
    

    // Start is called before the first frame update
    void Start()
    {
        for (int i=0; i<poolStartSize; i++){
            GameObject projectileGo = Instantiate(projectilePrefab);
            projectiles.Enqueue(projectileGo); //add to queue
            projectileGo.SetActive(false); //disabled in scene

        }
    }//end start

    public GameObject GetObject(){
        if (projectiles.Count>0){
            GameObject gObject = projectiles.Dequeue();
            gObject.SetActive(true);
            return gObject;
        }
        else{
            return null;
        }
    }//end get object

    public void ReturnObject(GameObject gObject){
        projectiles.Enqueue(gObject);
        gObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
