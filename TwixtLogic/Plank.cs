using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

public class Plank{
Post[] plankLocation = new Post[2];
string _teamColor;

public Plank(Post post1, Post post2)
    {
    plankLocation[0] = post1;
    plankLocation[2] = post2;
    if (teamColorMatch(post1,post2))
    {
        _teamColor = post1.GetTeamColor();
    }
    

}

public bool teamColorMatch(Post post1, Post post2)
{
    if (post1.GetTeamColor() == post2.GetTeamColor())
    {
        return true;
    }
    else
    {
        return false;
    }
}

public string GetTeamColor()
{
    return _teamColor;
}
}