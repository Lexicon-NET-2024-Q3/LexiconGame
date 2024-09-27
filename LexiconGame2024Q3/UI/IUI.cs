
namespace LexiconGame2024Q3.UI
{
    public interface IUI
    {
        void AddMessage(string message);
        void Clear();
        void Draw(Map map);
        ConsoleKey GetKey();
        void PrintLog();
        void PrintStats(string stats);
    }
}