namespace IwskSekcjaXMikroproj
{
    public enum FlowControl
    {
        None,
        StandardTerminator, // (CR, LF, CR-LF)
        OwnTerminator // terminator „własny” 1 lub 2 znakowy
    }
}
