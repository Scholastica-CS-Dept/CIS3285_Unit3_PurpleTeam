namespace CIS3285_Unit3Sample_2024.Models
{
    public class MessageRecord
    {
        // Changes for Sprint 1 --  I want to view a list of rooms that represent conversations -- Takunda Madziwa
        public MessageRecord(int roomID, string authorName, string text)
        {
            RoomID = roomID;
            Text = text;
            AuthorName = authorName;
        }

        public int RoomID
        {
            get;
            private set;
        }

        public string Text
        {
            get;
            private set;
        }

// Changes for Sprint 1 --  I want to view a list of rooms that represent conversations -- Takunda Madziwa
        public string AuthorName
        {
            get;
            private set;
        }
    }
}
