using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleGateMgr : MonoBehaviour
{
    [SerializeField] GameObject doubleGatePrefab;
    private GameObject clone;
    private GameObject space;

    public void OrderInst(int _stageNumber)
    {
        //オブジェクトを格納する空間を作成
        space = new GameObject("Obj Space");
        //生成した空間を子の位置に移動
        space.transform.parent = this.transform;

        //ステージ１では使わない
        if (_stageNumber == 2)
        {
            //１つ目
            clone = Instantiate(doubleGatePrefab, new Vector3(0, 0.5f, 18.5f), Quaternion.identity, space.transform);
            clone.GetComponent<DoubleGate>().Set("−", 10, "＋", 8);
            //２つ目
            clone = Instantiate(doubleGatePrefab, new Vector3(0, 0.5f, 37.0f), Quaternion.identity, space.transform);
            clone.GetComponent<DoubleGate>().Set("＋", 3, "×", 2);
        }
        else if(_stageNumber == 3)
        {
            //１つ目
            clone = Instantiate(doubleGatePrefab, new Vector3(0, 0.5f, 16.0f), Quaternion.identity, space.transform);
            clone.GetComponent<DoubleGate>().Set("×", 3, "＋", 7);
            //２つ目
            clone = Instantiate(doubleGatePrefab, new Vector3(0, 0.5f, 27.0f), Quaternion.identity, space.transform);
            clone.GetComponent<DoubleGate>().Set("＋", 3, "−", 5);
        }
        else if (_stageNumber == 4)
        {
            //１つ目
            clone = Instantiate(doubleGatePrefab, new Vector3(0, 0.5f, 13.0f), Quaternion.identity, space.transform);
            clone.GetComponent<DoubleGate>().Set("×", 2, "−", 5);
        }
        else if (_stageNumber == 5)
        {
            //１つ目
            clone = Instantiate(doubleGatePrefab, new Vector3(0, 0.5f, 13.0f), Quaternion.identity, space.transform);
            clone.GetComponent<DoubleGate>().Set("＋", 3, "×", 3);
            //１つ目
            clone = Instantiate(doubleGatePrefab, new Vector3(0, 0.5f, 37.0f), Quaternion.identity, space.transform);
            clone.GetComponent<DoubleGate>().Set("−", 10, "＋", 3);
        }
    }
}
