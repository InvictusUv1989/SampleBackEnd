using Newtonsoft.Json;

namespace SampleBackEnd.Utitlites
{
    public class JsonUtility
    {
        public static T JsonToObject<T>(string filename) {

            using (StreamReader r = new StreamReader(filename))
            {
                string json = r.ReadToEnd();
                return JsonConvert.DeserializeObject<T>(json);

            }

        }
    }
}
