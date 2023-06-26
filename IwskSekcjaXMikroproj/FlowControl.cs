namespace IwskSekcjaXMikroproj
{
    public enum FlowControl
    {
        None,
        CR, // (CR, LF, CR-LF)
        LF,
        CRLF,
        OwnTerminator // terminator „własny” 1 lub 2 znakowy
    }
}
