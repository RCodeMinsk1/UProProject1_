using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotMechanic : MonoBehaviour, IRobots
{
    public void Bring()
    {
        throw new System.NotImplementedException();
    }

    public void Greeting()
    {
        Debug.Log("������! � ������������ �������!");
    }

    public void Use()
    {
        Debug.Log("��� �� ������, ����� � �������?");
    }
}
