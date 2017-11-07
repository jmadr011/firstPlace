using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace gameLib
{
    public class GameFactory
    {
        StreamWriter sw;
        XmlSerializer serial;
        List<Game> gameList;
        const string GAME_FILENAME = @"..\..\games.xml";

        public void CreateGameData()
        {
            gameList = new List<Game>();
            Game G = new Game("Raptors", 90, "Heat", 95);
            gameList.Add(G);
            G = new Game("Warriors", 101, "Spurs", 105);
            gameList.Add(G);
            G = new Game("Pelicans", 88, "Suns", 92);
            gameList.Add(G);
            G = new Game("Celtics", 99, "Cavaliers", 110);
            gameList.Add(G);
            G = new Game("Grizzlies", 98, "Lakers", 100);
            gameList.Add(G);
            G = new Game("Knicks", 92, "Wizards", 93);
            gameList.Add(G);

            serial = new XmlSerializer(gameList.GetType());
            sw = new StreamWriter(GAME_FILENAME);
            serial.Serialize(sw, gameList);
            sw.Close();
        }

        public List<Game> ReadGameData(out string resultMessage)
        {
            try
            {
                gameList = new List<Game>();
                StreamReader sr = new StreamReader(GAME_FILENAME);
                serial = new XmlSerializer(gameList.GetType());
                gameList = (List<Game>)serial.Deserialize(sr);
                sr.Close();
                resultMessage = "Success";
                return gameList;
            }
            catch (Exception ex)
            {
                resultMessage = "Exception thrown: " + ex.Message;
                return null;
            }
        }
    }
}