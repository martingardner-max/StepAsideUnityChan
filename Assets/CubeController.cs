using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //トリガーモードで他のオブジェクトと接触した場合の処理
    void OnTriggerEnter(Collider other)
    {

        //障害物に衝突した場合
        if (other.gameObject.tag == "CarTag" || other.gameObject.tag == "TrafficConeTag")
        {
            //接触したオブジェクトを破棄
            Destroy(other.gameObject); 
        }

        //ゴール地点に到達した場合
        if (other.gameObject.tag == "GoalTag")
        {
            //接触したオブジェクトを破棄
            Destroy(other.gameObject); 
        }

        //コインに衝突した場合
        if (other.gameObject.tag == "CoinTag")
        {
            //接触したオブジェクトを破棄
            Destroy(other.gameObject);
        }
    }
}
