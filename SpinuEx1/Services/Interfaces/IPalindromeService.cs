using SpinuEx1.Models;

namespace SpinuEx1.Services.Interfaces
{
    public interface IPalindromeService
    {
        public bool PalindromeDataCheck(PalindromeTest obj);
        public string PalindromeCalculator(int value);
    }
}
