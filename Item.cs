namespace ReadCSV.Model
{
    public class Item
    {
        public int GroupId { get; set; }
        public int MaterialId { get; set; }
        public double ItemQuantity { get; set; }
        public string? ItemDim1 { get; set; }
        public string? ItemDim2 { get; set; }
        public string? ItemDim3 { get; set; }
        public string? ItemClass { get; set; }

        public override string ToString()
        {
            return "GroupId: " + GroupId; 
           
        }
    }
}

