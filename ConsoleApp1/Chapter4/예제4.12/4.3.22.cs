/*4.3.2 모든 타입의 조상: System.Object*/

public class Object
{
    public virtual bool Equals(object obj);
    public virtual int GetHashCode();
    public Type GetType();
    public virtual string ToString();
}