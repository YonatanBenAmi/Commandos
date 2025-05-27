namespace Commandos.Models
{
    public class CommandoFactory
    {
        int nameCode = 1;
        int numName = 1;

        List<Commado> commandoList = new List<Commado>();


        //Create Enemy instance and push to list. 
        public void CreateCommandoInstance(string type, string name)
        {
            Commado commado;
            switch (type)
            {
                case "AirCommando":
                    commado = new AirCommando($"soldier{numName}", nameCode);
                    commandoList.Add(commado);
                    break;
                case "SeaCommando":
                    commado = new SeaCommando($"soldier{numName}", nameCode);
                    commandoList.Add(commado);
                    break;
                default:
                    commado = new AirCommando($"soldier{numName}", nameCode);
                    commandoList.Add(commado);
                    break;
            }
        }
    }
}