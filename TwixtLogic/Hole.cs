using System;

public class Hole{
    int _xCoord;
    int _yCoord;
    string teamColor = "grey";
    bool _inPlay;

    public Hole(int xCoord, int yCoord)
    {
        _xCoord = xCoord;
        _yCoord = yCoord;
        _inPlay = true;
    }

    public int GetX(){
        return _xCoord;
    }

    public int GetY()
    {
        return _yCoord;
    }

    public bool checkInPlay()
    {
        return _inPlay;
    }

    public void Played()
    {
        _inPlay = false;
    }

    
}