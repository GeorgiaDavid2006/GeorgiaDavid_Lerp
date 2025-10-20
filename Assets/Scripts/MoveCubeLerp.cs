using UnityEngine;

public class MoveCubeLerp : MonoBehaviour
{
    Vector3 PositionA;
    Vector3 PositionB;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PositionA = new Vector3(0, 0, 0);
        PositionB = new Vector3(5, 5, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
