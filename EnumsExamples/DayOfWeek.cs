namespace EnumsExamples
{
    [Flags]
    public enum DayOfWeek
    {
        Monday    = 0b_00000001,
        Tuesday   = 0b_00000010,
        Wednesday = 0b_00000100, 
        Thursday  = 0b_00001000,
        Friday    = 0b_00010000,
        Saturday  = 0b_00100000,
        Sunday    = 0b_01000000
    }
}
