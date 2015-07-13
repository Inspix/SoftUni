namespace _08.SequenceNtoM
{
    public class Item
    {
        public int Value { get; set; }
        public Item Previous { get; set; }

        public Item(int value, Item prev)
        {
            this.Value = value;
            this.Previous = prev;
        }
    }
}
