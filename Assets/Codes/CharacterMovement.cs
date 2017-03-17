using UnityEngine;
using System.Collections;

[System.Serializable]
public struct HeadingDir
{
    public float Up, Down, Left, Right;
}


public class CharacterMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
        if (!body)
        {
            body = GetComponent<Rigidbody>();
        }
	}

    public Rigidbody body;

    public HeadingDir dir;

    /// <summary>
    /// Moving speed
    /// </summary>
    public float Speed=1.0f;


    public void SetDir(float Dir)
    {
        body.transform.eulerAngles = new Vector3(0,Dir,0);
    }

	// Update is called once per frame
	void Update () {
        if (Input.GetButton("MoveUp"))
        {
            body.velocity = new Vector3(0,0,1.0f)* Speed;
            SetDir(dir.Up);
        }
        if (Input.GetButton("MoveDown"))
        {
            body.velocity = new Vector3(0, 0, -1.0f) * Speed;
            SetDir(dir.Down);
        }
        if (Input.GetButton("MoveLeft"))
        {
            body.velocity = new Vector3(-1.0f, 0,0) * Speed;
            SetDir(dir.Left);
        }
        if (Input.GetButton("MoveRight"))
        {
            body.velocity = new Vector3(1.0f, 0, 0) * Speed;
            SetDir(dir.Right);
        }
    }
}
