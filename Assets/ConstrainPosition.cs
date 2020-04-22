using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstrainPosition : MonoBehaviour
{
    public Vector3 objectPosition;
    public RectTransform cursor;
    public Vector3 cursorPosition;
    private Vector3 startPos;
    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        objectPosition = transform.position;
        objectPosition.x = Mathf.Clamp(transform.position.x, startPos.x - 0.3f, startPos.x + 0.3f);
        objectPosition.z = Mathf.Clamp(transform.position.z, startPos.z - 0.2f, startPos.z + 0.2f);
        objectPosition.y = startPos.y;
        transform.position = objectPosition;
        cursor.anchoredPosition = new Vector3 (objectPosition.x - startPos.x, objectPosition.z - startPos.z, 0) * 2000;
        
    }
}
