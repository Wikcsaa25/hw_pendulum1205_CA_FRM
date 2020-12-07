using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_pendulum1205_CA
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadWrite();
        }
        private static void ReadWrite()
        {
            using (StreamWriter sw = new StreamWriter("pendulum.sql"))
            {
                StreamReader sr = new StreamReader("pendulum.txt");
                sr.ReadLine();
                bool witch = true;
                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine();
                    if (sor == "[tracks]") witch = false;
                    else
                    {
                        if (witch)
                        {
                            Album album = new Album(sor);
                            sw.WriteLine($"INSERT INTO Albums VALUES('{album.albumId}', '{album.artistName}','{album.albumName}','{album.albumRelase.ToString("yyyy-MM-dd")}')");
                        }
                        else
                        {
                            Track track = new Track(sor);
                            sw.WriteLine($"INSERT INTO Tracks VALUES('{track.musicTitle}', '00:{track.musicLength}', '{track.albumTid}','{track.musicUrl}')");
                        }
                    }
                }
                sr.Close();
                sw.WriteLine("GO");
            }
            using (StreamWriter sw = new StreamWriter("hooligans.sql"))
            {
                StreamReader sr = new StreamReader("hooligans.txt");
                sr.ReadLine();
                bool witch = true;
                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine();
                    if (sor == "[tracks]") witch = false;
                    else
                    {
                        if (witch)
                        {
                            Album album = new Album(sor);
                            sw.WriteLine($"INSERT INTO Albums VALUES('{album.albumId}', '{album.artistName}','{album.albumName}','{album.albumRelase.ToString("yyyy-MM-dd")}')");
                        }
                        else
                        {
                            Track track = new Track(sor);
                            sw.WriteLine($"INSERT INTO Tracks VALUES('{track.musicTitle}', '00:{track.musicLength}', '{track.albumTid}','{track.musicUrl}')");
                        }
                    }
                }
                sr.Close();
                sw.WriteLine("GO");
            }
        }
    }
    class Album
    {
        public string albumId;
        public string artistName;
        public string albumName;
        public DateTime albumRelase;

        public Album(string row)
        {
            string[] tmp = row.Split(';');
            this.albumId = tmp[0];
            this.artistName = tmp[1];
            this.albumName = tmp[2];
            this.albumRelase = DateTime.Parse(tmp[3]);
        }
    }
    class Track
    {
        public string musicTitle;
        public string musicLength;
        public string albumTid;
        public string musicUrl;

        public Track(string wor)
        {
            string[] db = wor.Split(';');
            this.musicTitle = db[0];
            this.musicLength = db[1];
            this.albumTid = db[2];
            this.musicUrl = db[3];
        }
    }

}
