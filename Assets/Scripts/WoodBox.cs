using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class WoodBox : Box
{
    public bool CanMove() => Swag.swagCounter >= 2;
}
