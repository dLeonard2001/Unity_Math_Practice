using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerp : MonoBehaviour
{
    public List<Transform> list_of_points = new List<Transform>();
    public GameObject cube;
    public GameObject cube_2;
    public GameObject sphere_3;
    private float t;
    private float tMultiplier;

    
    
    // Start is called before the first frame update
    void Start()
    {
        t = 0.0f;
        tMultiplier = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        cube.transform.position =
            new Vector3(
                Mathf.Lerp(list_of_points[0].position.x, list_of_points[1].position.x, t), 
                0, 
                Mathf.Lerp(list_of_points[0].position.z, list_of_points[1].position.z, t));
        cube_2.transform.position = new Vector3(
            Mathf.Lerp(list_of_points[1].position.x, list_of_points[2].position.x, t), 
            0, 
            Mathf.Lerp(list_of_points[1].position.z, list_of_points[2].position.z, t));

        sphere_3.transform.position = new Vector3(Mathf.Lerp(cube.transform.position.x, cube_2.transform.position.x, t),
            0,
            Mathf.Lerp(cube.transform.position.z, cube_2.transform.position.z, t));

        t += tMultiplier * Time.deltaTime;
        Debug.Log(t);

        if (t > 1.0f || t < 0.0f)
        {
            tMultiplier *= -1;
        }

    }
}
