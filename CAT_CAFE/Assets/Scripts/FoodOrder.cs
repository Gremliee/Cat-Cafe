using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodOrder : MonoBehaviour
{
    [SerializeField] List<GameObject> foOD;

    private void Update()
    {
        var yes = foOD[ Random.Range(0,foOD.Count)];
    }
}
