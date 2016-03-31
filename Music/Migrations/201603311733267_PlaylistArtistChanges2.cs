namespace Music.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PlaylistArtistChanges2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Playlists", "Album_AlbumID", "dbo.Albums");
            DropIndex("dbo.Playlists", new[] { "Album_AlbumID" });
            CreateTable(
                "dbo.PlaylistAlbums",
                c => new
                    {
                        Playlist_PlaylistID = c.Int(nullable: false),
                        Album_AlbumID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Playlist_PlaylistID, t.Album_AlbumID })
                .ForeignKey("dbo.Playlists", t => t.Playlist_PlaylistID, cascadeDelete: true)
                .ForeignKey("dbo.Albums", t => t.Album_AlbumID, cascadeDelete: true)
                .Index(t => t.Playlist_PlaylistID)
                .Index(t => t.Album_AlbumID);
            
            AlterColumn("dbo.Playlists", "Name", c => c.String(nullable: false));
            DropColumn("dbo.Playlists", "Album_AlbumID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Playlists", "Album_AlbumID", c => c.Int());
            DropForeignKey("dbo.PlaylistAlbums", "Album_AlbumID", "dbo.Albums");
            DropForeignKey("dbo.PlaylistAlbums", "Playlist_PlaylistID", "dbo.Playlists");
            DropIndex("dbo.PlaylistAlbums", new[] { "Album_AlbumID" });
            DropIndex("dbo.PlaylistAlbums", new[] { "Playlist_PlaylistID" });
            AlterColumn("dbo.Playlists", "Name", c => c.String());
            DropTable("dbo.PlaylistAlbums");
            CreateIndex("dbo.Playlists", "Album_AlbumID");
            AddForeignKey("dbo.Playlists", "Album_AlbumID", "dbo.Albums", "AlbumID");
        }
    }
}
