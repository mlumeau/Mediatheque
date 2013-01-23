using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Mediatheque
{
    public enum Type {AUDIO, VIDEO, MULTIMEDIA, TEXTE};

    public class Mediatheque
    {
        [XmlElement(typeof(Video))]
        [XmlElement(typeof(Audio))]
        [XmlElement(typeof(Texte))]
        [XmlElement(typeof(Article))]
        [XmlElement(typeof(Livre))]
        [XmlElement(typeof(Multimedia))]
        public List<Document> documents { get; set; }


        public Mediatheque()
        {
            documents = new List<Document>();
        }
        
        public void Ajouter(Document _doc){
            if(!documents.Contains(_doc))
            {
                documents.Add(_doc);
            }
        }

        public void Supprimer(Document _doc)
        {
            if (documents.Contains(_doc))
            {
                documents.Remove(_doc);
            }
        }

        public IEnumerable<Audio> DocumentsAudio()
        {
            IEnumerable<Audio> audios =
                from doc in documents
                where doc.type == Type.AUDIO
                select (Audio)doc;

            return audios;
        }

        public IEnumerable<Video> DocumentsVideo()
        {
            IEnumerable<Video> videos =
                from doc in documents
                where doc.type == Type.VIDEO
                select (Video)doc;

            return videos;
        }

        public IEnumerable<Texte> DocumentsTexte()
        {
            IEnumerable<Texte> textes =
                from doc in documents
                where doc.type == Type.TEXTE
                select (Texte)doc;

            return textes;
        }

        public IEnumerable<Multimedia> DocumentsMultimedia()
        {
            IEnumerable<Multimedia> multimedias =
                from doc in documents
                where doc.type == Type.TEXTE
                select (Multimedia)doc;

            return multimedias;
        }

        public void Sauvegarder(string filename = "mediatheque.dat")
        {
            FileStream file = File.Open(filename, FileMode.OpenOrCreate);
            XmlSerializer serializer = new XmlSerializer(typeof(Mediatheque));
            serializer.Serialize(file, this);
            file.Close();
        }

        public static Mediatheque Charger(string filename = "mediatheque.dat")
        {
            FileStream file = File.Open(filename, FileMode.Open);
            XmlSerializer serializer = new XmlSerializer(typeof(Mediatheque));
            Mediatheque maMediatheque = (Mediatheque)serializer.Deserialize(file);
            file.Close();
            return maMediatheque;
        }
    }
}
