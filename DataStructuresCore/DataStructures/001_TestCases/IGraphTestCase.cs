namespace _001_TestCases;

public interface IGraphTestCase
{
    int GetN();
    int GetK();
    int GetSrc();
    int GetDst();
    int[][] GetFlights();
    int GetAns();
}