namespace Chapter09_IndexersAndProperties.Properties.AccessMod;

// Use an access modifier with an accessor.

public class PropAccess
{
    int prop; // field being managed by MyProp

    public PropAccess()
    {
        prop = 0;
    }
    
    /* This is the property that supports access to
        the private instance variable prop. It allows
        any code to obtain the value of prop, but only
        other class members can set the value of prop. */
    public int MyProp {
        get {
            return prop;
        }
        private set {
            prop = value;
        }
    }
    
    // This class member increments the value of MyProp.
    public void IncrProp() {
        MyProp++; // OK, in same class.
    }
}