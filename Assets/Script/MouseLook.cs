using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public enum RorationAxes
    {
        XandY,
        X,
        Y
    }
    public RorationAxes _axes = RorationAxes.XandY;
    public float _rotationSpeedHor = 5.0f;
    public float _rotationSpeedVer = 5.0f;

    public float maxVert = 45.0f;
    public float minVert = -45.0f;

    private float _rotationX = 0;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody body = GetComponent<Rigidbody>();
        if (body != null )
            body.freezeRotation = true;
    }

    void Update()
    {
        if (_axes == RorationAxes.XandY)
        {
            // ��������� �� �� Y (�����������)
            float _rotationY = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * _rotationSpeedHor;

            // ��������� �� �� X (���������) � ����������
            _rotationX -= Input.GetAxis("Mouse Y") * _rotationSpeedVer;
            _rotationX = Mathf.Clamp(_rotationX, minVert, maxVert);

            // ������������ ������ ���������
            transform.localEulerAngles = new Vector3(_rotationX, _rotationY, 0);
        }
        else if (_axes == RorationAxes.X)
        {
            // ҳ���� ��������� �� �� Y
            transform.Rotate(0, Input.GetAxis("Mouse X") * _rotationSpeedHor, 0);
        }
        else if (_axes == RorationAxes.Y)
        {
            // ҳ���� ��������� �� �� X (� ����������)
            _rotationX -= Input.GetAxis("Mouse Y") * _rotationSpeedVer;
            _rotationX = Mathf.Clamp(_rotationX, minVert, maxVert);

            transform.localEulerAngles = new Vector3(_rotationX, transform.localEulerAngles.y, 0);
        }
    }
}
