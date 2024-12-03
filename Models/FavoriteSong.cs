namespace Final.Models
{
    public class FavoriteSong
    {
        public int FavoriteSongID { get; set; }
        public int TeamMemberID { get; set; }
        public string SongName { get; set; }
        public string Artist { get; set; }

        // Navigation property
        public FavoriteSong() { }

        public FavoriteSong (int id, int memberId, string songName, string artist)
        {
            FavoriteSongID = id;
            TeamMemberID = memberId;
            SongName = songName;
            Artist = artist;
        }
    }
}
