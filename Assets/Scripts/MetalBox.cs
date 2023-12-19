using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class MetalBox : Box
{
    public override bool CanMove() => Swag.swagCounter >= 3;
}
