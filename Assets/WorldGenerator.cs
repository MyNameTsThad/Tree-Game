using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGenerator : MonoBehaviour
{
    [SerializeField] private Transform start;
    [SerializeField] private Transform end;
    [SerializeField] private Transform parent;

    [SerializeField] private GameObject big;
    [SerializeField] private GameObject bigApple;
    [SerializeField] private GameObject medium;
    [SerializeField] private GameObject mediumApple;
    [SerializeField] private GameObject small;
    [SerializeField] private GameObject smallApple;
    [SerializeField] private GameObject rock1;
    [SerializeField] private GameObject rock2;
    [SerializeField] private GameObject rock3;
    public int numSmall = 60;
    public int numMedium = 40;
    public int numBig = 20;
    public int numRock = 99;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numSmall / 2; i++)
        {
            Instantiate(small, new Vector3(Random.Range(start.position.x, end.position.x), start.position.y, 0), Quaternion.identity, parent);
        }
        for (int i = 0; i < numSmall / 2; i++)
        {
            Instantiate(smallApple, new Vector3(Random.Range(start.position.x, end.position.x), start.position.y, 0), Quaternion.identity, parent);
        }

        for (int i = 0; i < numMedium / 2; i++)
        {
            Instantiate(medium, new Vector3(Random.Range(start.position.x, end.position.x), -4.003f, 0), Quaternion.identity, parent);
        }
        for (int i = 0; i < numMedium / 2; i++)
        {
            Instantiate(mediumApple, new Vector3(Random.Range(start.position.x, end.position.x), -4.003f, 0), Quaternion.identity, parent);
        }

        for (int i = 0; i < numBig / 2; i++)
        {
            Instantiate(big, new Vector3(Random.Range(start.position.x, end.position.x), -3.502f, 0), Quaternion.identity, parent);
        }
        for (int i = 0; i < numBig / 2; i++)
        {
            Instantiate(bigApple, new Vector3(Random.Range(start.position.x, end.position.x), -3.502f, 0), Quaternion.identity, parent);
        }

        for (int i = 0; i < numRock; i++)
        {
            Instantiate(rock1, new Vector3(Random.Range(start.position.x, end.position.x), -3.803504f, 0), Quaternion.identity, parent);
        }
        for (int i = 0; i < numRock; i++)
        {
            Instantiate(rock2, new Vector3(Random.Range(start.position.x, end.position.x), -3.585002f, 0), Quaternion.identity, parent);
        }
        for (int i = 0; i < numRock; i++)
        {
            Instantiate(rock3, new Vector3(Random.Range(start.position.x, end.position.x), -3.673423f, 0), Quaternion.identity, parent);
        }
    }

    
}
