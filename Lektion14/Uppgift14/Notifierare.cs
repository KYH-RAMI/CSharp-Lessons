
namespace Lektion14.Uppgift14
{
    internal class Notifierare
    {
        private readonly IMeddelandeTjänst _tjänst;
        public Notifierare(IMeddelandeTjänst tjänst) => _tjänst = tjänst;
        public void SkickaNotis(string meddelande)
        {
            _tjänst.Skicka(meddelande);
        }

    }
}
