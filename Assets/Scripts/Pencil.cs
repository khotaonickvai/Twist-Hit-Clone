using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Pencil : MonoBehaviour
{
    [SerializeField] private float speedScaleUp = 10f;
    [SerializeField] private float speedScaleDown = 100f;
    [SerializeField] private float maxScale = 3;

    [SerializeField]private MeshGenaration _meshGenaration;

    internal void SetMeshGenaration(MeshGenaration meshGenaration)
    {
        _meshGenaration = meshGenaration;
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            if (transform.localScale.x < maxScale)
            {
                ScaleUp();
            }
            else
            {
                Draw(_meshGenaration);
            }
        }
        else
        {
            if (transform.localScale.x > Mathf.Epsilon)
            {
                ScaleDown(); 
            }
            
        }
    }

    private void ScaleUp()
    {
        transform.localScale += Vector3.right * speedScaleUp * Time.deltaTime;
        var position = transform.localPosition;
        transform.localPosition =
            new Vector3(-transform.localScale.x / 2, position.y, position.z);
    }

    private void ScaleDown()
    {
        transform.localScale -= Vector3.right * speedScaleDown * Time.deltaTime;
        var position = transform.localPosition;
        transform.localPosition =
            new Vector3(-transform.localScale.x / 2, position.y, position.z);
    }

    private void Draw(MeshGenaration meshGenaration)
    {
        meshGenaration.AddShape();
    }
}
