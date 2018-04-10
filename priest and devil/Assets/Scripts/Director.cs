using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Director : System.Object
{

    public ISceneControl currentSceneControl { get; set; }
    private static Director director;

    private Director()
    {

    }

    public static Director getInstance()
    {
        if (director == null)
        {
            director = new Director();
        }
        return director;
    }
}