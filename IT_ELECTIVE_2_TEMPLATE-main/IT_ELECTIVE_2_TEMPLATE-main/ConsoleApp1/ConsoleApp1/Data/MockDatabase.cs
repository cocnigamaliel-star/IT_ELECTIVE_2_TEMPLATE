using PlaylistApp.Models.Entities;

namespace PlaylistApp.Data
{
    public static class MockDatabase
    {
        public static List<Playlist> Playlists { get; set; } = new List<Playlist>
        {
            new Playlist
            {
                Title = "Chill OPM Acoustic Jam",
                CreatorName = "System",
                Videos = new List<VideoItem>
                {
                    new VideoItem { YouTubeUrl = "https://youtu.be/sample1", TrackNote = "Classic Eraserheads cover" },
                    new VideoItem { YouTubeUrl = "https://youtu.be/sample2", TrackNote = "Great vocal harmony" }
                }
            }
        };
    }
}