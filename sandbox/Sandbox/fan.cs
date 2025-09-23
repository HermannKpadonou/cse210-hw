using System;
using System.Security.Cryptography.X509Certificates;

public class Fan
{
    private bool _isOn;
    private int _speed;

    public Fan()
    {
        _isOn = false;
        _speed = 0;
    }

    public void TurnOn()
    {
        _isOn = true;
        _speed = 1;
    }
    public string GetStatus()
    {
        if (_isOn)
        {
            return $"The fan is on at speed {_speed}.";
        }
        else
        {
            return "The fan is off.";
        }

    }
   
}