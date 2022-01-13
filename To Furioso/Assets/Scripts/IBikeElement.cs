namespace Visitor
{
    public interface IBikeElement
    {
        void Accept(IVisitor visitor);
    }
}