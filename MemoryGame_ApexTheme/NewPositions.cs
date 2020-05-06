using System.Threading.Tasks;

namespace MemoryGame_ApexTheme
{
    interface NewPositions
    {
        Task<CardPositions[]> ReturnNewPositions();
    }
}
