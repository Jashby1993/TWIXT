using System;

public class Post{
    string _teamColor;
    Hole _hole;

    public Post(Hole hole, string teamColor)
    {
        _hole = hole;
        _teamColor = teamColor;
    }

    public string GetTeamColor()
    {
        return _teamColor;
    }
}