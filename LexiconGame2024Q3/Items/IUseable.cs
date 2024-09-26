
namespace LexiconGame2024Q3.Items
{
    internal interface IUseable
    {
        void Use(Creature creature);
        void Use(Creature creature, Action<Creature> action);
    }
}