using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model
{
    public class Audio : Document
    {
         public Audio(){}

        public Audio(string _titre="", string _path="", bool _hasCopyright=false)
            : base(_titre, _path, _hasCopyright) {type = Type.Audio;} 

        public override string Afficher()
        {
            TagLib.File f = TagLib.File.Create(this.path);
            TagLib.Id3v2.Tag id3v2Tag = f.GetTag(TagLib.TagTypes.Id3v2) as TagLib.Id3v2.Tag;

            string res = 
                "Titre      : " + id3v2Tag.Title + "\n" +
                "Artiste    : " + id3v2Tag.FirstPerformer + "\n" +
                "Album      : " + id3v2Tag.Album + "\n" +
                "Genre      : " + id3v2Tag.FirstGenre + "\n" +
                "Année      : " + id3v2Tag.Year + "\n" +
                "Longueur   : " + f.Properties.Duration + "\n" +
                "Bitrate    : " + f.Properties.AudioBitrate + "kbps\n";
            return res; 

        }
    }
}
