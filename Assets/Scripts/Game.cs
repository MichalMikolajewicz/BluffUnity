using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public GameObject CardPrefab;


    void Start()
    {
        Instantiate(CardPrefab, new Vector3(0, 0, 0), Quaternion.identity);
    }

    void Update()
    {
    }
}
