using System;

namespace Testing4
{
    public class clssupplier
    {
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public string sup_Name { get; set; }
        public DateTime Sup_Start_Date { get; set; }
        public int available { get; internal set; }
        public string phones { get; internal set; }
        public string contact { get; internal set; }
    }
}