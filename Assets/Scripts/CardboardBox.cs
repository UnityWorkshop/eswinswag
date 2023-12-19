using DefaultNamespace;
public class CardboardBox : Box
{
    public override bool CanMove() => Swag.swagCounter >= 1;
}
