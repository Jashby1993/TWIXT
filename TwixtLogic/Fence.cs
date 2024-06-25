using System;
using System.Collections.Generic;

public class Fence 
{
    List <Plank> connectedPlanks = new List<Plank>();
    string _teamColor;

    public Fence ()
    {
    _teamColor = connectedPlanks[0].GetTeamColor();
    }
}