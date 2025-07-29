namespace Chapter09_IndexersAndProperties.Properties;

public class SimpProp
{
    int prop; // field being managed by MyProp

    public SimpProp()
    {
        prop = 0;
    }
    
    /* This is the property that supports access to
    the private instance variable prop. It
    allows only positive values. */
    public int MyProp {
        get {
            return prop;
        }
        set {
            if(value >= 0) prop = value;
        }
    }
}